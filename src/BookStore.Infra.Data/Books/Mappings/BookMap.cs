using BookStore.Domain.Books.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infra.Data.Books.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .HasColumnName("BookId");

            builder.Property(l => l.Title)
                .HasColumnName("Title")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(l => l.Author)
                .HasColumnName("Author")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(l => l.Edition)
                .HasColumnName("Edition")
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(l => l.Publisher)
                .HasColumnName("Publisher")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(l => l.Isbn)
                .HasColumnName("Isbn")
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(l => l.Quantity)
                .HasColumnName("Quantity");

            builder.Property(l => l.Price)
                .HasColumnName("Price"); 

            // Flunt properties
            builder.Ignore(x => x.Valid);
            builder.Ignore(x => x.Invalid);
            builder.Ignore(x => x.Notifications);
        }
    }
}
