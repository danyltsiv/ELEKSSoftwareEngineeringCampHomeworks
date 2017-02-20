create database ELEKSACADEMY;
use ELEKSACADEMY;

create table [dbo].Product(
					Id int IDENTITY(1,1) NOT NULL,
					Name varchar(50) NOT NULL,
					BarCode nchar(10) NULL,
					Price money NOT NULL DEFAULT 0,
					Number int NOT NULL DEFAULT 0,
					Comment varchar(250) NULL,
					CONSTRAINT PK_Product PRIMARY KEY(Id), 
					CONSTRAINT UK_Product UNIQUE(Name)
					) ON [PRIMARY];
					
create table [dbo].Client(
					Id int IDENTITY(1,1) NOT NULL,
					Name varchar(50) NOT NULL,
					Address varchar(75) NOT NULL,
					Amount money NOT NULL DEFAULT 0,
					Comment varchar(250) NULL,
					CONSTRAINT PK_Client PRIMARY KEY(Id), 
					CONSTRAINT UK_Client UNIQUE(Name)
					) ON [PRIMARY];
					
create table dbo.DocumentType(
				    Id int IDENTITY(1,1) NOT NULL,
				    Name varchar(50) NOT NULL,
				    Comment varchar(250) NULL,
				    CONSTRAINT PK_DocumentType PRIMARY KEY(Id),
				    CONSTRAINT UK_DocumentType UNIQUE(Name)
				    ) ON [PRIMARY];

				
create table [dbo].Document(
					Id int IDENTITY(1,1) NOT NULL,
					Type int NOT NULL,
					Number int NOT NULL,
					Date date NOT NULL,
					Client int NOT NULL,
					Amount money NOT NULL DEFAULT 0,
					Comment varchar(250) NULL,
					CONSTRAINT PK_Document PRIMARY KEY(Id), 
					CONSTRAINT UK_Document_Type UNIQUE(Type),
					CONSTRAINT UK_Document_Number UNIQUE(Number)
					) ON [PRIMARY];
					
create table [dbo].DocDetail(
					Instance int IDENTITY(1,1) NOT NULL,
					Document int NOT NULL,
					Product int NOT NULL,
					Number int NOT NULL,
					Price money NOT NULL DEFAULT 0,
					CONSTRAINT PK_DocDetail PRIMARY KEY(Instance),
					CONSTRAINT UK_DocDetail_Document UNIQUE(Document),
					CONSTRAINT UK_DocDetail_Product UNIQUE(Product)
					) ON [PRIMARY];