# Lexicon Management Service (LMS)

Lexicon Management Service (LMS) is a basic school management service application with authentication. It is built using ASP.NET Core Web API, Blazor, and ASP.NET Core Identity. This project is part of a .NET bootcamp designed for individuals with prior programming knowledge.

## Features
- User Authentication and Authorization: Secure login and registration using ASP.NET Core Identity.
- School Management: Manage courses, modules, enrollments, and other school-related entities.
- Web Interface: User-friendly interface built with Blazor.
Technologies Used
- ASP.NET Core Web API: For building the RESTful API.
- Blazor: For creating interactive web UIs.
- ASP.NET Core Identity: For managing user authentication and authorization.


## Setup and Installation

### Clone the repository:

```bash
git clone https://github.com/rezapps/lms.git

cd lms
```

Navigate to the LMS.Api directory:

```bash
cd LMS.Api

# this project uses sqlite as database so no need to update database

dotnet build
dotnet watch
```

### Usage
