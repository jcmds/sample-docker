// <auto-generated />
using System;
using DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAO.Migrations {
    [DbContext (typeof (Context))]
    partial class ContextModelSnapshot : ModelSnapshot {
        protected override void BuildModel (ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation ("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation ("Relational:MaxIdentifierLength", 128)
                .HasAnnotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity ("DAO.Models.Todo", b => {
                b.Property<Guid> ("Id")
                    .ValueGeneratedOnAdd ();

                b.Property<DateTime> ("CreatedIn");

                b.Property<string> ("Description");

                b.Property<bool> ("IsComplete");

                b.HasKey ("Id");

                b.ToTable ("Todos");

                b.HasData (
                    new {
                        Id = new Guid ("a5a46d9a-90c8-4f6e-81ec-cb3fdeae25bf"),
                            CreatedIn = new DateTime (2019, 4, 6, 11, 19, 38, 242, DateTimeKind.Local).AddTicks (840),
                            Description = "buy a car",
                            IsComplete = false
                    },
                    new {
                        Id = new Guid ("fe44b22a-f888-4a54-be5f-56c45979f43a"),
                            CreatedIn = new DateTime (2019, 4, 6, 11, 19, 38, 257, DateTimeKind.Local).AddTicks (1820),
                            Description = "go to the market",
                            IsComplete = false
                    },
                    new {
                        Id = new Guid ("743ea582-3de9-4cea-8709-7a2b983b4a19"),
                            CreatedIn = new DateTime (2019, 4, 6, 11, 19, 38, 257, DateTimeKind.Local).AddTicks (1840),
                            Description = "write a magazine",
                            IsComplete = false
                    },
                    new {
                        Id = new Guid ("6382728f-1341-4d02-8b40-2eb5f07e8590"),
                            CreatedIn = new DateTime (2019, 4, 6, 11, 19, 38, 257, DateTimeKind.Local).AddTicks (1840),
                            Description = "pay netflix",
                            IsComplete = false
                    });
            });
#pragma warning restore 612, 618
        }
    }
}