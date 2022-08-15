# ASP.NET Core (continued)
ASP.NET Core is a Web Application Framework available for .NET Core. It supports building various styles of web applications, such as web forms, web apps with server side rendering, pure API, and API with SPA app built in. Access the scaffolding and templates via Visual Studio or `dotnet new`

## Middleware
- There are many things (such as request parsing, routing, authorization/authentication, etc.) that needs to be done for Every request that comes to the application even before it reaches our application logic. To handle those repetitive tasks, ASP.NET Core offers a _middleware pipeline_. This is a pipeline of middleware in assembly line style, where the request is processed by a line up of middleware where one middleware will do stuff to the request then call the next, then that one will do their own stuff and call the next... so on and so forth until it reaches the controller. This pipeline is configured in program.cs and is executed before it reaches the controller

## Controllers
ASP.NET Core controllers inherit from the class ControllerBase that offers many functionalities that can help developers handle http requests. 
- Controller based routing: Controller wide routing is set on top of the controller definition as an attribute, the sub-routing is then defined on top of each action with the method
- Action: Public methods in controllers that handles http requests
- ActionResult<>: the type that ControllerBase's methods returns (ie. Ok(), Conflict(), Created(), etc.)
- *Be mindful of how you're naming these controllers, the framework expects the controllers to be named `<ControllerName>Controller.cs`* 

## Model Binding
Classes that inherit the ControllerBase class also offers model validating through DataAnnotations namespace. With DataAnnotaions, we can simply annotate on top of our model properties to require a certain set of validations via attributes, when the controller class, upon data binding, will automatically check for those validators and return 400 Bad Request Response if it fails any of the validations.

