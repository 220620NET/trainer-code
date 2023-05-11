import { Component, OnDestroy, OnInit, Inject } from '@angular/core';
import { AuthService } from '../services/auth-service/auth.service';
import { PokeApiService } from '../services/poke-api-service/poke-api.service';
import { PokeTrainer } from '../models/poketrainer';
import { Pokemon } from '../models/pokemon';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-pokemon-view',
  templateUrl: './pokemon-view.component.html',
  styleUrls: ['./pokemon-view.component.css']
})
export class PokemonViewComponent implements OnInit, OnDestroy {

  constructor(private auth: AuthService, private api:PokeApiService, public dialog: MatDialog) { }

  currentUser : PokeTrainer = {
    name : ''
  };

  pokemons : Pokemon[] = [{name: '', level: 0, trainerId: 0}]

  withdraw(pokeId : number | undefined) {
    if(pokeId) {
      let dialog : MatDialogRef<WithdrawDialogue> = this.dialog.open(WithdrawDialogue, {
        width: '250px'
      })
      dialog.afterClosed().subscribe((result) => {
        if(result){
          this.api.withdrawPokemon(pokeId).subscribe((res) => {
            const dialogref = this.dialog.open(WithdrawnPokemon, {
              data: res
            });
            dialogref.afterClosed().subscribe(closedResult => {
              this.updatePokemon();
            })
          })
        }
      })
    }
  }

  updatePokemon() : void {
    if(this.auth.isAuthenticated()) {
      this.api.getPokemonByTrainerId(this.auth.getCurrentUser().id as number).subscribe((res) => {
        this.pokemons = res;
      })
    }
  }

  ngOnInit(): void {
    //get data, do some other initial set up behavior
    //get pokemon data according to the current user
    this.currentUser = this.auth.getCurrentUser();
    this.updatePokemon();
  }

  ngOnDestroy() : void {
    //clean up code here
  }

}

@Component({
  selector: 'withdraw-dialogue',
  templateUrl: 'withdrawdialogue.component.html',
})
export class WithdrawDialogue {
  constructor(public dialogRef: MatDialogRef<WithdrawDialogue>) {}

  onClick(answer : string): void {
    this.dialogRef.close(answer === 'yes' ? true : false);
  }
}

@Component({
  selector: 'withdrawn-pokemon',
  templateUrl: 'withdrawn-pokemon.component.html'
})
export class WithdrawnPokemon {
  constructor(public dialogRef: MatDialogRef<WithdrawnPokemon>, @Inject(MAT_DIALOG_DATA) public data: Pokemon) {}

  onClick(): void {
    this.dialogRef.close();
  }
}