using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Platform.Context;
using Platform.Data.Account;

namespace Platform.Test
{
    [TestClass]
    public class Context
    {
        StorageContext context = new StorageContext(new DbContextOptions<StorageContext>());

        [TestMethod]
        public void InitializeContext()
        {
            context.Database.EnsureCreated();

            context.Users.Add(new User { Money = 100.0 });

            context.SaveChanges();
        }

        [TestMethod]
        public void DropContext()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
