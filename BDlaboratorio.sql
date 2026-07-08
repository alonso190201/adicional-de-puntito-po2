CREATE DATABASE LaboratorioDB;
GO

USE LaboratorioDB;
GO


CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Equipos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Codigo NVARCHAR(50) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    Disponible BIT NOT NULL DEFAULT 1
);
GO


CREATE TABLE Estudiantes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Codigo NVARCHAR(50) NOT NULL,
    DNI NVARCHAR(20) NOT NULL,
    Nombres NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    EscuelaProfesional NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20)
);
GO

CREATE TABLE Prestamos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NumeroPrestamo NVARCHAR(50) NOT NULL,
    Fecha DATETIME NOT NULL,
    EstudianteId INT NOT NULL,
    EquipoId INT NOT NULL,
    Cantidad INT NOT NULL,
    FechaDevolucion DATETIME NULL,
    Estado NVARCHAR(20) NOT NULL,
    FOREIGN KEY (EstudianteId) REFERENCES Estudiantes(Id),
    FOREIGN KEY (EquipoId) REFERENCES Equipos(Id)
);
GO


INSERT INTO Usuarios (Username, Password) VALUES ('admin', '123456');
GO

INSERT INTO Equipos (Codigo, Nombre, Descripcion, Disponible) VALUES 
('EQ001', 'Laptop Dell', 'Laptop para uso de laboratorio', 1),
('EQ002', 'Proyector Epson', 'Proyector portátil', 1),
('EQ003', 'Multímetro', 'Multímetro digital', 1);
GO

INSERT INTO Estudiantes (Codigo, DNI, Nombres, Apellidos, EscuelaProfesional, Telefono) VALUES 
('2023001', '12345678', 'Juan', 'Pérez', 'Ingeniería de Sistemas', '987654321'),
('2023002', '87654321', 'María', 'García', 'Ingeniería Industrial', '912345678');
GO
