import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class LoteriaService {

  constructor(private http: HttpClient) { }

  getNomes() {
    return this.http.get<string>("http://localhost:61230/api/Jogador/0");
  }
}
