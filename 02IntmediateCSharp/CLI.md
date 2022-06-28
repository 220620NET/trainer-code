## Common Language Infrastructure
- This is a set of specification initially developed by Microsoft for .NET compliant languages to subscribe to. And this is what allows many different .NET compliant languages to work with each other

## Common Type System
- A type specifications that all .NET compliant/CLI languages must implement.
EX:
    Int32 a = 3;
    int a = 3;
    Int32.Parse() int.Parse()

    Int64 > long
    Int16 > short

## Common Language Runtime
- Is a runtime for all CLI languages, it translates the Intermediary Language to Native Code on execution using Just-In-Time compiler (JIT Compiler). It also provides services such as automatic memory management (garbage collection), exception handling, type safety.

![CLRProcess](https://i.ytimg.com/vi/gCHoBJf4htg/maxresdefault.jpg)