import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

constructor() { }

setToken(token: string): void {
  localStorage.setItem(TOKEN, token);
}

isLogged() {
  return localStorage.getItem(TOKEN) != null;
}

}
