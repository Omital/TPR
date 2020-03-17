using TPR.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TPR.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TPRDbContext _context;

        public InitialHostDbBuilder(TPRDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
