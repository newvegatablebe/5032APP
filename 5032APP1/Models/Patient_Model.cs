using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _5032APP1.Models
{
    public partial class Patient_Model : DbContext
    {
        public Patient_Model()
            : base("name=Patient_Model")
        {
        }

        public virtual DbSet<Patience> Patiences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
