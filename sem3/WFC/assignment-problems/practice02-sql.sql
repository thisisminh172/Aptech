CREATE DATABASE SupperShoppe

use SupperShoppe

CREATE TABLE Category(
	CatCode varchar(10) primary key,
	CatDescription varchar(200)
)

CREATE TABLE Items(
	ItemCode varchar(10) primary key,
	ItemDesc varchar(200),
	ItemCat varchar(50),
	Price int,
	Qoh int,
	Comp varchar(100)
)

CREATE TABLE [User](
	UserName varchar(50) primary key,
	[Password] varchar(100),
	[Status] varchar(10)
)

