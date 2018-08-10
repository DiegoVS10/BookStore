using BookStore.Domain.Base;
using Flunt.Validations;

namespace BookStore.Domain.Books.Entities
{
    public class Book : Entity
    {
        public Book(string title, string author, string edition, string publisher, string isbn, int quantity, decimal price)
        {
            Title = title.TrimEnd();
            Author = author.TrimEnd();
            Edition = edition.TrimEnd();
            Publisher = publisher.TrimEnd();
            Isbn = isbn.TrimEnd();
            Quantity = quantity;
            Price = price;

            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Title, "Title", "Titulo é obrigatório.")
                .HasMaxLen(Title, 100, "Title", "Titulo deve conter no máximo 100 caracteres.")
                .IsNotNullOrEmpty(Author, "Author", "Autor é obrigatório.")
                .HasMaxLen(Author, 100, "Author", "Autor deve conter no máximo 100 caracteres.")
                .IsNotNullOrEmpty(Edition, "Edition", "Edição é obrigatório.")
                .HasMaxLen(Edition, 10, "Edition", "Edição deve conter no máximo 10 caracteres.")
                .IsNotNullOrEmpty(Publisher, "Publisher", "Editora é obrigatório.")
                .HasMaxLen(Publisher, 100, "Publisher", "Editora deve conter no máximo 100 caracteres.")
                .IsNotNullOrEmpty(Isbn, "Isbn", "ISBN é obrigatório.")
                .HasMaxLen(Isbn, 13, "Isbn", "ISBN deve conter no máximo 13 caracteres.")
                .IsGreaterThan(Quantity, 0, "Quantity", "Quantidade deve ser maior que 0.")
                .HasMaxLen(Quantity.ToString(), 4, "Quantity", "Quandidade deve conter no máximo 4 carecteres.")
                .IsGreaterThan(Price, 0, "Price", "Preço deve ser maior que 0."));
        }

        protected Book() { }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Edition { get; private set; }
        public string Publisher { get; private set; }
        public string Isbn { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
