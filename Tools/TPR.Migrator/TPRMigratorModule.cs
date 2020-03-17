using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TPR.EntityFramework;

namespace TPR.Migrator
{
    [DependsOn(typeof(TPRDataModule))]
    public class TPRMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TPRDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}