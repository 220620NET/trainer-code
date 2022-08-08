"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
(function () {
    console.log('hello world!');
    let foo = 'bar';
    let num = 1;
    let trueOrFalse = true;
    let arr = [1, 2, 3];
    let stringArr = ['one', 'two', 'three'];
    let obj = {
        key: 'value'
    };
    //similar to var in C# or a way to write js without tsc yelling at you
    let any = 'a';
    any = 2;
    any = [1, 3];
    any = {};
    any = false;
    any = null;
    //unknown lets you assign anything in that variable but you can't assign unknown to a statically typed var
    let unknownVar;
    // unknownVar = 'string';
    unknownVar = 3;
    num = unknownVar;
    //union type
    let numOrString = 'string';
    numOrString = 3;
    let date = '8-8-22';
    date = new Date();
    date = Date.now();
    console.log(date);
    console.log(foo);
    let fc;
    let poke = {
        id: 1,
        name: 'Pikachu',
        level: 5,
        trainerId: 1,
        type: 'electric'
    };
    let pokeTwo = {
        name: 'Pikachu',
        level: 5,
        trainerId: 1,
        type: 'electric'
    };
    let pokeThree = {
        name: 'Snorlax',
        level: 5,
        trainerId: 1,
        type: 'electric',
        temperament: 'gentle',
        id: 2,
        dateCatched: Date.now()
    };
    printPokemon(pokeThree);
})(); //Immediately Invoked Function Expression : IIFE
function returnTrue() {
    return true;
}
function doesntReturn() {
    //to return nothing, such as undefined or null
}
function never() {
    throw Error();
}
function printPokemon(poke) {
    console.log(poke.name, poke.level, poke.type);
}
