using PreSchool.Database;
using PreSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreSchool.Utils
{
    internal class StartupTask
    {
        public static void CreateGroups()
        {
            using var db = new SchoolContext();

            if (db.Groups.Any()) return;
            db.Groups.Add(new Group { Name = "Avdelning Ett" });
            db.Groups.Add(new Group { Name = "Avdelning Två" });
            db.Groups.Add(new Group { Name = "Avdelning Tre" });
            db.SaveChanges();
        }

   
    }
}
