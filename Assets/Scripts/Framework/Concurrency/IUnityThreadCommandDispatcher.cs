using System.Threading;
using System.Threading.Tasks;

namespace FoxKit.Framework.Concurrency
{
    public interface IUnityThreadCommandDispatcher
    {
        AutoResetEvent DispatchCommand(IUnityThreadCommand command);

        void Update();
    }
}
