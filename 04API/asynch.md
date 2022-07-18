# Asynchronous Programming

Asynchronous programming is a way to execute code without pausing program to wait for all its inner processes to be complete before continuing

## Keywords
- async
- await
- Task<T>

When we call async functions/methods, they, at first, return `Task<T>`. This is a way of the program saying "I received your request, I'm working on it right now, please check back later" Ex. `Task<PokeTrainer>`
We get notified when the operation has been complete, when we use the `await` keyword.
Any method that uses async has to also be async.