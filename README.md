# Traffic Fines Management System

This repository contains an implementation of a **Traffic Fines Management System**, originally a university assignment, now being rewritten in **C#** as a **Windows Application** with **SQL Server** as the database backend.

## Project Overview

The system records traffic violations, maintains information about vehicles, their owners, and associated fines. The fines are fixed based on the type of violation, and vehicle insurance details are also tracked.

### Database Structure

The system consists of three main tables:

1. **CARS** – Stores vehicle details, owner information, and insurance value.
2. **TYPES_OF_VIOLATIONS** – Stores predefined violation types and their corresponding fine amounts.
3. **FACTS_OF_VIOLATIONS** – Records traffic violations, linking cars and violations together.

### Database Schema

The database schema is defined in **MSSQL**, and the SQL script to create the necessary tables is included in this repository.

## Technologies Used

- **C#** (.NET Framework, Windows Forms/WPF)
- **SQL Server**


## Future Enhancements

- Improve UI with modern design components.
- Add reporting and data visualization features.
- Implement role-based access control for different user types.

## License

This project is for educational purposes and does not have a specific license.

---
Feel free to contribute or modify the project to fit your needs!

