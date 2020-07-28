# .Net Core 3.1 MVC REST API

## PART 1 - FIRST 2 API ENDPOINTS (GET / READ)
- [v0.0.1][v0.0.1] :  ~~Project Setup~~ 
- [v0.0.2][v0.0.2] :  ~~Create our Domain Model (Command)~~
- [v0.0.3][v0.0.3] :  ~~Build Our Repository Interface~~
- [v0.0.4][v0.0.4] :  ~~Implement our Repository Interface (Mock Reposiory)~~
- [v0.0.5][v0.0.5] :  ~~Create our Controller (CommandsController)~~
- Create 2x API Endpoints
- Using Dependency Injection

## PART 2 - ENTITY FRAMEWORK & SQL SERVER
- Architecture Checkpoint
- Set Up SQL Server App Login
- Entityframework Packages
- Entityframework Toolset
- Create our Database Context (CommanderContext)
- Our Database Connecttion String
- Register our DB Context in Startup
- Create Migrations
- Cancel Migrations & revist Command Model
- Add Data Validations to Command Model
- Create Migrations (Again!)
- Run Migrations against Database
- Add Data to Database
- Revist Our Repository to use DB Context

## PART 3 - DATA TRANSFER OBJECTS & CREATE ENDPOINT
- Architecture Checkpoint
- Why Data Transfer Objects?
- AutoMapper Package & Startup Registration
- Create our first DTO
- Creating a mapping Profile
- Updating Our Action Results to use DTOs

## PART 4 - PUT, PATCH & DELETE API ENDPOINTS
- Architecture Checkpoint
- Updating our Repository for Creating Resources
- Create a New DTO (for Creating)
- Create 3rd API Endpoint to Create Resources
- Use CreatedAtRoute to return 201 CreatedAtRoute
- Add Annotations to DTO to avoid 500 Errors
- Update Repository to Support Updates
- Add a New DTO (for Updating)
- Add 4th API Endpoint for Updating (PUT Request)
- Update our AutoMapper Profile
- Overview of PATCH
- Install 2x packages to support PATCH
- Update Startup
- Update our AutoMapper Profile (Final Update)
- Add 5th API Endpoint for Updating (PATCH Request)
- Add 6th API Endpoint for Deleting (DELETE Request)


## Build & Run
 - run the following commands

```shell
dotnet run
```

## Endpoint to Test
 - `/api/commands/`
 - `/api/commands/{id}`


## Reference
 - [Les Jackson][les-jackson-youtube] 
 - [Tutorial][tutorial]


[les-jackson-youtube]: https://www.youtube.com/channel/UCIMRGVXufHT69s1uaHHYJIA
[tutorial]: https://www.youtube.com/watch?v=fmvcAzHpsk8

[v0.0.1]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.0.1
[v0.0.2]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.0.2
[v0.0.3]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.0.3
[v0.0.4]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.0.4
[v0.0.5]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.0.5