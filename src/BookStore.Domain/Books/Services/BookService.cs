using BookStore.Domain.Books.Entities;
using BookStore.Domain.Books.Interfaces.Repository;
using BookStore.Domain.Books.Interfaces.Services;
using BookStore.Domain.UoW.Interfaces;
using System;
using System.Collections.Generic;

namespace BookStore.Domain.Books.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUnitOfWork _uow;

        public BookService(IBookRepository bookRepository,
                           IUnitOfWork uow)
        {
            _bookRepository = bookRepository;
            _uow = uow;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
            _uow.Commit();
        }

        public void Delete(Guid id)
        {
            _bookRepository.Delete(id);
            _uow.Commit();
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(Guid id)
        {
            return _bookRepository.GetById(id);
        }

        public void Update(Book book)
        {
            _bookRepository.Update(book);
            _uow.Commit();
        }
    }
}
