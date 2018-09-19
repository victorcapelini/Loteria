import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule  } from "@angular/common/http";

import { AppComponent } from './app.component';
import { LoteriaComponent } from './loteria/loteria.component';
import { LoteriaService } from './loteria/loteria.service';

@NgModule({
  declarations: [
    AppComponent,
    LoteriaComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [LoteriaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
