import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { SessionStorageService } from 'angular-web-storage';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username : FormControl = new FormControl('');
  mode : string = 'login';
  modes : any = {
    'login': 'Log In',
    'register': 'Register'
  }
  loginHandler : Function = () => {
    let url = 'https://pokestoragedocker.azurewebsites.net/auth/';
    if(this.mode === 'login') url += 'login'
    else url += 'register'
    this.http.post(url, {
      'name': this.username.value
    }).subscribe((res) => {
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
