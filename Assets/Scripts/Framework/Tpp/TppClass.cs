using FoxKit.Framework.Tpp;
using System;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class TppClass : Attribute
{
    public readonly ClassCategory[] Categories;

    public TppClass(params ClassCategory[] categories)
    {
        Categories = categories;
    }
}