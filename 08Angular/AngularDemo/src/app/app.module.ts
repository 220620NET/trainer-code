import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PokemonViewComponent } from './pokemon-view/pokemon-view.component';

@NgModule({
  declarations: [
    AppComponent,
    PokemonViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  // exports: [
    //put stuff here that you want to make available to other modules that are importing this module
  //   PokemonViewComponent
  // ],
  bootstrap: [AppComponent]
})
export class AppModule { }
