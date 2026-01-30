-- =============================================
-- ESHIFT Database - Create Script for SSMS
-- Run this script in SQL Server Management Studio
-- against your SQL Server instance.
-- =============================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'eShiftDB')
    DROP DATABASE eShiftDB;
GO

CREATE DATABASE eShiftDB;
GO

USE eShiftDB;
GO

-- =============================================
-- Table: Login (Admin/Employee/Customer credentials)
-- =============================================
CREATE TABLE dbo.Login (
    idno          INT IDENTITY(1,1) NOT NULL,
    UserName      NVARCHAR(50) NOT NULL,
    Password      NVARCHAR(100) NOT NULL,
    Role          NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Login PRIMARY KEY CLUSTERED (idno),
    CONSTRAINT UQ_Login_UserName UNIQUE (UserName)
);
GO

-- =============================================
-- Table: Customer
-- =============================================
CREATE TABLE dbo.Customer (
    CustomerId    INT IDENTITY(1,1) NOT NULL,
    Name          NVARCHAR(100) NOT NULL,
    CustomerIdNo  NVARCHAR(50) NULL,
    Phone         NVARCHAR(50) NULL,
    Email         NVARCHAR(100) NULL,
    Address       NVARCHAR(255) NULL,
    UserName      NVARCHAR(50) NULL,
    CONSTRAINT PK_Customer PRIMARY KEY CLUSTERED (CustomerId),
    CONSTRAINT FK_Customer_Login FOREIGN KEY (UserName) REFERENCES dbo.Login(UserName)
);
GO

-- =============================================
-- Table: TransportUnit
-- =============================================
CREATE TABLE dbo.TransportUnit (
    UnitId             INT IDENTITY(1,1) NOT NULL,
    VehicleNumberPlate NVARCHAR(50) NULL,
    DriverName         NVARCHAR(100) NULL,
    DriverPhone        NVARCHAR(50) NULL,
    DriverIdNo         NVARCHAR(50) NULL,
    AssistantName      NVARCHAR(100) NULL,
    AssistantPhone     NVARCHAR(50) NULL,
    AssistantIdNo      NVARCHAR(50) NULL,
    ContainerId        NVARCHAR(50) NULL,
    Status             NVARCHAR(50) NULL,
    VehicleType        NVARCHAR(50) NULL,
    CONSTRAINT PK_TransportUnit PRIMARY KEY CLUSTERED (UnitId)
);
GO

-- =============================================
-- Table: Job
-- =============================================
CREATE TABLE dbo.Job (
    JobId         INT IDENTITY(1,1) NOT NULL,
    CustomerId    INT NOT NULL,
    StartLocation NVARCHAR(255) NULL,
    Destination   NVARCHAR(255) NULL,
    PickupDate    DATE NULL,
    DeliveryDate  DATE NULL,
    Status        NVARCHAR(50) NULL,
    PaymentAmount DECIMAL(18,2) NULL,
    UnitId        INT NULL,
    CONSTRAINT PK_Job PRIMARY KEY CLUSTERED (JobId),
    CONSTRAINT FK_Job_Customer FOREIGN KEY (CustomerId) REFERENCES dbo.Customer(CustomerId),
    CONSTRAINT FK_Job_TransportUnit FOREIGN KEY (UnitId) REFERENCES dbo.TransportUnit(UnitId)
);
GO

-- =============================================
-- Table: Load (items per job)
-- =============================================
CREATE TABLE dbo.[Load] (
    LoadId          INT IDENTITY(1,1) NOT NULL,
    JobId           INT NOT NULL,
    TransportUnitId INT NULL,
    Description     NVARCHAR(255) NULL,
    WeightKg        FLOAT NULL,
    CONSTRAINT PK_Load PRIMARY KEY CLUSTERED (LoadId),
    CONSTRAINT FK_Load_Job FOREIGN KEY (JobId) REFERENCES dbo.Job(JobId),
    CONSTRAINT FK_Load_TransportUnit FOREIGN KEY (TransportUnitId) REFERENCES dbo.TransportUnit(UnitId)
);
GO

-- =============================================
-- Sample data (optional - for testing)
-- =============================================

-- Default admin login (UserName: admin, Password: admin123)
INSERT INTO dbo.Login (UserName, Password, Role)
VALUES (N'admin', N'admin123', N'Admin');
GO

-- Optional: Employee login (UserName: employee, Password: emp123)
INSERT INTO dbo.Login (UserName, Password, Role)
VALUES (N'employee', N'emp123', N'Employee');
GO

PRINT N'eShiftDB database created successfully.';
PRINT N'Default Admin: UserName = admin, Password = admin123';
GO
