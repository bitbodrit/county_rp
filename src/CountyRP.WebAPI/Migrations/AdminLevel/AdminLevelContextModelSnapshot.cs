﻿// <auto-generated />
using CountyRP.WebAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CountyRP.WebAPI.Migrations.AdminLevel
{
    [DbContext(typeof(AdminLevelContext))]
    partial class AdminLevelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CountyRP.DAO.AdminLevel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Ban")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateATM")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateBusiness")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateFaction")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateGang")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateHouse")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateLockerRoom")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateRoom")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateTeleport")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateVehicle")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteATM")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteBusiness")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteFaction")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteGang")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteHouse")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteLockerRoom")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteRoom")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteTeleport")
                        .HasColumnType("bit");

                    b.Property<bool>("DeleteVehicle")
                        .HasColumnType("bit");

                    b.Property<bool>("EditATM")
                        .HasColumnType("bit");

                    b.Property<bool>("EditBusiness")
                        .HasColumnType("bit");

                    b.Property<bool>("EditFaction")
                        .HasColumnType("bit");

                    b.Property<bool>("EditGang")
                        .HasColumnType("bit");

                    b.Property<bool>("EditHouse")
                        .HasColumnType("bit");

                    b.Property<bool>("EditLockerRoom")
                        .HasColumnType("bit");

                    b.Property<bool>("EditRoom")
                        .HasColumnType("bit");

                    b.Property<bool>("EditTeleport")
                        .HasColumnType("bit");

                    b.Property<bool>("EditVehicle")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminLevels");
                });
#pragma warning restore 612, 618
        }
    }
}
