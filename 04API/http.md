# HTTP
HyperText Transfer Protocol

we use http to communicate between machines over the web
it is a standardized way of communicating text over the web

when two machines communicate, they take on client and server role
the client asks for resource from server, server provides it.

## HTTP Request
Client requests for resources from a server
### Start line
    - Method Verb: GET, PUT, POST, DELETE, OPTION, etc.
    - Target: Where? (URL)
### Request Body
    - Payload, especially for PUT and POST request
### Request Header
    - Information about the request itself

## HTTP Response
### Status line
    - Status Codes
### Response Header
    - information about the response
### Response Body
    - contains the resource client has asked for

## Status Codes
- 1xx: Informational ('mmkay')
- 2xx: Success (We got the request, and we successfully fulfilled it)
- 3xx: Redirection (we moved it)
- 4xx: Client side error (you did something bad)
- 5xx: Server side error (oops our fault)

- 404: Resource Not Found
    - Do not use this code to signal that there is no content to return
- 403: Forbidden
- 503: Service Unavailable
- 200
- 201
- 204
- 300