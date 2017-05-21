using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Context;
using Platform.Data.Account;

namespace Platform.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StorageContext context)
        {
            context.Database.EnsureCreated();

            context.Users.Add(new User { Money = 100.0 });

            context.SaveChanges();
        }
    }
}
