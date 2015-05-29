using DonglesAreGreat.Core.Repositories;
using DonglesAreGreat.Core.Services;
using DonglesAreGreat.Core.Services.Interfaces;
using Ninject;

namespace DonglesAreGreat.Infrastructure
{
    public static class Registry
    {
        public static void RegisterServices(IKernel kernel)
        {
            
            kernel.Bind<IClassLoggingService>()
                .ToMethod(context => new ClassLoggingService(context.Request.Target.Member.DeclaringType));
            kernel.Bind<IDongleRepository>().To<DongleRepository>();
        }
    }
}