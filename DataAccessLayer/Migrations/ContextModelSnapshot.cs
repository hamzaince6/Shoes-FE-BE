﻿// <auto-generated />
using DataAccessLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concreate.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"));

                    b.Property<string>("AboutDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concreate.ContackForm", b =>
                {
                    b.Property<int>("ContackFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContackFormId"));

                    b.Property<string>("ContackFormBgImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContackFormImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContackFormPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContackFormStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContackFormUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContackFormId");

                    b.ToTable("ContackForms");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Customers", b =>
                {
                    b.Property<int>("CustomersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomersID"));

                    b.Property<string>("CustomersDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomersImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CustomersStatus")
                        .HasColumnType("bit");

                    b.HasKey("CustomersID");

                    b.ToTable("Customrs");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Main", b =>
                {
                    b.Property<int>("MainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainId"));

                    b.Property<string>("MainDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MainStatus")
                        .HasColumnType("bit");

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainId");

                    b.ToTable("Mains");
                });

            modelBuilder.Entity("EntityLayer.Concreate.MainSocial", b =>
                {
                    b.Property<int>("MainSocialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainSocialId"));

                    b.Property<bool>("MainIconStatus")
                        .HasColumnType("bit");

                    b.Property<string>("MainSocialIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainSocialId");

                    b.ToTable("MainSocials");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Products", b =>
                {
                    b.Property<int>("ProductsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsID"));

                    b.Property<int>("ProducstPrice")
                        .HasColumnType("int");

                    b.Property<string>("ProductsDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProductsStatus")
                        .HasColumnType("bit");

                    b.HasKey("ProductsID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Services", b =>
                {
                    b.Property<int>("ServicesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicesId"));

                    b.Property<string>("ServicesDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServicesStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ServicesTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServicesId");

                    b.ToTable("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
