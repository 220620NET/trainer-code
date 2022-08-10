import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AngularWebStorageModule } from 'angular-web-storage';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PokemonViewComponent } from './pokemon-view/pokemon-view.component';
import { LoginComponent } from './login/login.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    PokemonViewComponent,
    LoginComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    AngularWebStorageModule
  ],
  providers: [],
  // exports: [
    //put stuff here that you want to make available to other modules that are importing this module
  //   PokemonViewComponent
  // ],
  bootstrap: [AppComponent]
})
export class AppModule { }
