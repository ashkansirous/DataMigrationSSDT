if exists(select * from sys.columns where name = 'moduleLicenses_tmp' and object_id = object_id('ModuleConfigurations'))  
begin
Exec('update [ModuleConfigurations] set [moduleLicenses_tmp] =  CONVERT(INT, moduleLicenses)')
ALTER TABLE [dbo].[ModuleConfigurations] ALTER COLUMN [moduleLicenses] int null;
Exec('update ModuleConfigurations set moduleLicenses = moduleLicenses_tmp')
ALTER TABLE [ModuleConfigurations] drop  column [moduleLicenses_tmp]  
end

Go
