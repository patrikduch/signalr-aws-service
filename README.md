# SignalR AWS Service

## Dockerization

### Build image

docker build -f Dockerfile -t signalr-dockerization .

### Run image

docker run -p 80:80 signalr-dockerization 


## EFCore

### Migrations

Go to the Package Manager Console and install the needed tools with "Install-Package Microsoft.EntityFrameworkCore.Tools". 
When it has completed try to use the command EntityFrameworkCore\Add-Migration firstMigration.

#### Creation of a new migration
add-migration Initial

#### Update database with newly created migration
Update-Database -Project SignalR-Aws-Service
