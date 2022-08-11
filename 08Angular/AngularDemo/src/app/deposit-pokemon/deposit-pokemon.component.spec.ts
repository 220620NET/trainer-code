import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepositPokemonComponent } from './deposit-pokemon.component';

describe('DepositPokemonComponent', () => {
  let component: DepositPokemonComponent;
  let fixture: ComponentFixture<DepositPokemonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DepositPokemonComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepositPokemonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
