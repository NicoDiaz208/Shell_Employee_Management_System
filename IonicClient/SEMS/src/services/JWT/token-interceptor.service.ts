import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TokenInterceptorService implements HttpInterceptor {

  constructor() { }
  intercept(req: HttpRequest<any>,
    next: HttpHandler): Observable<HttpEvent<any>> {
    const token = window.localStorage.getItem("Token");
    if(token){

      const cloned = req.clone({
        headers: req.headers.set("Authorization","Bearer " + token)
      });

      return next.handle(cloned);
    }
    else{
      return next.handle(req);
    }
  }
}