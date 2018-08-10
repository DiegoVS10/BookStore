using AutoMapper;
using BookStore.Application.Books.ViewModels;
using BookStore.Domain.Books.Entities;

namespace BookStore.Application.Books.AutoMapper
{
    public class ViewModelToDomainBook : Profile
    {
        public ViewModelToDomainBook()
        {
            CreateMap<RegisterBookViewModel, Book>();
            CreateMap<EditBookViewModel, Book>();
            CreateMap<ListBookViewModel, Book>();
        }
    }
}
