using BookStore.Domain.Books.Entities;
using System;
using System.Collections.Generic;

namespace BookStore.Application.Books.Services.Interfaces
{
    public interface IBookAppService
    {
        IEnumerable<Book> GetAll();
        Book GetById(Guid id);
        void Add(Book book);
        void Update(Book book);
        void Delete(Guid id);
    }
}
