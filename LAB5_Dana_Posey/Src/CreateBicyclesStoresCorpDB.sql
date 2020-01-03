/********************************************************
* This script creates the database named BicycleStoresCorp 
*********************************************************/
USE master;
GO

IF  DB_ID('BicycleStoresCorp') IS NOT NULL
    DROP DATABASE BicycleStoresCorp;
GO

CREATE DATABASE BicycleStoresCorp;
GO

USE BicycleStoresCorp;

-- create the tables for the database
CREATE TABLE Respondents (
	RespondentID	INT			PRIMARY KEY IDENTITY,
	FirstName		VARCHAR(60)	NOT NULL,
	LastName		VARCHAR(60)	NOT NULL,
	EmailAddress	VARCHAR(60) NOT NULL	UNIQUE,
	AddressLine1	VARCHAR(60)	NOT NULL,
	AddressLine2	VARCHAR(60),
	City			VARCHAR(60)	NOT NULL,
	StateAbbr		VARCHAR(2)	NOT NULL,
	ZipCode			VARCHAR(10)	NOT NULL,
	LastSurvey		DATETIME
);

CREATE TABLE Responses (
	ResponseID		INT			PRIMARY KEY	IDENTITY,
	RespondentID	INT			FOREIGN KEY REFERENCES Respondents (RespondentId) NOT NULL,	
	SurveyDate		DATETIME	NOT NULL	DEFAULT GETDATE(),
	Answer1			VARCHAR(255)	NOT NULL,
	Answer2			VARCHAR(255)	NOT NULL,
	Answer3			VARCHAR(255)	NOT NULL,
	Answer4			VARCHAR(255)	NOT NULL,
	Answer5			VARCHAR(255)	NOT NULL,
	Answer6			VARCHAR(255)
);

