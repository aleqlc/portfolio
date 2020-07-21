--명언(Maxim) 서비스
CREATE TABLE [dbo].[Maxims]
(
	[Id]			INT	PRIMARY KEY NOT NULL Identity(1,1),
	[Name]			NVarChar(25)	NOT NULL,				--작성자
	[Content]		NVarChar(255)	NULL,					--명언 내용
	[CreationDate]	DateTime Default(GetDate())
)
Go
