using MultithreadingEducationalApp.Implementation;
using MultithreadingEducationalApp.Interfaces;
using Ninject.Modules;

namespace MultithreadingEducationalApp.IoC
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFileProvider>().To<FileProvider>();
            Bind<IDataTransferer>().To<DataTransferer>();
        }
    }
}