using System;
using System.Threading;

namespace BMCapture.OldWpf
{
    public static class MtaHelper
    {
        public static void ExecuteMtaAction(Action action)
        {
            var resetEvent = new ManualResetEvent(false);

            ThreadPool.QueueUserWorkItem((_) =>
            {
                action.Invoke();
                resetEvent.Set();
            });

            resetEvent.WaitOne();
        }

        public static T? ExecuteMtaFunction<T>(Func<T> function)
        {
            var resetEvent = new ManualResetEvent(false);

            object? resultProxy = null;

            ThreadPool.QueueUserWorkItem((_) =>
            {
                resultProxy = function.Invoke();

                resetEvent.Set();
            });

            resetEvent.WaitOne();

            var result = (T?)resultProxy;

            return result;
        }
    }
}
