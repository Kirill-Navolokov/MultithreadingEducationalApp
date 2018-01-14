using Ninject;
using Ninject.Modules;

namespace MultithreadingEducationalApp.IoC
{
    public class IoCInitializer
    {
        private static IKernel _kernel;

        public static void Initizlize(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _kernel.Get<T>();
        }
    }
}