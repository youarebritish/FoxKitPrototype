using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.Classes;
using FoxTool.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using UnityEditor;

namespace FoxKit.Framework.FormatHandlers.DataSet
{
    public class EntityClassGenerator
    {
        private const string classDirectory = "Assets/Scripts/Framework/Tpp/Classes/";

        public static void GenerateEntityClass(FoxEntity foxEntity)
        {
            var fileName = classDirectory + foxEntity.ClassName + ".cs";

            if (File.Exists(fileName))
            {
                throw new ArgumentException("Class " + foxEntity.ClassName + " already exists.");
            }
            using (var outfile = new StreamWriter(fileName))
            {
                // Write using statements
                foreach (var statement in MakeUsingStatements())
                {
                    outfile.WriteLine(statement);
                }
                outfile.WriteLine("");
                outfile.WriteLine(MakeNamespaceStatement());

                // Opening brace for namespace declaration.
                outfile.WriteLine("{");
                var parentClass = DetermineParentClass(foxEntity);
                outfile.WriteLine("    " + MakeClassNameDeclaration(foxEntity.ClassName, GetRealTypeName(parentClass)));

                // Opening brace for class declaration.
                outfile.WriteLine("    {");

                // Write properties.
                var inheritedFields = GetInheritedPropertyNames(parentClass).Select(field => field.ToLower());
                var hasWrittenFirstProperty = false;
                foreach (var property in foxEntity.StaticProperties.Where(property => !inheritedFields.Contains(property.Name.ToLower())))
                {
                    if (hasWrittenFirstProperty)
                    {
                        outfile.WriteLine("");
                    }
                    outfile.WriteLine(MakeFieldAttribute(property.Name, property.DataType, property.ContainerType, false));
                    outfile.WriteLine(MakeFieldDeclaration(property.Name, GetNativeType(property.DataType), property.ContainerType));
                    hasWrittenFirstProperty = true;
                }

                foreach (var property in foxEntity.DynamicProperties.Where(property => !inheritedFields.Contains(property.Name.ToLower())))
                {
                    if (hasWrittenFirstProperty)
                    {
                        outfile.WriteLine("");
                    }
                    outfile.WriteLine(MakeFieldAttribute(property.Name, property.DataType, property.ContainerType, true));
                    outfile.WriteLine(MakeFieldDeclaration(property.Name, GetNativeType(property.DataType), property.ContainerType));
                    hasWrittenFirstProperty = true;
                }

                // Closing brace for class declaration.
                outfile.WriteLine("    }");

                // Closing brace for namespace declaration.
                outfile.WriteLine("}");
            }
            // Need to dispatch this to main thread
            //AssetDatabase.Refresh();
        }

        private static IEnumerable<string> MakeUsingStatements() => new List<string>()
        {
            "using System;",
            "using System.Collections.Generic;",
            "using FoxKit.Framework.Fox;",
            "using FoxTool.Fox.Types;",
            "using FoxTool.Fox.Containers;",
            "using FoxTool.Fox.Types.Structs;",
            "using UnityEngine;"
        };

        private static string MakeNamespaceStatement() => "namespace FoxKit.Framework.Tpp.Classes";

        private static string MakeClassNameDeclaration(string className, string parentClassName) => "public class " + className + " : " + parentClassName;

        private static Type DetermineParentClass(FoxEntity foxEntity)
        {
            const string namePropertyName = "name";
            const string dataSetPropertyName = "dataSet";
            const string ownerPropertyName = "owner";
            const string parentPropertyName = "parent";
            const string transformPropertyName = "transform";
            const string shearTransformPropertyName = "shearTransform";
            const string pivotTransformPropertyName = "pivotTransform";
            const string childrenPropertyName = "children";
            const string flagsPropertyName = "flags";
            const string sizePropertyName = "size";

            var propertiesToCheck =
                new Dictionary<string, bool>
                {
                    {namePropertyName, false},
                    {dataSetPropertyName, false},
                    {ownerPropertyName, false},
                    {parentPropertyName, false},
                    {transformPropertyName, false},
                    {shearTransformPropertyName, false},
                    {pivotTransformPropertyName, false},
                    {childrenPropertyName, false},
                    {flagsPropertyName, false},
                    {sizePropertyName, false},
                };

            foreach (var property in foxEntity.StaticProperties)
            {
                if (propertiesToCheck.ContainsKey(property.Name))
                {
                    propertiesToCheck[property.Name] = true;
                }
            }

            // An Entity is a subclass of Data if it has a "name" and "dataSet" property.
            if (propertiesToCheck[namePropertyName] && propertiesToCheck[dataSetPropertyName])
            {
                // An Entity is a subclass of TransformData if it has a "parent," "transform," "shearTransform," "pivotTransform," "children," and "flags" property.
                if (propertiesToCheck[parentPropertyName] 
                    && propertiesToCheck[transformPropertyName] 
                    && propertiesToCheck[shearTransformPropertyName]
                    && propertiesToCheck[pivotTransformPropertyName]
                    && propertiesToCheck[childrenPropertyName]
                    && propertiesToCheck[flagsPropertyName])
                {
                    // An Entity is a subclass of Locator if it has a "size" property.
                    if (propertiesToCheck[sizePropertyName])
                    {
                        return typeof(Locator);
                    }
                    return typeof(TransformData);
                }
                
                return typeof(Data);
            }

            // An Entity is a subclass of DataElement<T> if it has an "owner" property.
            if (propertiesToCheck[ownerPropertyName])
            {
                // TODO: Is there a way to determine the actual generic type argument?
                return typeof(DataElement<Entity>);
            }

            return typeof(Entity);
        }

        private static string MakeFieldAttribute(string propertyName, FoxDataType dataType, FoxContainerType containerType,
            bool isDynamic)
        {
            var attributeStringBuilder = new StringBuilder("        [EntityProperty(\"");
            attributeStringBuilder.Append(propertyName);
            attributeStringBuilder.Append("\", FoxDataType.");
            attributeStringBuilder.Append(dataType);
            attributeStringBuilder.Append(", FoxContainerType.");
            attributeStringBuilder.Append(containerType);

            if (isDynamic)
            {
                attributeStringBuilder.Append(", true");
            }

            attributeStringBuilder.Append(")]");
            return attributeStringBuilder.ToString();
        }

        private static string MakeFieldDeclaration(string propertyName, Type propertyType, FoxContainerType containerType)
        {
            return "        public " + GetFieldName(propertyType, containerType) + " " + char.ToUpper(propertyName[0]) + propertyName.Substring(1) + ";";
        }

        private static string GetFieldName(Type propertyType, FoxContainerType containerType)
        {
            var typeName = GetRealTypeName(propertyType);
            switch (containerType)
            {
                case FoxContainerType.StaticArray:
                    return typeName;
                case FoxContainerType.DynamicArray:
                    return "List<" + typeName + ">";
                case FoxContainerType.StringMap:
                    return "Dictionary<string, " + typeName + ">";
                case FoxContainerType.List:
                    return "List<" + typeName + ">";
                default:
                    throw new ArgumentOutOfRangeException(nameof(containerType), containerType, null);
            }
        }

        private static Type GetNativeType(FoxDataType foxType)
        {
            var result = EntityUtils.GetNativeTypeForFoxType(foxType);
            if (result != null) return result;

            throw new NotImplementedException("Automatic mapping of type " + foxType + " has not been implemented.");
        }

        private static IEnumerable<string> GetInheritedPropertyNames(Type entityType) => entityType.GetFields().Where(field => field.IsPublic).Select(field => field.Name);

        private static string GetRealTypeName(Type t)
        {
            if (!t.IsGenericType)
                return t.Name;

            StringBuilder sb = new StringBuilder();
            sb.Append(t.Name.Substring(0, t.Name.IndexOf('`')));
            sb.Append('<');
            bool appendComma = false;
            foreach (Type arg in t.GetGenericArguments())
            {
                if (appendComma) sb.Append(',');
                sb.Append(GetRealTypeName(arg));
                appendComma = true;
            }
            sb.Append('>');
            return sb.ToString();
        }
    }
}