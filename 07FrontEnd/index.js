//scoping, let vs bar
(function() {
    if(true) {
        let foo = 'bar'
        var bar = 'foo'
    }

    // console.log(foo); //will throw error
    console.log(bar); //works

})()

// console.log(bar); //doesn't work, var is still function scoped

// Different ways to define a function
//function declaration
function aFunction(a, b, c) {
    //do something here
    return a;
}

// anonymous function assigned to a variable
let clickHandler = function() {
    console.log('you clicked me!');
}

// a named function assigned to a variable
clickHandler = aFunction;

//arrow function
clickHandler = () => {
    console.log('arrow function handling click event')
}

//object literal
let objectExample = {
    'key': 'value',
    'anotherkey': 2,
    'arrayKey': [1, 2, 3, 'boo'],
    'objKey': {},
};

console.log(objectExample.key);
console.log(objectExample['objKey']);