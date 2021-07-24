﻿// <auto-generated />
using System;
using CountyRP.Services.Game.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CountyRP.Services.Game.Infrastructure.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20210724093757_MakeForeignKeysNullable")]
    partial class MakeForeignKeysNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.AdminLevelDao", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<bool>("Ban")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateAtm")
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

                    b.Property<bool>("DeleteAtm")
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

                    b.Property<bool>("EditAtm")
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
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("AdminLevels");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.AppearanceDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BlendShape")
                        .HasColumnType("real");

                    b.Property<float>("BlendSkin")
                        .HasColumnType("real");

                    b.Property<float>("BrowHeight")
                        .HasColumnType("real");

                    b.Property<float>("BrowWidth")
                        .HasColumnType("real");

                    b.Property<float>("CBoneHeight")
                        .HasColumnType("real");

                    b.Property<float>("CBoneWidth")
                        .HasColumnType("real");

                    b.Property<float>("CheekWidth")
                        .HasColumnType("real");

                    b.Property<float>("ChinLength")
                        .HasColumnType("real");

                    b.Property<float>("ChinPos")
                        .HasColumnType("real");

                    b.Property<float>("ChinShape")
                        .HasColumnType("real");

                    b.Property<float>("ChinWidth")
                        .HasColumnType("real");

                    b.Property<int>("EyeColor")
                        .HasColumnType("int");

                    b.Property<float>("Eyes")
                        .HasColumnType("real");

                    b.Property<int>("FatherBlend")
                        .HasColumnType("int");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<int>("HairColor")
                        .HasColumnType("int");

                    b.Property<int>("HairHighlight")
                        .HasColumnType("int");

                    b.Property<float>("JawHeight")
                        .HasColumnType("real");

                    b.Property<float>("JawWidth")
                        .HasColumnType("real");

                    b.Property<float>("Lips")
                        .HasColumnType("real");

                    b.Property<int>("MotherBlend")
                        .HasColumnType("int");

                    b.Property<float>("NeckWidth")
                        .HasColumnType("real");

                    b.Property<float>("NoseBridge")
                        .HasColumnType("real");

                    b.Property<float>("NoseBridgeShift")
                        .HasColumnType("real");

                    b.Property<float>("NoseHeight")
                        .HasColumnType("real");

                    b.Property<float>("NoseTip")
                        .HasColumnType("real");

                    b.Property<float>("NoseWidth")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Appearances");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.AtmDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessId")
                        .HasColumnType("int");

                    b.Property<long>("Dimension")
                        .HasColumnType("bigint");

                    b.Property<string>("_Position")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.ToTable("Atms");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.BusinessDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EntranceDimension")
                        .HasColumnType("bigint");

                    b.Property<long>("ExitDimension")
                        .HasColumnType("bigint");

                    b.Property<bool>("LockDoors")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("_EntrancePosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EntrancePosition");

                    b.Property<string>("_ExitPosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExitPosition");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.FactionDao", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Color")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("_Ranks")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ranks");

                    b.HasKey("Id");

                    b.ToTable("Factions");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.GangDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("_Ranks")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ranks");

                    b.HasKey("Id");

                    b.ToTable("Gangs");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.GarageDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EntranceDimension")
                        .HasColumnType("bigint");

                    b.Property<float>("EntranceRotation")
                        .HasColumnType("real");

                    b.Property<long>("ExitDimension")
                        .HasColumnType("bigint");

                    b.Property<bool>("LockDoors")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("_EntrancePosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EntrancePosition");

                    b.HasKey("Id");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.HouseDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EntranceDimension")
                        .HasColumnType("bigint");

                    b.Property<long>("ExitDimension")
                        .HasColumnType("bigint");

                    b.Property<int?>("GarageId")
                        .HasColumnType("int");

                    b.Property<bool>("LockDoors")
                        .HasColumnType("bit");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("SafeDimension")
                        .HasColumnType("bigint");

                    b.Property<int>("SafeInventoryId")
                        .HasColumnType("int");

                    b.Property<string>("_EntrancePosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EntrancePosition");

                    b.Property<string>("_ExitPosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExitPosition");

                    b.Property<string>("_SafePosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SafePosition");

                    b.HasKey("Id");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.LockerRoomDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Dimension")
                        .HasColumnType("bigint");

                    b.Property<string>("FactionId")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("TypeMarker")
                        .HasColumnType("int");

                    b.Property<string>("_ColorMarker")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColorMarker");

                    b.Property<string>("_Position")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.ToTable("LockerRooms");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.PersonDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminLevelId")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("CommonInventoryId")
                        .HasColumnType("int");

                    b.Property<string>("FactionId")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int?>("GangId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastVisitDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Leader")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PocketsInventoryId")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("RegistrationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("_Position")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.PlayerDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("LastVisitDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Login")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Password")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTimeOffset>("RegistrationDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.RoomDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("ColorBlip")
                        .HasColumnType("tinyint");

                    b.Property<long>("EntranceDimension")
                        .HasColumnType("bigint");

                    b.Property<long>("ExitDimension")
                        .HasColumnType("bigint");

                    b.Property<int?>("GangId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastPaymentDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("LockDoors")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("SafeDimension")
                        .HasColumnType("bigint");

                    b.Property<int>("TypeBlip")
                        .HasColumnType("int");

                    b.Property<int>("TypeMarker")
                        .HasColumnType("int");

                    b.Property<string>("_ColorMarker")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColorMarker");

                    b.Property<string>("_EntrancePosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EntrancePosition");

                    b.Property<string>("_ExitPosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExitPosition");

                    b.Property<string>("_SafePosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SafePosition");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.TeleportDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessId")
                        .HasColumnType("int");

                    b.Property<byte>("ColorBlip")
                        .HasColumnType("tinyint");

                    b.Property<long>("EntranceDimension")
                        .HasColumnType("bigint");

                    b.Property<long>("ExitDimension")
                        .HasColumnType("bigint");

                    b.Property<string>("FactionId")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int?>("GangId")
                        .HasColumnType("int");

                    b.Property<bool>("LockDoors")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("TypeBlip")
                        .HasColumnType("int");

                    b.Property<int>("TypeMarker")
                        .HasColumnType("int");

                    b.Property<string>("_ColorMarker")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColorMarker");

                    b.Property<string>("_EntrancePosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EntrancePosition");

                    b.Property<string>("_ExitPosition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExitPosition");

                    b.HasKey("Id");

                    b.ToTable("Teleports");
                });

            modelBuilder.Entity("CountyRP.Services.Game.Infrastructure.Entities.VehicleDao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Color1")
                        .HasColumnType("int");

                    b.Property<int>("Color2")
                        .HasColumnType("int");

                    b.Property<long>("Dimension")
                        .HasColumnType("bigint");

                    b.Property<string>("FactionId")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<double>("Fuel")
                        .HasColumnType("float");

                    b.Property<string>("LicensePlate")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<bool>("LockDoors")
                        .HasColumnType("bit");

                    b.Property<int>("Model")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<float>("Rotation")
                        .HasColumnType("real");

                    b.Property<string>("_Position")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
