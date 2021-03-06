﻿// <auto-generated />
using System;
using AgentPropertySystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgentPropertySystem.Migrations
{
    [DbContext(typeof(AgentPropertyDbContext))]
    [Migration("20180928105824_AgentProperty")]
    partial class AgentProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgentPropertySystem.Models.AgentDetail", b =>
                {
                    b.Property<Guid>("AgentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgentAge");

                    b.Property<string>("AgentName");

                    b.Property<string>("DateOfBirth");

                    b.Property<Guid?>("PropertyDetailPropertyID");

                    b.Property<string>("PropertyName");

                    b.HasKey("AgentID");

                    b.HasIndex("PropertyDetailPropertyID");

                    b.ToTable("AgentDetails");
                });

            modelBuilder.Entity("AgentPropertySystem.Models.PropertyDetail", b =>
                {
                    b.Property<Guid>("PropertyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PropertyName");

                    b.Property<string>("PropertyType");

                    b.HasKey("PropertyID");

                    b.ToTable("PropertyDetails");
                });

            modelBuilder.Entity("AgentPropertySystem.Models.AgentDetail", b =>
                {
                    b.HasOne("AgentPropertySystem.Models.PropertyDetail", "PropertyDetail")
                        .WithMany()
                        .HasForeignKey("PropertyDetailPropertyID");
                });
#pragma warning restore 612, 618
        }
    }
}
