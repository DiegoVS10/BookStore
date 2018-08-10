import { Component, OnInit } from '@angular/core';
import { BookService } from '../book.service';
import { Book } from '../models/book';
import { Router } from '@angular/router';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  books: Book[];
  constructor(private bookService: BookService, 
              private router: Router) { }

  ngOnInit() {
    this.getAll();
  }

  public getAll(){

    this.bookService.getAll()
      .subscribe(res => {
        this.books = res.json();
      })
  }

  public edit(id: string) {

    this.router.navigate([`/livro-editar/${id}`]);
  }

  public delete(id: string) {

    if (confirm("Deseja realmente deletar?")) {
      this.bookService.delete(id)
        .subscribe(res => {
          alert("Livro removido com sucesso.");
          this.getAll();
        })
    }
     
  }
}
