--ALTER TABLE [World] DROP CONSTRAINT [World_Fk_User];

--ALTER TABLE [Material] DROP CONSTRAINT [Material_Fk_World];
--ALTER TABLE [Material] DROP CONSTRAINT [Material_Fk_Template];
--ALTER TABLE [Material] DROP CONSTRAINT [Material_Fk_TemplateType];

DROP TABLE  [User];
DROP TABLE  [World];
DROP TABLE  [Material];
DROP TABLE  [Template];
