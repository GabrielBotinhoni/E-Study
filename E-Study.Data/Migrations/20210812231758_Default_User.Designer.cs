// <auto-generated />
using System;
using E_Study.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Study.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210812231758_Default_User")]
    partial class Default_User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Study.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = new Guid("98c4a5e4-4a8a-4316-81c5-db6c29a13989"),
                            Email = "gabrielbotinhoni@gmail.com",
                            EmailConfirmed = false,
                            Enabled = true,
                            LastName = "Administrador",
                            Name = "Gabriel",
                            Password = "LiYXbO40kAVhixBcchUlwDCHJiA=",
                            userType = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
