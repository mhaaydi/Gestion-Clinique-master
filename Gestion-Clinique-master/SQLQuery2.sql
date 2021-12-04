create table Login(
	Username Nvarchar(45) primary key not null,
	Password nvarchar(128) not null,
	Roles nvarchar(150) not null
);