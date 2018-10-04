import { Injectable } from '@angular/core';
import { ApiService } from '../services/api.service';
import { Observable } from 'rxjs';
import { Book } from './models/book';
import { environment } from '../../environments/environment';

@Injectable()
export class BookService {
  
  private url = environment.apiUrl;

  constructor(private api: ApiService) { }

  public getAll(): Observable<any> {

    var urlGetAll: string = `${this.url}/listar`;
    return this.api.get(`${urlGetAll}`)
  }

  public getById(id: string): Observable<any> {

    var urlGetById: string = `${this.url}/filtrar/${id}`;
    return this.api.get(`${urlGetById}`)
  }

  public save(book: Book): Observable<any> {

     if (book.id){
      return this.put(book);
     } 
       
     return this.post(book);         
  }

  private post(book: Book): Observable<any> {    

    var urlPost: string = `${this.url}/adicionar`;
    return this.api.post(urlPost, book);
  }

  private put(book: Book): Observable<any> {    

    var urlPut: string = `${this.url}/atualizar`;
    return this.api.put(urlPut, book);
  }

  public delete(id: string): Observable<any> {    

    var urlDelete: string = `${this.url}/deletar/${id}`;
    return this.api.delete(urlDelete);
  }
}