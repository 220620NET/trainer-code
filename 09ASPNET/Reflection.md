# C# Reflection

Reflection is the ability for the object to get information about itself. Through reflection, it can get the type, properties, attributes, methods of the object.

Obj.GetType() methods gets you the Type of an object
typeof(Type) gets you the Type of the Type. (The CTS version)

We use reflection to get the program to act flexibly and dynamically upon usage, but it comes with the possibility of more run time exceptions/errors and performance cost. (also less readable)