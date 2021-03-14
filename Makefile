AddMigration:
	dotnet ef migrations add $(name) --project StarWarsMovies.Db --startup-project StarWarsMovies.Mvc
RemoveMigration:
	dotnet ef migrations remove --project StarWarsMovies.Db --startup-project StarWarsMovies.Mvc
UpdateDatabase:
	dotnet ef database update --project StarWarsMovies.Db --startup-project StarWarsMovies.Mvc
RevertMigration:
	dotnet ef migrations revert $(name) --project StarWarsMovies.Db --startup-project StarWarsMovies.Mvc
.PHONY: AddMigration, RemoveMigration, UpdateDatabase, RevertMigration
