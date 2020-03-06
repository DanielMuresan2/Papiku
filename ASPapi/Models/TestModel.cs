using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPapi.Models
{
    public class TestModel
    {
        public int ID { get; set; }
        public string Attr1 { get; set; }

        public int Attr2 { get; set; }
    }

    public class TestModelDBContext : DbContext
    {
        public DbSet<TestModel> Models { get; set; }
    }
}