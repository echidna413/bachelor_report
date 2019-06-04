using Domain.Core;
using Domain.Core.Logs;
using System.Data.Common;
using System.Data.Entity;

namespace Infrastructure.Data
{
    public class Context : DbContext
    {
        
        static Context() => Database.SetInitializer(new Initializer());

        public Context(string connectionString) : base(connectionString) { }
    }
}