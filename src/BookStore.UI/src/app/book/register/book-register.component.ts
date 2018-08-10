import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Book } from '../models/book';
import { BookService } from '../book.service';
import { Validators, FormGroup, FormControl } from '@angular/forms'


@Component({
  selector: 'app-book-register',
  templateUrl: './book-register.component.html',
  styleUrls: ['./book-register.component.css'],
  providers: [Book]
})
export class BookRegisterComponent implements OnInit {

  pageTitle: string = "Cadastrar livro";
  public form: FormGroup;

  constructor(private book: Book,
    private bookService: BookService,
    private route: ActivatedRoute,
    private router: Router) {
  }

  ngOnInit() {

    this.form = new FormGroup({
      title: new FormControl(this.book.title, [
        Validators.required
      ]),
      author: new FormControl(this.book.author, [
        Validators.required
      ]),
      edition: new FormControl(this.book.edition, [
        Validators.required
      ]),
      publisher: new FormControl(this.book.publisher, [
        Validators.required
      ]),
      isbn: new FormControl(this.book.isbn, [
        Validators.required
      ]),
      quantity: new FormControl(this.book.quantity, [
        Validators.required         
      ]),
      price: new FormControl(this.book.price, [
        Validators.required        
      ]),


      language: new FormControl()
    });


    this.route.params.subscribe((params: any) => {

      let id = params["id"];
      if (!id) return;

      this.pageTitle = "Editar livro";

      this.bookService.getById(id)
        .subscribe(res => {
          this.book = res.json();

          if (!this.book) {
            this.BookNotFound();
          }

        }, error => {
          this.BookNotFound();
        });
    });
  }

  public onSubmit() {

    this.bookService.save(this.book)
      .subscribe(res => {
        alert("Livro salvo com sucesso.");
        this.router.navigate([`/livros`]);
      })
  }

  private BookNotFound() {
    alert("Livro não foi encontrado.");
    this.router.navigate([`/livros`]);
  }
}
