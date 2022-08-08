"use strict";
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
    //union type
    let numOrString = 'string';
    numOrString = 3;
    let date = '8-8-22';
    date = new Date();
    date = Date.now();
    console.log(date);
    console.log(foo);
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
