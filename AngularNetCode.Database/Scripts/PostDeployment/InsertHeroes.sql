IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Spiderman')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (1, 'Spiderman')
END

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Batman')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (2, 'Batman')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Iron Man')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (3, 'Iron Man')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Captain America')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (4, 'Captain America')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'The Hulk')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (5, 'The Hulk')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Thor')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (6, 'Thor')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Loki')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (7, 'Loki')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Black widow')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (8, 'Black widow')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Scarlet Witch')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (9, 'Scarlet Witch')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'War Machine')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (10, 'War Machine')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Hawkeye')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (11, 'Hawkeye')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Dr. Strange')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (12, 'Dr. Strange')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Black Panther')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (13, 'Black Panther')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Groot')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (14, 'Groot')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Rocket')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (15, 'Rocket')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Star-Lord')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (16, 'Star-Lord')
END 

IF NOT EXISTS (SELECT [Name] FROM [dbo].[Heroes] WHERE [Name] = 'Gamora')
BEGIN
    INSERT INTO [dbo].[Heroes] ([Id], [Name])
    VALUES (17, 'Gamora')
END 