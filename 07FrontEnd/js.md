# Javascript

Javascript to Java is Hamster is to Ham

Javascript is a loosely typed functional* programming language. They are interpreted by browser engine at run time (Nowadays, they do JIT compiling). This is the language of choice for browsers. Server side JS is Node.js
The js standard is known as ECMAScript (current: ECMAScript2021)

## Javascript Types
- String
- Undefined
- Number
- Boolean
- Object
- Null
- Symbol

- 'SUNBONS'

## Comparison
- == : type coerces
- === : strict comparison

## Different keywords to declare variables
- var : the old school way (please do not use this)
Introduced in ES6:
- let : for storing any value that may change in the future
- const : for storing values that you don't plan on changing
- advantage of let over var is that let is block scoped

## Truthy and Falsey values
- Falsey values: FUN0NE (False, Undefined, Null, 0, NaN, EmptyString)
- 0 is falsey, anything not 0 is truthy
- "" is falsey, any non-empty string is truthy
- undefined, null are both falsey
- NaN (in fact a number type) is falsey

## DOM (Document Object Model)
Is how CSS and JS interacts with HTML elements. It is a tree-like structure that provides interface for css and js to perform CRUD operations on elements.

## Events
JS primarily interacts with HTML/DOM through events. Browsers keeps track of many different types of events and users can attach their event handlers (js function made to respond to a certain event) to these events

### Event Propagation
Once the event reaches the target element, it "bubbles" up to the window. As it bubbles up, it can trigger all of its parents related event handler. When this behavior is not desired, we call event.stopPropagation() method.

## Making HTTP Calls
- XML Http Request
- Fetch API

## JS Object vs JSON
JSON is a notation to transport data derived from JS objects.
JSON is more strict in formatting than js objects:
- the keys must be string and use double quotes
- there cannot be trailing comma (the comma at the end of the last property)
- and more...

## Storage
- cookie
- Web Storage API
    - Local Storage
        - this persists through sessions
    - Session Storage
        - gets wiped when the user closes the tab