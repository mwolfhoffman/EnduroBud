using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EnduroBud;

namespace EnduroBud.Migrations.Activity
{
    [DbContext(typeof(ActivityContext))]
    [Migration("20170425170839_IntitialMigration")]
    partial class IntitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnduroBud.Models.Activity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.Property<double>("Distance");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });
        }
    }
}
