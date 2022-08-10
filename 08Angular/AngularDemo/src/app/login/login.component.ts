import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { SessionStorageService } from 'angular-web-storage';
import { PokeTrainer } from '../models/poketrainer';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user : PokeTrainer = {
    name: ''
  }
  
  username : FormControl = new FormControl(this.user.name, [
    Validators.required
  ]);

  mode : string = 'login';
  modes : any = {
    login: 'Log In',
    register: 'Register'
  }
  loginHandler : Function = () => {
    if(this.username.invalid) {
      return;
    }
    let url : string = 'https://pokestoragedocker.azurewebsites.net/auth/';
    if(this.mode === 'login') url += 'login'
    else url += 'register'
    this.http.post(url, this.user).subscribe((res) => {
      this.session.set('currentUser', res);
    });
  }

  switchMode(mode : string) : void {
    this.mode = mode;
    this.username.setValue('');
  }

  constructor(private http: HttpClient, private session: SessionStorageService) { }

  ngOnInit(): void {
  }

}
