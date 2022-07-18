# RESTful API
REST: stands for REpresentational State Transfer
API: Application Programming Interface
    - An interface for machines/programs/applications

REST is a design guideline to build an API that is easy to understand and use

## SOA: Service Oriented Architecture
it's a more modularized way of designing your application- instead of your server solely existing for your UI app, we design the server to exist as a service that your UI can use, but also other machines can use. We build API's to share the data

## REST Guiding Principles
- Client-Server
    - it's a one way relationship
- Stateless
    - the server should not be storing client's state
- Cacheable
    - Certain high demand server resources can be cached for quicker access
- Uniform Interface
    - Your API should have some kind of standardized way of accessing your resource
- Layered System
    - Each layer in your server should only know the layer beyond
- Code on Demand (Optional)
    - Your server can also serve code snippets instead of text
- HATEOAS (Hypermedia As The Engine Of Application State) (optional)
    - a curated menu
    - This is an optional feature of RESTful API where the server guides the user on what they can do based on the last request
    - In the server response, the server includes information about other endpoints the client can use based off of their current state