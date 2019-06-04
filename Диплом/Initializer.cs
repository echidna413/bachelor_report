using Domain.Core;
using Infrastructure.Data.Utilities;
using System;
using System.Data.Entity;
using System.IO;

namespace Infrastructure.Data
{
    internal class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context database)
        {
            //Тут инициализируется БД
        }
    }
}