using AutoMapper;
using BookStore.Application.Books.AutoMapper;

namespace BookStore.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            new DomainToViewModelBook();
        }
    }
}
