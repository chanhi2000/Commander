# .Net Core 3.1 MVC REST API

## PART 1 - FIRST 2 API ENDPOINTS (GET / READ)
- [v0.0.1][v0.0.1] :  ~~Project Setup~~ 
- [v0.0.2][v0.0.2] :  ~~Create our Domain Model (Command)~~
- [v0.0.3][v0.0.3] :  ~~Build Our Repository Interface~~
- [v0.0.4][v0.0.4] :  ~~Implement our Repository Interface (Mock Reposiory)~~
- [v0.0.5][v0.0.5] :  ~~Create our Controller (CommandsController)~~
- [v0.0.6][v0.0.6] :  ~~Create 2x API Endpoints~~
- [v0.0.6][v0.0.6] :  ~~Using Dependency Injection~~

## PART 2 - ENTITY FRAMEWORK & SQL SERVER
- ~~Architecture Checkpoint~~
- ~~Set Up SQL Server App Login~~
- [v0.1.0][v0.1.0] :  ~~Entityframework Packages~~
- ~~Entityframework Toolset~~
- [v0.1.1][v0.1.1] :  ~~Create our Database Context (CommanderContext)~~
- [v0.1.2][v0.1.2] :  ~~Our Database Connecttion String~~
- [v0.1.3][v0.1.3] :  ~~Register our DB Context in Startup~~
- ~~Create Migrations~~
- ~~Cancel Migrations & revist Command Model~~
- [v0.1.4][v0.1.4] :  ~~Add Data Validations to Command Model~~
- ~~Create Migrations (Again!)~~
- ~~Run Migrations against Database~~
- ~~Add Data to Database~~
- [v0.1.5][v0.1.5] :  ~~Revist Our Repository to use DB Context~~

## PART 3 - DATA TRANSFER OBJECTS & CREATE ENDPOINT
- ~~Architecture Checkpoint~~
- ~~Why Data Transfer Objects?~~
- [v0.2.0][v0.2.0]  : ~~AutoMapper Package & Startup Registration~~
- [v0.2.1][v0.2.1] : ~~Create our first DTO~~
- [v0.2.2][v0.2.2] : ~~Creating a mapping Profile~~
- [v0.2.3][v0.2.3] : ~~Updating Our Action Results to use DTOs~~

## PART 4 - PUT, PATCH & DELETE API ENDPOINTS
- ~~Architecture Checkpoint~~
- [v0.3.0][v0.3.0] :   ~~Updating our Repository for Creating Resources~~
- [v0.3.1][v0.3.1] :  ~~Create a New DTO (for Creating)~~
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

##  Entityframework Toolset : `dotnet-ef`
 - to install

 ```shell
 dotnet tool install --global dotnet-ef
 ```
  
  - to create migrations

 ```shell
 dotnet ef migrations add InitialMigration
 ```

  -  to undo migrations

```shell
dotnet ef migrations remove
```

  - to run update on database

```shell
dotnet ef database update
```

## Note
- Run following query for Enable Insert Then Disable

```sql
set IDENTITY_INSERT Commands ON;
...
/*ADD DATA HERE*/
...
set IDENTITY_INSERT Commands OFF;
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
[v0.0.6]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.0.6
[v0.1.0]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.1.0
[v0.1.1]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.1.1
[v0.1.2]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.1.2
[v0.1.3]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.1.3
[v0.1.4]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.1.4
[v0.1.5]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.1.5
[v0.2.0]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.2.0
[v0.2.1]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.2.1
[v0.2.2]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.2.2
[v0.2.3]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.2.3
[v0.3.0]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.3.0
[v0.3.1]: http://ginno.synology.me:3000/EDUCATION/Commander/src/v0.3.1