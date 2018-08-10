using AutoMapper;
using BookStore.Application.Books.ViewModels;
using BookStore.Domain.Books.Entities;

namespace BookStore.Application.Books.AutoMapper
{
    public class DomainToViewModelBook : Profile
    {
        public DomainToViewModelBook()
        {
            CreateMap<Book, RegisterBookViewModel>();
            CreateMap<Book, EditBookViewModel>();
            CreateMap<Book, ListBookViewModel>();
        }
    }
}
