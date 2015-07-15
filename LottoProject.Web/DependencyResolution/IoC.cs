using LottoProject.Domain;
using LottoProject.Web.Infrastructure;
using StructureMap;
namespace LottoProject.Web
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
                x.For<ILottoDataSource>().HttpContextScoped().Use<LottoDb>();
            });
            return ObjectFactory.Container;
        }
    }
}
