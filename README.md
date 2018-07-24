"# BrokenAccessControl" 
This is an ASP.NET Web Forms 4.7 vulnerable solution showcasing the OWASP Top 10 A5:2017 - Broken Access Control
Notice this is an example of what NOT to do:

The application lacks logging and auditing, exposes a technology stack trace to the browser when the security exception bubbles up, and allows an anonymous user to execute an action on the UI that is meant for an authenticated user.

For more information about the OWASP Top 10 A5:2017 go to 
https://www.owasp.org/images/7/72/OWASP_Top_10-2017_%28en%29.pdf.pdf

This web application allows navigation to authenticated sections of the website as an unauthenticated
user while the section of the website requires the principal to be authenticated.

