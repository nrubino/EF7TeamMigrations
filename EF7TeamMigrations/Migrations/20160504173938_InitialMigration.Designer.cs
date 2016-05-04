using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EF7TeamMigrations;

namespace EF7TeamMigrations.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20160504173938_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF7TeamMigrations.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistId");

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");
                });

            modelBuilder.Entity("EF7TeamMigrations.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ArtistId");
                });

            modelBuilder.Entity("EF7TeamMigrations.Models.Album", b =>
                {
                    b.HasOne("EF7TeamMigrations.Models.Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");
                });
        }
    }
}
