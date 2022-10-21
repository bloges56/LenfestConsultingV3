﻿USE [master]

IF db_id('LENFESTCONSULTINGV2') IS NULL
  CREATE DATABASE [LENFESTCONSULTINGV2]
GO

USE [LENFESTCONSULTINGV2]
GO

DROP TABLE IF EXISTS [User];

GO

CREATE TABLE [User] (
  [Id] integer PRIMARY KEY IDENTITY,
  [UserName] nvarchar(20) NOT NULL,
  [Email] nvarchar(555) NOT NULL,
  [IsActive] bit NOT NULL DEFAULT 1,
  [IsAdmin] bit NOT NULL DEFAULT 0,
  [FirebaseUserId] NVARCHAR(28) NOT NULL

  CONSTRAINT UQ_FirebaseUserId UNIQUE(FirebaseUserId),
  CONSTRAINT UQ_Email UNIQUE(Email),
  CONSTRAINT UQ_UserName UNIQUE(UserName)
)



