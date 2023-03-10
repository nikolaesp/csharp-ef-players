// <auto-generated />
using EntityFrameworkPlayers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkPlayers.Migrations
{
    [DbContext(typeof(PlayerContext))]
    partial class PlayerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkPlayers.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero_giocate")
                        .HasColumnType("int");

                    b.Property<int>("numero_vinte")
                        .HasColumnType("int");

                    b.Property<double>("punteggio")
                        .HasColumnType("float");

                    b.Property<int>("teamid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("teamid");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("EntityFrameworkPlayers.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("allenatore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("citta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("EntityFrameworkPlayers.Player", b =>
                {
                    b.HasOne("EntityFrameworkPlayers.Team", "team")
                        .WithMany("players")
                        .HasForeignKey("teamid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("team");
                });

            modelBuilder.Entity("EntityFrameworkPlayers.Team", b =>
                {
                    b.Navigation("players");
                });
#pragma warning restore 612, 618
        }
    }
}
