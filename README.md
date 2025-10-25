#Asp.net web api 
created via `dotnet new webapi` and scaffoling current accounting app database using ef core with two database Master: AlmasMain Context and details for each year AlmasACC14031Context.cs
using with controller you can simply plug in the model to the new endpoint to use for https://github.com/Mirzaei81/VistorApp

## 📂 Project Structure
```
📁 MyAspNetApp/
│
├── 📁 Controllers/
│ ├── Interfaces/
│ │ └── IAuthController.cs
| | └── ICityController.cs
│ ├── AuthController.cs
│ ├── CityController.cs
│
├── 📁 Models/
│ ├── User.cs
│ ├── ....cs
|
├── 📁 Repositories/
│ ├── Interfaces/
│ │ └── IGenericRepository.cs
│ └── Implementations/
│ └── GenericRepository.cs
│
├── 📁 Context/
│ ├── AlmasMainContext.cs
│ └── AlmasACC14031Context.cs
├── appsettings.json
├── Program.cs
├── MyAspNetApp.csproj
└── README.md
```
