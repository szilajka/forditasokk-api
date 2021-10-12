This is a REST API based on the existing [forditasokk](https://github.com/horvathzsofi/forditasokk) repo (written in PHP).

# ForditasokK API

The main goal of this API is to let you query basic informations about K-Pop artists and share your translations of songs with others.

## Used technologies

- (ASP).NET 5.0
- Docker
- PostgreSql 13

The authorization server uses [OpenIddict](https://github.com/openiddict/openiddict-core).

## Starting the App

Clone this repo:

```shell
git clone https://github.com/szilajka/forditasokk-api
```

If you haven't, install [Docker](https://docs.docker.com/get-docker/).

Start the application:

- If this is your first launch, go to the _AuthServer_'s project _Startup.cs_ file and comment out the following line (so the API won't throw an exception on startup):

```csharp
// services.AddHostedService<Worker>();
```

- If you have Visual Studio 2019 or newer installed, open the solution and set up "docker-compose" as the Startup Project.
- If you don't want to use Visual Studio, then you can start it with docker:

```shell
docker compose build
docker compose up
```

After you started the 2 applications, you should be able to create the database based on the migrations.

- Go to the projects base folder (where the _.sln_ file is located).
- Open the terminal there and type the followings:

```shell
dotnet ef database update -p ./src/Forditasokk.Data/ -s ./src/Forditasokk.Api -c ForditasokkDbContext
```

Note that this should work in Linux, but Windows uses backslashes ( \\ ) instead of slashes ( / ).

After that, stop the app and you should remove the comments from the mentioned _Startup.cs_ file (this will create an MVC client app in the database).