CREATE DATABASE javaDB
go

use javaDB
go

create table tbProject(
ID int identity(100,1) not null primary key,
projectName varchar(30) not null,
startDate varchar(10) not null,
value int not null check(value>0),
completed bit not null 
)

