# MovieApp

MovieApp is a web application that allows users to explore movies, view cast details, and leave reviews. The project also includes an admin panel for managing the movie database.

## Features

- **Movie Management**: Add, edit, and delete movies.
- **Cast Management**: Manage actor information.
- **Reviews**: View and manage user reviews.
- **User Authentication**: Register and login functionality.
- **CRUD Operations**: Full CRUD (Create, Read, Update, Delete) support for movies, actors, and reviews.

## Technologies

- **Backend**: .NET Core
  - **Architecture**: Onion Architecture
  - **Database**: SQL Server
  - **CQRS and MediatR Design Pattern**: Used for separating commands and queries.
- **Frontend**:
  - **User Interface**: React
  - **Admin Panel**: Built with .NET

## Setup Instructions

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/korayyalcin1903/MovieApp.git
   cd MovieApp
   ```

2. **Set Up the Database**: Install SQL Server and create the required database.

3. **Run the Backend**:
   - Open `MovieApp.sln` in Visual Studio.
   - Configure the database connection string in `appsettings.json`.
   - Build and run the solution.

4. **Run the Frontend**:
   - Navigate to `MovieApp.UI/movie-app`.
   - Install dependencies:
     ```bash
     npm install
     ```
   - Start the application:
     ```bash
     npm run start
     ```

## Contributing

We welcome contributions! Please open an issue first to discuss any major changes or additions you plan to make.

---

For more details, visit the GitHub repository: [https://github.com/korayyalcin1903/MovieApp](https://github.com/korayyalcin1903/MovieApp)


![movieapp (Orta)](https://github.com/user-attachments/assets/c974d353-9d3d-4279-adae-a34cef09dc6b)
