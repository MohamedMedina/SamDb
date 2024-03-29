﻿/*
Deployment script for SAM_DB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "SAM_DB"
:setvar DefaultFilePrefix "SAM_DB"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [Transactions]...';


GO
CREATE SCHEMA [Transactions]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [Lookups].[CardType]...';


GO
CREATE TABLE [Lookups].[CardType] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (30) NULL,
    [nameAr] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Lookups].[CardValidity]...';


GO
CREATE TABLE [Lookups].[CardValidity] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (30) NULL,
    [nameAr] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Lookups].[RejectReason]...';


GO
CREATE TABLE [Lookups].[RejectReason] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (30) NULL,
    [nameAr] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Lookups].[RequestClass]...';


GO
CREATE TABLE [Lookups].[RequestClass] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (30) NULL,
    [nameAr] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Lookups].[RequestPriority]...';


GO
CREATE TABLE [Lookups].[RequestPriority] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (30) NULL,
    [nameAr] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Lookups].[RequestStatus]...';


GO
CREATE TABLE [Lookups].[RequestStatus] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (30) NULL,
    [nameAr] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Lookups].[RequestType]...';


GO
CREATE TABLE [Lookups].[RequestType] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (30) NULL,
    [nameAr] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Update complete.';


GO
