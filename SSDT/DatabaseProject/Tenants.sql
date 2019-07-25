CREATE TABLE [dbo].[Tenants]
(
	[Id] VARCHAR (20)   NOT NULL, 
    [Name]                  NVARCHAR (50)   NOT NULL,
    [Partner]               NVARCHAR (100)  NULL,
CONSTRAINT [PK_Tenants] PRIMARY KEY CLUSTERED ([Id] ASC)
)
