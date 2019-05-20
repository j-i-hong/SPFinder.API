using System;
using System.Collections.Generic;
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
            //DbContextOptionsBuilder builderOption = new DbContextOptionsBuilder();
            //builderOption.EnableSensitiveDataLogging();

            base.OnModelCreating(builder);
            
            builder.Entity<Company>().ToTable("Company");
            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd().HasValueGenerator<InMemoryIntegerValueGenerator<Guid>>();
            builder.Entity<Company>().Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Entity<Company>().HasMany(p => p.CompanyCertifications).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId);


            Guid companyId1 = new Guid("68637CD3-9680-4EAF-A7BE-4D23AF39B171");
            Guid companyId2 = new Guid("91810C67-738E-4B8D-95F0-5BEC4F58120D");

            List<Company> companyList = new List<Company>
            {
                new Company { Id = companyId1, Name = "1WorldSync", Tier = Tier.Gold,  ShortDescription = @"1WorldSync™ is the leading provider of product content solutions. Enabling more than 25,000 global companies in over 60 countries to share authentic, trusted content with customers and consumers."},
                new Company { Id = companyId2, Name = "1WorldSync", Tier = Tier.Silver, ShortDescription = @"Markem-Imaje is a trusted world manufacturer of product identification and traceability solutions, offering a full line of reliable and innovative inkjet, thermal transfer, laser, print and apply label systems and track and trace software." },
            };

            builder.Entity<Company>().HasData(companyList);

            Certification cert1 = new Certification { Id = 1, Description = "Gold certification", ImageLink = "111" };
            Certification cert2 = new Certification { Id = 2, Description = "Silver certification", ImageLink = "222" };
            Certification cert3 = new Certification { Id = 3, Description = "Bronze certification", ImageLink = "333" };

            builder.Entity<CompanyCertification>().ToTable("CompanyCertifiationXRef");
            builder.Entity<CompanyCertification>().HasKey(p => p.Id);
            builder.Entity<CompanyCertification>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<CompanyCertification>().HasData
            (
                new CompanyCertification { Id = 1, CompanyId = companyId1, Description = cert1.Description, ImageLink = cert1.ImageLink},
                new CompanyCertification { Id = 2, CompanyId = companyId2, Description = cert2.Description, ImageLink = cert2.ImageLink },
                new CompanyCertification { Id = 3, CompanyId = companyId2, Description = cert3.Description, ImageLink = cert3.ImageLink }
            );
        }
    }
}
