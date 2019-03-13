﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RouseMusicianPortfolioSite.Data;

namespace RouseMusicianPortfolioSite.Migrations
{
    [DbContext(typeof(SubscribeContext))]
    partial class SubscribeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RouseMusicianPortfolioSite.Models.Subscriber", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Email");

                    b.ToTable("Subscriber");
                });
#pragma warning restore 612, 618
        }
    }
}