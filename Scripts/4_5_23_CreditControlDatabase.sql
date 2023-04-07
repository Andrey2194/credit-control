CREATE DATABASE CreditControl

USE CreditControl

CREATE TABLE Debtor(
	[Id] Uniqueidentifier primary key,
	[Name] varchar(250),
	[Active] bit default(1)
);

CREATE TABLE Debt(
	[Id] Uniqueidentifier primary key,
	[DebtorId] Uniqueidentifier,
	[StartDate] Datetime2 not null,
	[DealEndDate] Datetime2 not null,
	[EndDate] Datetime2 null,
	[Amount] Money NOT NULL,
	[Active] bit default(1),
	CONSTRAINT FK_Debtor FOREIGN KEY ([DebtorId])
    REFERENCES Debtor(Id)
);


CREATE TABLE Payment(
	[Id] Uniqueidentifier primary key,
	[DebtId] Uniqueidentifier,
	[PaymentDate] datetime2,
	[Amount] Money NOT NULL,
	CONSTRAINT FK_DebPayments FOREIGN KEY ([DebtId])
    REFERENCES Debt(Id)
);

