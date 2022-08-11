import { Component, Input, OnInit } from '@angular/core';
import { PokeTrainer } from '../models/poketrainer';
import { AuthService } from '../services/auth-service/auth.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  constructor(private auth : AuthService) { }
  
  // @Input() currentUser : any;
  currentUser : PokeTrainer = {
    name: ''
  }
  ngOnInit(): void {
    this.currentUser = this.auth.getCurrentUser()
  }

}
