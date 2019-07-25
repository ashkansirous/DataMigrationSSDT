CREATE TABLE [dbo].[ModuleConfigurations] (
    [Id]  VARCHAR (20)    NOT NULL,
    [TemplafyLicenses] INT NULL, 
    [ProductivityTools] INT NULL, 
    [ModuleLicenses] INT NULL,
    [CheckLicences] INT NULL, 
    CONSTRAINT [PK_ModuleConfiguration] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ModuleConfiguration_Tenants] FOREIGN KEY ([Id]) REFERENCES [Tenants]([Id]) ON DELETE CASCADE
	);