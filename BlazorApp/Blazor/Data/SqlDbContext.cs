using Blazor.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class SqlDbContext : DbContext
    {

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }
        public DbSet<Article> Article { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Thematics> Thematic { get; set; }
        public DbSet<FileModel> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>();
            modelBuilder.Entity<Autor>();
            modelBuilder.Entity<Thematics>();
            modelBuilder.Entity<FileModel>();

            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Article>().HasData(new Article
            //{
            //    ID = 1,
            //    Title = "Новый спутник запущен на орбиту",
            //    ArticleText = "text text"
            //});
        }

    }
}
