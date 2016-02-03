use StudentsDB
CREATE TABLE [dbo].[Students]
(
	[NIM] INT NOT NULL PRIMARY KEY Identity,
	[Nama] Varchar(50) not null,
	[Alamat] Varchar(100) not null,
	[Umur] int not null
)