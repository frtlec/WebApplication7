using SharpAspect;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    [InterceptFor(typeof(LogAttribute))]
    public class LogInterceptor : MethodInterceptor
    {
        private readonly Logger logger;

        // The Logger dependency will be resolved using Microsoft's DI container
        public LogInterceptor(Logger logger)
        {
            this.logger = logger;
        }

        // MethodInterceptor class provides OnBefore, OnAfter and OnError methods.
        // You can override these methods to seperate the logic you don't want in your actual method.
        public override Task OnBefore(IInvocation invocation)
        {
            logger.LogInfo($"[Log] Executing method: {invocation.TargetType.FullName}.{invocation.Method.Name}");

            return Task.FromResult(Task.CompletedTask);
        }
    }

}
