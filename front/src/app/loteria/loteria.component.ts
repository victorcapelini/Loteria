import { Component, OnInit } from "@angular/core";

import { LoteriaService } from "./loteria.service";

@Component({
  selector: "app-loteria",
  templateUrl: "./loteria.component.html",
  styleUrls: ["./loteria.component.css"]
})
export class LoteriaComponent implements OnInit {
  jogadores: string;

  constructor(private loteriaService: LoteriaService) {
    this.jogadores = JSON.stringify(this.loteriaService.getNomes());
  }

  ngOnInit() {}
}
