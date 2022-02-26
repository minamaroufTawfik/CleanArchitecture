# Infrastructure Layer

Infrastructure Layer supports other layer by implementing the abstractions and integrations to 3rd-party library and systems.

In a DDD implementation, you may have a single Infrastructure project to implement all the abstractions and integrations,
or you may have different projects for each dependency.
Better to use a balanced approach; Create separate projects for main infrastructure dependencies (like Entity Framework Core)
and a common infrastructure project for other infrastructure.

As We did in this template we have 2 projects 
* EventsStar.EntityFrameworkCore And Some time you can name it "Persistance"
* EventsStart.Infrastructure Which will implement all other 3rd parties like Email Service, SMS Service, Hangfire, ...
