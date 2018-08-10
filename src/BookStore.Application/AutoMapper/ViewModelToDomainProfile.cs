using AutoMapper;
using BookStore.Application.Books.AutoMapper;

namespace BookStore.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            new ViewModelToDomainBook();
        }
    }
}
