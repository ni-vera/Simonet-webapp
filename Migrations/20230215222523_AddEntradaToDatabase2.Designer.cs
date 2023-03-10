// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapp;

#nullable disable

namespace webapp.Migrations
{
    [DbContext(typeof(WebappDbContext))]
    [Migration("20230215222523_AddEntradaToDatabase2")]
    partial class AddEntradaToDatabase2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapp.Models.Entrada", b =>
                {
                    b.Property<string>("entrada")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("pagina")
                        .HasColumnType("int");

                    b.HasKey("entrada");

                    b.ToTable("Entradas");
                });
#pragma warning restore 612, 618
        }
    }
}
