using SharpAspect;
using System;

namespace bussiness
{
    [Intercept(typeof(IService))]
    public class Manager : IService
    {
        [Log]
        public string F()
        {
            return "ss";
        }
    }
}
