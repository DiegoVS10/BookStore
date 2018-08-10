using AutoMapper;
using BookStore.Application.Books.Services.Interfaces;
using BookStore.Application.Books.ViewModels;
using BookStore.Domain.Books.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BookStore.WebApi.Controllers
{
    [Route("api/Livro")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookAppService _bookAppService;
        private readonly IMapper _mapper;

        public BookController(IBookAppService bookAppService, IMapper mapper)
        {
            _bookAppService = bookAppService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Get()
        {
            var result = _bookAppService.GetAll();
            return Ok(_mapper.Map<IEnumerable<ListBookViewModel>>(result));
        }

        [HttpGet]
        [Route("filtrar/{id}")]
        public IActionResult Get(Guid id)
        {
            var livro = _bookAppService.GetById(id);
            return Ok(_mapper.Map<ListBookViewModel>(livro));
        }

        [HttpPost]
        [Route("adicionar")]
        public IActionResult Post([FromBody]RegisterBookViewModel bookViewModel)
        {
            var book = _mapper.Map<Book>(bookViewModel);

            if (book.Invalid)
                return BadRequest(book.Notifications);

            _bookAppService.Add(book);
            return Ok(bookViewModel);
        }

        [HttpPut]
        [Route("atualizar")]
        public IActionResult Put([FromBody]EditBookViewModel bookViewModel)
        {
            var book = _mapper.Map<Book>(bookViewModel);

            if (book.Invalid)
                return BadRequest(book.Notifications);

            _bookAppService.Update(book);
            return Ok(bookViewModel);
        }

        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Delete(Guid id)
        {
            _bookAppService.Delete(id);
            return Ok();
        }
    }
}