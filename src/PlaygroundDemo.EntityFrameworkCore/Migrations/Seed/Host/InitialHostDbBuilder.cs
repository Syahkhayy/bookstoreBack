using PlaygroundDemo.EntityFrameworkCore;

namespace PlaygroundDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly PlaygroundDemoDbContext _context;

        public InitialHostDbBuilder(PlaygroundDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new InitialAuthorAndBook(_context).Create();

            _context.SaveChanges();
        }
    }
}
