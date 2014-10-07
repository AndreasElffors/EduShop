
INSERT INTO [dbo].[CategorySet]
           ([Name]
           ,[Description])
     VALUES
           ('Operating Systems'
           ,'An operating system (OS) is software that manages computer hardware and software resources and provides common services for computer programs.'),
		   ('Anti-Malware software','Keeps your Pc safe and healthy'),
		   ('Adobe','Adobe software'),
		   ('Microsoft','Office related software')

		   GO

INSERT INTO [dbo].[ProductSet]
           ([Name]
           ,[Price]
           ,[ShortDescription]
           ,[ImgUrl]
           ,[AverageRating]
           ,[Description]
           ,[CategoryId])
     VALUES
           ('Windows 8 Pro',
           199,
           'Windows 8 - The latest Microsoft OS',
           '~/Images/windows8box.jpg',
           '2', 
		   'Windows 8 Pro Product Key Card is a physical product key card which contains the product key and link to use to upgrade your current operating system to Windows 8 Pro. This Product Key Card is Medialess, meaning that it does not include a DVD or CD for installation. You will download the program directly from Microsoft and use this product key to install and activate the software.
				 This is the physical key card which will be shipped to you. After installing Windows 8 Pro, you also have the option of upgrading to Windows 8.1 Pro in the Microsoft App store at no additional cost.',
           '1')
		   

GO

INSERT INTO [dbo].[UserSet]
           ([Email]
           ,[Password]
           ,[Firstname]
           ,[Lastname]
           ,[Address]
           ,[Zip]
           ,[City]
           ,[Phone]
           ,[IsAdmin])
     VALUES
           ('johnDoe@edushop.com',
           'qaz123',
           'John',
           'Doe',
           'The white house 1600 Pennsylvania Avenue NW',
           '20500',
           'Washington DC',
           '1202-456-1111',
           '1')

GO

INSERT INTO [dbo].[ReviewSet]
           ([Title]
           ,[Content]
           ,[Rating]
           ,[DateAdded]
           ,[ProductId])
     VALUES
           ('A decent OS',
           'Windows 8 is a decent OS but i still prefer Windows 7',
           '2.5',
           '2014-10-06',
           1)

		   GO