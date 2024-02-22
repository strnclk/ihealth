using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        public DbSet<AboutModel> Abouts { get; set; }
        public DbSet<BlogModel> Blogs { get; set; }
        public DbSet<CompanySkillsModel> Campanys { get; set; }
        public DbSet<CategoryModel> Categorys { get; set; }
        public DbSet<CommunacationModel> Communacations { get; set; }
        public DbSet<ContactInformationModel> ContactInformations { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<SliderModel> Sliders { get; set; }
    }
}
