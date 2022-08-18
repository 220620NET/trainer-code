# Basic Security Concepts

## Authentication vs Authorization 
- Authentication: Verifying the identity (Are you the person/user who says you they are) ie: Login
- Authorization: Permissions (Are you allowed to do the thing you're trying to do) ie: Not letting employees in ERS to approve tickets

## CORS (Cross Origin Resource Sharing)
By default, servers are designed to only share their resources with requests from the same origin. In order to allow sharing of resources to requests from different origin, we have to Enable CORS with policies specifying which origins you would like to share resources with, which request methods you allow, which headers you accept, and more. 

## XSS (Cross Site Scripting)
When a malicious user acts a trusted user to take advantage of unsuspecting web application by injecting script tags
https://www.reddit.com/r/explainlikeimfive/comments/nxiup6/eli5_how_do_xss_attacks_work/
https://www.youtube.com/watch?v=zv0kZKC6GAM

## OWASP Top 10
Open Web Application Security Project's Top 10 list of web application security vulnerability. They refresh this list every 3-4 years and each item there has description of what the vulnerability is, example attack scenarios, and how to prevent it.
https://owasp.org/www-project-top-ten/