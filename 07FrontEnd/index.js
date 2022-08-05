// //scoping, let vs var
// (function() {
//     if(true) {
//         let foo = 'bar'
//         var bar = 'foo'
//     }

//     // console.log(foo); //will throw error
//     console.log(bar); //works

// })()

// // console.log(bar); //doesn't work, var is still function scoped

// // Different ways to define a function
// //function declaration
// function aFunction(a, b, c) {
//     //do something here
//     return a;
// }

// // anonymous function assigned to a variable
// let clickHandler = function() {
//     console.log('you clicked me!');
// }

// // a named function assigned to a variable
// clickHandler = aFunction;

// //arrow function
// clickHandler = () => {
//     console.log('arrow function handling click event')
// }

// //object literal
// let objectExample = {
//     'key': 'value',
//     'anotherkey': 2,
//     'arrayKey': [1, 2, 3, 'boo'],
//     'objKey': {},
// };

// console.log(objectExample.key);
// console.log(objectExample['objKey']);


//hoisting

//function declaration, the whole function defn gets hoisted (aka registered in the lexical environment, which is a phonebook/dictionary of variable/function names the browser engine keeps during run time)
console.log(foo()) //works

function foo() {
    return 'with function declarations, both the name of the function and the definition/implementation gets hoisted';
}

console.log(foo()) //also works

console.log(foo2); //undefined
//with variable declaration, the variable itself gets "registered" but not the actual value, until it reaches the initialization step
var foo2 = function() {return 'with var keyword, the content of the variable is undefined until initialization line';}

console.log(foo2()) //works

//with let and const, the runtime knows about the names, but it won't let you use it. (it'll throw an error saying that you cannot use a variable before initialization)
// console.log(foo3) //reference error
let foo3 = 'let doesnt let you do this kind of sketchy stuff'
console.log(foo3) //works