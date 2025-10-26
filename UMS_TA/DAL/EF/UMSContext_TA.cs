using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class UMSContext_TA: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<PaperPublishList> paperPublishLists { get; set; }
        public DbSet<FeedandSurvery> feedandSurveries { get; set; }
        public DbSet<ConvocationRequest> convocationRequests { get; set; }
        public DbSet<CertificationTable> certificationTables { get; set; }
        public DbSet<ApplyThesis> ApplyTheses { get; set; }
        public DbSet<AddRequestPaperPublish> addRequestPaperPublishes { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConvocationRequest>().HasRequired(c => c.Student)
                .WithMany(s => (ICollection<ConvocationRequest>)s.convocationRequests)
                .HasForeignKey(c => c.S_ID)
                .WillCascadeOnDelete(false);
        }

    }
}
