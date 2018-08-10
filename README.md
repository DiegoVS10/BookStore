# BookStore

A simple book management app.

## Getting Started

### Prerequisites

* .NET Core 2.1
* Node v8.10.0
* npm or yarn
* Angular CLI


## Running project

### Checkout this repository 

```
git clone https://github.com/DiegoVS10/BookStore.git
```

### Database setup
Run the script located at `sql/CreateDataBaseBookStore.sql` on your SQL Server.

### Setup your connection string
On file located at `src\BookStore.WebApi\appsettings.json`, change connection string with your database params.

### Backend 

On the root path, run the following commands:

```
dotnet restore && dotnet run -p src/BookStore.WebApi
```

API will run at http://localhost:55193/

### Frontend

On the root path, run the following commands:

```
cd src/BookStore.UI
npm install or yarn install 
npm start or yarn start 
```

Frontend application will run at http://localhost:4200

## Running the tests

On the root path, run the following command:

```
dotnet test tests/BookStore.Domain.Tests
```


## Built With

* [.NET Core](https://www.microsoft.com/net/learn/get-started/) - DDD, Entity Framework Core, DI, AutoMapper
* [Angular 5](https://angular.io/)
* [Bootstrap 4](https://getbootstrap.com/docs/4.1/getting-started/introduction/)
* [Visual Studio Code](https://rometools.github.io/rome/) - Lightweight but powerful source code editor which runs on your desktop and is available for Windows, macOS and Linux.

## Author

* **Diego Vieira Soares** 