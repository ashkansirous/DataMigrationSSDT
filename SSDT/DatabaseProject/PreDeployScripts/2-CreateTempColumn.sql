if (SELECT lower(DATA_TYPE)  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'ModuleConfigurations' AND COLUMN_NAME = 'moduleLicenses') <> 'int'
begin
ALTER TABLE [ModuleConfigurations] add  [moduleLicenses_tmp] int null;
end

GO