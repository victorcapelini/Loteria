import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

import * as $ from "../../../node_modules/jquery";

@Injectable({
  providedIn: "root"
})
export class LoteriaService {
  constructor(private http: HttpClient) {}

  getNomes() {
    return $.get("http://localhost:61230/api/Jogador").responseJSON;
  }
}
