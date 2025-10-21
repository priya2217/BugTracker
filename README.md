# BugTracker

BugTracker is a web-based application designed to help software development teams efficiently report, track, and manage bugs throughout the software lifecycle. It allows users to log new bugs, assign them to team members, update their status, and monitor progress in real time.

📁 Project Structure

BugTracker/
├── Backend/
│   ├── BugTrackerAPI/           # .NET API project
│   │   ├── Controllers/
│   │   ├── Models/
│   │   ├── Services/
│   │   └── Program.cs
├── Frontend/
│   ├── bugtracker-angular/      # Angular frontend
│   │   ├── src/
│   │   │   ├── app/
│   │   │   ├── assets/
│   │   │   └── environments/
│   │   └── angular.json
├── Database/
│   ├── schema.sql               # PostgreSQL schema
├── README.md
└── .gitignore

🏗️ Features

User Management: Create, update, and manage user accounts.

Bug Reporting: Log new bugs with title, description, priority, and status.

Bug Tracking: Update bug status, assign to team members, and track progress.

Search & Filter: Find bugs by status, priority, or assigned user.

Notifications: Email or in-app alerts for bug updates (optional).

Role-Based Access: Admins, developers, and testers with different permissions.

🚀 Quick Start

Backend (.NET)

# Navigate to backend folder
cd Backend/BugTrackerAPI

# Restore dependencies
dotnet restore

# Run the API
dotnet run

# API will be available at http://localhost:5000

Frontend (Angular)

# Navigate to frontend folder
cd Frontend/bugtracker-angular

# Install dependencies
npm install

# Run Angular app
ng serve --open

# Frontend will be available at http://localhost:4200

Database (PostgreSQL)

-- Create database
CREATE DATABASE BugTrackerDB;

-- Run schema.sql to create tables
\i path/to/schema.sql

🧪 Testing

Backend: Use tools like Postman to test API endpoints.

Frontend: Angular unit tests

ng test

🔧 Configuration

Backend: Update appsettings.json with your PostgreSQL connection string.

Frontend: Update environment files with API URL (http://localhost:5000).


📄 License

MIT License


🤝 Contributing

1. Fork the repository


2. Create a feature branch


3. Write and test your code


4. Submit a pull request


🆘 Support

📧 Email: support@bugtracker.com

💬 Discord / Slack: [BugTracker Community]


