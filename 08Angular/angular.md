# Angular

## Setting up Angular
- **install angular globally: `npm install --location=global @angular/cli`**
    - if you get EACCESS error, run the following command with `sudo`
- or locally: `npm install @angular/cli`
- To update NPM to the latest: `npm install --location=global npm@latest`

- If you installed angular locally, prefix all of your ng commands with npx
    - if the command is `ng new <...>`, type `npx ng new <...>`

- **To create a new angular application, run `ng new`**
- To serve the angular application:
    - first navigate to the folder containing angular application
    - then **run `ng serve`**
    - navigate to localhost:4200 to see your angular app running

## What is Angular?
Angular is a modern frontend framework that allows you to create Single Page Applications.

## Single Page Application
- It's a type of web application, where instead of being composed of multiple html pages that render based off of urls, the content in a SINGLE PAGE is swapped to display different views.
- In Web 1.0, each GET request to a url was responded with an HTML document.
However, as the frontend matured and we started expecting more out of html/css/js, we began to think about way to render html pages dynamically without having to refresh. Single Page Application _Loads_ all its assets (aka html/css/js files + anything else it needs to function minus the data) in the first GET request, and afterward there is no page refresh. The URL changes you see is simulated. When users navigate to different pages, different parts of the html document is dynamically swapped out.

Tools such as Angular, React, Vue helps developers create Single Page Applications.

### Advantages of SPA
- Modularity (promoting code reusability, scoping, and providing single source of truth)
- faster load times after the initial load

### Disadvantages of SPA
- initial load takes longer than server side rendering
- learning curve with tools

### Framework vs Library 
Framework are more opinionated on how it wants to function, where as libraries are collections of tools. Frameworks are heavier, and provides all-in-one support (ex. Angular, ASP.NET). Libraries are lighter in size and provides you with a certain set of functionality (ex. React, Serilog)

## Moving parts of Angular
### Component
Component is a reusable view, which is a bundle of html/css/ts/testing file. Components handle presentation logic.
When you generate component using `ng generate component <component-name>` or `ng g c <component-name>` it comes with html, css, ts, and ts testing file.

### Decorator
Decorator is a special syntax that lets angular know that it is angular's element. usually they start with `@` symbol, followed by the name, such as `@Component`, `@Directive`, `@NgModule`, `@Injectable`, `@Pipe` and more. After that syntax comes configuration object that we can use to define different properties associated to the element 

### Modules
Angular module is very similar to namespaces in C#. Like how we bundle or register different types to a namespace, we register different angular elements to a module. Each components have to be declared in a *single(one and only one)* module. In order for other modules to have access to components declared in different modules, you need to export that component in your module, and then you need to import that particular module in module.ts file.
Modules are decorated with `@ngModule` decorator that contains information regarding its members (components in declarations property), its dependencies (imports property) and what it exports, and so on and so forth.
