--if exists(select * from sys.columns where name = 'SlideProofLicenses' and object_id = object_id('ModuleConfigurations'))  
--begin
EXEC sp_rename 'ModuleConfigurations.SlideProofLicenses', 'ProductivityTools', 'COLUMN';
--end

--GO