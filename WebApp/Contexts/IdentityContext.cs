using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;


namespace WebApp.Contexts;

public class IdentityContext : IdentityDbContext
{

    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {

    }

    public DbSet<UserProfileEntity> UserProfiles { get; set; }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<ProductTagEntity> ProductTags { get; set; }
    public DbSet<ContactFormEntity> ContactForms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<TagEntity>().HasData(
            new TagEntity { Id = 1, TagName = "new" },
            new TagEntity { Id = 2, TagName = "featured" },
            new TagEntity { Id = 3, TagName = "popular" }
        );

        builder.Entity< ProductEntity>().HasData(
            new ProductEntity { Id = 1, Title = "Cat Apple Hat", Price = 12, ImageUrl = "images/placeholders/270x295.svg", Description = "Lovely hat for cat" },
            new ProductEntity { Id = 2, Title = "Cat Pear Hat", Price = 20, ImageUrl = "images/placeholders/270x295.svg", Description = "Cute hat for cat" },
            new ProductEntity { Id = 3, Title = "Cat Tomato Hat", Price = 15, ImageUrl = "images/placeholders/270x295.svg", Description = "Stylish hat for cat" }
        );

        builder.Entity<ProductTagEntity>().HasData(
            new ProductTagEntity { ProductId = 1, TagId = 1 },
            new ProductTagEntity { ProductId = 2, TagId = 2 },
            new ProductTagEntity { ProductId = 3, TagId = 3 }
        );

    }

}
