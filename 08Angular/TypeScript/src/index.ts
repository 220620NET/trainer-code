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

    //union type
    let numOrString : number | string = 'string';
    numOrString = 3;

    let date : Date | string | number = '8-8-22';
    date = new Date();
    date = Date.now();

    console.log(date)

    console.log(foo);
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
