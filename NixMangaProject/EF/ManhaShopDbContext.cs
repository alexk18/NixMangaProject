using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NixMangaProject.EF.Models;

namespace NixMangaProject.EF
{
    public partial class ManhaShopDbContext : DbContext
    {
        public ManhaShopDbContext()
        {
        }

        public ManhaShopDbContext(DbContextOptions<ManhaShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<HistoryOrder> HistoryOrders { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductGenre> ProductGenres { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Trashbox> Trashboxes { get; set; } = null!;
        public virtual DbSet<TrashboxProductUser> TrashboxProductUsers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryOrder>(entity =>
            {
                entity.Property(e => e.HistoryId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.HistoryOrders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_HistoryOrder_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HistoryOrders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_HistoryOrder_User");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.ImageId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Image_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_Product_Publisher");
            });

            modelBuilder.Entity<ProductGenre>(entity =>
            {
                entity.Property(e => e.GenProId).ValueGeneratedNever();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.ProductGenres)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_ProductGenre_Genre");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductGenres)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductGenre_Product");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.PublisherId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Review_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Review_User");
            });

            modelBuilder.Entity<Trashbox>(entity =>
            {
                entity.Property(e => e.TrashboxId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TrashboxProductUser>(entity =>
            {
                entity.Property(e => e.SpecialId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TrashboxProductUsers)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TrashboxProductUser_Product");

                entity.HasOne(d => d.Trashbox)
                    .WithMany(p => p.TrashboxProductUsers)
                    .HasForeignKey(d => d.TrashboxId)
                    .HasConstraintName("FK_TrashboxProductUser_Trashbox");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TrashboxProductUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TrashboxProductUser_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
