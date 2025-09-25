# Package Express Shipping Calculator

A simple console application that calculates shipping quotes for packages based on weight and dimensions.

## Features

- Validates package weight (must be ≤ 50 units)
- Validates package dimensions (sum of width, height, length must be ≤ 50 units)
- Calculates shipping cost based on volume and weight
- User-friendly console interface with clear instructions

## How to Run

### Prerequisites
- .NET 8.0 SDK or later

### Running the Application

1. **Clone or download the project files**
2. **Open command prompt/terminal in the project directory**
3. **Run the following commands:**

```bash
# Restore dependencies (optional - dotnet run will do this automatically)
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run