using System;
using System.Collections.Concurrent;
using System.Threading;

namespace FoxKit.Framework.Concurrency
{
    public class UnityThreadCommandDispatcher : IUnityThreadCommandDispatcher
    {
        private const int DefaultMaxCommandsPerUpdate = 100;
        private readonly ConcurrentQueue<Tuple<IUnityThreadCommand, AutoResetEvent>> commands = new ConcurrentQueue<Tuple<IUnityThreadCommand, AutoResetEvent>>();
        private readonly int maxCommandsPerUpdate;

        public UnityThreadCommandDispatcher() : this(DefaultMaxCommandsPerUpdate)
        {
        }

        public UnityThreadCommandDispatcher(int maxCommandsToProcessPerUpdate)
        {
            maxCommandsPerUpdate = maxCommandsToProcessPerUpdate;
        }

        public AutoResetEvent DispatchCommand(IUnityThreadCommand command)
        {
            var autoResetEvent = new AutoResetEvent(false);
            var queueEntry = Tuple.Create(command, autoResetEvent);
            commands.Enqueue(queueEntry);
            return autoResetEvent;
        }

        public void Update()
        {
            for (var i = 0; i < maxCommandsPerUpdate; i++)
            {
                if (commands.IsEmpty) return;

                Tuple<IUnityThreadCommand, AutoResetEvent> queueEntry;
                if (!commands.TryDequeue(out queueEntry)) continue;

                queueEntry.Item1.Execute();
                queueEntry.Item2.Set();
            }
        }
    }
}