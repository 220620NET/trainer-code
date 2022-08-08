import pokemon from './interface';

(function() {
    console.log('hello world!')
    let foo : string = 'bar';
    let num : number = 1;
    let trueOrFalse : boolean = true;
    let arr : number[] = [1, 2, 3];
    let stringArr : string[] = ['one', 'two', 'three']
    let obj : {} = {
        key : 'value'
    };
    //similar to var in C# or a way to write js without tsc yelling at you
    let any : any = 'a';
    any = 2;
    any = [1, 3]
    any = {}
    any = false;
    any = null;

    //unknown lets you assign anything in that variable but you can't assign unknown to a statically typed var
    let unknownVar : unknown;
    // unknownVar = 'string';
    unknownVar = 3 as number;

    num = unknownVar as number;
    //union type
    let numOrString : number | string = 'string';
    numOrString = 3;

    let date : Date | string | number = '8-8-22';
    date = new Date();
    date = Date.now();

    console.log(date)

    console.log(foo);

    let fc : Function;

    let poke : pokemon = {
        id: 1,
        name: 'Pikachu',
        level: 5,
        trainerId: 1,
        type: 'electric'
    };

    let pokeTwo : pokemon = {
        name: 'Pikachu',
        level: 5,
        trainerId: 1,
        type: 'electric'
    }

    //structural typing or duck typing
    let pokeThree : any = {
        name: 'Snorlax',
        level: 5,
        trainerId: 1,
        type: 'normal',
        temperament : 'gentle',
        id : 2,
        dateCatched: Date.now()
    }

    printPokemon(pokeThree);
})(); //Immediately Invoked Function Expression : IIFE

function returnTrue() : boolean {
    return true;
}

function doesntReturn() : void {
    //to return nothing, such as undefined or null
}

function never() : never {
    throw Error();
}

function printPokemon(poke: pokemon) : void {
    console.log(poke.name, poke.level, poke.type);
}