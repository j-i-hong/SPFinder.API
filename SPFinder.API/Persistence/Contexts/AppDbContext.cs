using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
using SPFinder.API.Domain.Models;


namespace SPFinder.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<ProviderStatus> ProviderStatus { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>().ToTable("Company");
            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd().HasValueGenerator<InMemoryIntegerValueGenerator<Guid>>();
            builder.Entity<Company>().Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Entity<Company>().HasMany(p => p.CompanyCertifications).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId);

            Company company1 = new Company { Id = new Guid("68637CD3-9680-4EAF-A7BE-4D23AF39B171"), Name = "Acme" };
            Company company2 = new Company { Id = new Guid("91810C67-738E-4B8D-95F0-5BEC4F58120D"), Name = "Amazon" };

            builder.Entity<Company>().HasData(company1, company2);

            Certification cert1 = new Certification { Id = 1, Description = "Gold certification", ImageLink = "111" };
            Certification cert2 = new Certification { Id = 2, Description = "Silver certification", ImageLink = "222" };
            Certification cert3 = new Certification { Id = 3, Description = "Bronze certification", ImageLink = "333" };

            builder.Entity<CompanyCertification>().ToTable("CompanyCertifiationXRef");
            builder.Entity<CompanyCertification>().HasKey(p => p.Id);
            builder.Entity<CompanyCertification>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<CompanyCertification>().HasData
            (
                new CompanyCertification { Id = 1, CompanyId = company1.Id, Description = cert1.Description, ImageLink = cert1.ImageLink},
                new CompanyCertification { Id = 2, CompanyId = company2.Id, Description = cert2.Description, ImageLink = cert2.ImageLink },
                new CompanyCertification { Id = 3, CompanyId = company2.Id, Description = cert3.Description, ImageLink = cert3.ImageLink }
            );
        }
    }
}
