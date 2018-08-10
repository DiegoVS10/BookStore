using BookStore.Application.Books.Services;
using BookStore.Application.Books.Services.Interfaces;
using BookStore.Domain.Books.Interfaces.Repository;
using BookStore.Domain.Books.Interfaces.Services;
using BookStore.Domain.Books.Services;
using BookStore.Domain.UoW.Interfaces;
using BookStore.Infra.Data.Books.Repository;
using BookStore.Infra.Data.Context;
using BookStore.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.CrossCutting
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            
            RegisterContext(services);
            RegisterUnitOfWork(services);
            RegisterAppService(services);
            RegisterService(services);
            RegisterReposity(services);            
        }

        public static void RegisterContext(IServiceCollection services) =>
           services.AddScoped<BookStoreContext>();

        public static void RegisterUnitOfWork(IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWork>();          

        public static void RegisterAppService(IServiceCollection services) =>        
            services.AddScoped<IBookAppService, BookAppService>();        

        public static void RegisterService(IServiceCollection services) =>
            services.AddScoped<IBookService, BookService>();        

        public static void RegisterReposity(IServiceCollection services) =>
            services.AddScoped<IBookRepository, BookRepository>();        
    }
}
