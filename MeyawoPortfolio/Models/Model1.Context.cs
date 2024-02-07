
namespace MeyawoPortfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbMyPortfolioEntities5 : DbContext
    {
        public DbMyPortfolioEntities5()
            : base("name=DbMyPortfolioEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAbout> TblAbout { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblContact> TblContact { get; set; }
        public virtual DbSet<TblFuture> TblFuture { get; set; }
        public virtual DbSet<TblProject> TblProject { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblSocialMedia> TblSocialMedia { get; set; }
        public virtual DbSet<TblTestimonial> TblTestimonial { get; set; }
        public virtual DbSet<TblAdminSidebar> TblAdminSidebar { get; set; }
        public virtual DbSet<TblEducation> TblEducation { get; set; }
    
        public virtual ObjectResult<string> LastProjectName()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LastProjectName");
        }
    }
}
