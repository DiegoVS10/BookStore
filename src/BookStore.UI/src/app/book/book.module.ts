import { NgModule, LOCALE_ID } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BookRegisterComponent } from './register/book-register.component';
import { BookListComponent } from './list/book-list.component';
import { BookService } from './book.service';
import { RouterModule } from '@angular/router';
import { CurrencyMaskModule } from "ng2-currency-mask";
import { registerLocaleData } from "@angular/common";
import ptBr from "@angular/common/locales/pt";

registerLocaleData(ptBr);

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    CurrencyMaskModule
  ],  
  declarations: [
    BookRegisterComponent,
    BookListComponent
  ],
  providers: [
    BookService,
    { provide: LOCALE_ID, useValue: "pt-BR" }
  ]
})
export class BookModule { }