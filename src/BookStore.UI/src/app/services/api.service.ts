import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
 

@Injectable()
export class ApiService {

  constructor(private http: Http) {
  }

  private showError(error: any){
    var errors = error.json();

    if(!Array.isArray(errors))
      return;

    var err = errors.map(x => x.message).join("\n");
    alert(err);
  }

  post(url: string, data: any): Observable<any> {
    return this.http.post(url, data)
      .catch(error => {
        this.showError(error);
        return Observable.throw(error);
      });
  }

  put(url: string, data: any): Observable<any> {
    return this.http.put(url, data)
      .catch(error => {

        this.showError(error);        
        return Observable.throw(error);
      });
  }

  delete(url: string): Observable<any> {
    return this.http.delete(url)
      .catch(error => {

        this.showError(error);
        return Observable.throw(error);
      });
  }
  get(url: string): Observable<any> {
    return this.http.get(url)
      .catch(error => {
     
        this.showError(error);         
        return Observable.throw(error);
      });
  }
}
