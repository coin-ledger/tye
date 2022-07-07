using System;
using System.Threading.Tasks;

namespace Microsoft.Tye.Hosting
{
    public delegate Task ProcessRunnerInvoker(Func<ProcessRunner, Task> callback);
}
