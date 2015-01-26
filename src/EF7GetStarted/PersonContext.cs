using EF7GetStarted.Models;
using Microsoft.Data.Entity;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using Dapper;
//using System.Linq;

namespace EF7GetStarted
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            base.OnConfiguring(options);
        }

        //public List<Person> GetList()
        //{
        //    using (var con = new SqlConnection())
        //    {
        //        var list = con.Query<Person>("SELECT * FROM [Person]").ToList();

        //        return list;
        //    }
        //}
    }
}