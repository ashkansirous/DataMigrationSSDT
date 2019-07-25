CREATE TABLE [dbo].[ModuleConfigurations] (
    [Id]  VARCHAR (20)    NOT NULL,
    [TemplafyLicenses] INT NULL, 
    [SlideProofLicenses] INT NULL, 
    [ModuleLicenses] varchar(50) NULL,
    CONSTRAINT [PK_ModuleConfiguration] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ModuleConfiguration_Tenants] FOREIGN KEY ([Id]) REFERENCES [Tenants]([Id]) ON DELETE CASCADE
	);