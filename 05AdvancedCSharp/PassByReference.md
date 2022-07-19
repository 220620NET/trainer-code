# Pass By Reference
When we work with reference types, we just copy the memory address over when we assign them to new variables, or when we even pass them in the method parameter. 
Normally, when we pass method parameters in, we follow the types, so value types get passed by value, ref types get passed by reference. However, there might be scenarios that we want to pass value types by reference.

- Ref
    - This is your generic pass by reference keyword. You use this in your method signature in front of the parameter you want to pass by reference, and you also have to use this keyword when you're using it.

- Out
    - This keyword is particularly useful when you want to return more than 1 values
    -Super useful Ex: int.TryParse

- In
    - This has to be initialized before being passed in as reference