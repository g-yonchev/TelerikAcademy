USE [master]
GO
/****** Object:  Database [World]    Script Date: 02-Oct-15 13:40:10 ******/
CREATE DATABASE [World]
 CONTAINMENT = NONE
 GO
ALTER DATABASE [World] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [World].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [World] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [World] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [World] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [World] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [World] SET ARITHABORT OFF 
GO
ALTER DATABASE [World] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [World] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [World] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [World] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [World] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [World] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [World] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [World] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [World] SET  DISABLE_BROKER 
GO
ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [World] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [World] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [World] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [World] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [World] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [World] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [World] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [World] SET  MULTI_USER 
GO
ALTER DATABASE [World] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [World] SET DB_CHAINING OFF 
GO
ALTER DATABASE [World] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [World] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [World] SET DELAYED_DURABILITY = DISABLED 
GO
USE [World]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 02-Oct-15 13:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CityId] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cities]    Script Date: 02-Oct-15 13:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 02-Oct-15 13:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 02-Oct-15 13:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentId] [int] NOT NULL,
	[Capital] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 02-Oct-15 13:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (1, N'Ap #800-4917 Aliquet St.', 11)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (2, N'Ap #278-6783 Phasellus Rd.', 16)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (3, N'P.O. Box 684, 6459 Enim. Road', 33)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (4, N'208-3817 Tincidunt Road', 29)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (5, N'357-3032 Odio, St.', 38)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (6, N'Ap #349-4480 Euismod Ave', 1)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (7, N'138-6398 Cursus, Road', 8)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (8, N'150-5826 Eu, Street', 22)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (9, N'Ap #774-1961 A St.', 9)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (10, N'2222 Nibh Av.', 37)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (11, N'508-5072 Consequat Rd.', 24)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (12, N'P.O. Box 612, 4755 Dolor, Rd.', 42)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (13, N'Ap #781-5011 Posuere St.', 37)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (14, N'Ap #841-8220 Vivamus Rd.', 26)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (15, N'8073 Risus Street', 32)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (16, N'Ap #259-906 Nulla St.', 22)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (17, N'P.O. Box 264, 3519 Velit St.', 39)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (18, N'P.O. Box 895, 2724 Nunc Avenue', 33)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (19, N'636 Mus. Road', 28)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (20, N'P.O. Box 382, 5067 Hymenaeos. Ave', 15)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (21, N'3580 Semper Avenue', 10)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (22, N'7632 Mauris Ave', 4)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (23, N'918-3813 Aliquet St.', 25)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (24, N'913-1691 Ligula Rd.', 24)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (25, N'Ap #738-5751 Tincidunt Avenue', 18)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (26, N'871-984 Est. Av.', 23)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (27, N'942-4475 Ornare. Av.', 4)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (28, N'P.O. Box 402, 4173 Accumsan Avenue', 42)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (29, N'816-6806 Orci. Street', 19)
INSERT [dbo].[Addresses] ([Id], [Name], [CityId]) VALUES (30, N'5886 Eros. Rd.', 23)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (1, N'Moscow', 1)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (2, N'Saint Petersburg', 1)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (3, N'Novosibirsk', 1)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (4, N'Shanghai', 2)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (5, N'New Delhi', 3)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (6, N'Ulaanbaatar', 4)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (7, N'Tokyo', 5)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (8, N'Cairo', 6)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (9, N'Giza', 6)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (10, N'Rabat', 7)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (11, N'Casablanca', 7)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (12, N'Tripoli', 8)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (13, N'Khartoum', 9)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (14, N'Sofia', 10)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (15, N'Plovdiv', 10)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (16, N'Varna', 10)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (17, N'Pernik', 10)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (18, N'Barcelona', 11)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (19, N'Madrid', 11)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (20, N'Valencia', 11)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (21, N'Seville', 11)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (22, N'Rome', 12)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (23, N'Milan', 12)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (24, N'Venice', 12)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (25, N'Paris', 13)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (26, N'Lyon', 13)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (27, N'Athens', 14)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (28, N'Washington', 15)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (29, N'New York', 15)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (30, N'Los Angelis', 15)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (31, N'Ottawa', 16)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (32, N'Toronto', 16)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (33, N'Mexico City', 17)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (34, N'Acapulco', 17)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (35, N'Brasília', 18)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (36, N'Sao Paulo', 18)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (37, N'Buenos Aires', 19)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (38, N'Cordoba', 19)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (39, N'Lima', 20)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (40, N'Canberra', 21)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (41, N'Sydney', 21)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId]) VALUES (42, N'Jakarta', 22)
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([Id], [Name]) VALUES (1, N'Asia')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (3, N'Antarctica')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (4, N'Europe')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (5, N'North America')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (6, N'South America')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (7, N'Australia and Oceania')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (1, N'Russia', 1, 1)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (2, N'China', 1, 4)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (3, N'India', 1, 5)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (4, N'Mongolia', 1, 6)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (5, N'Japan', 1, 7)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (6, N'Egypt', 2, 8)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (7, N'Morocco', 2, 10)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (8, N'Libya', 2, 12)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (9, N'Sudan', 2, 13)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (10, N'Bulgaria', 4, 14)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (11, N'Spain', 4, 19)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (12, N'Italy', 4, 22)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (13, N'France', 4, 25)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (14, N'Greece', 4, 27)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (15, N'USA', 5, 28)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (16, N'Canada', 5, 31)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (17, N'Mexico', 5, 33)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (18, N'Brazil', 6, 35)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (19, N'Argentina', 6, 37)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (20, N'Peru', 6, 39)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (21, N'Australia', 7, 40)
INSERT [dbo].[Countries] ([Id], [Name], [ContinentId], [Capital]) VALUES (22, N'Indonesia', 7, 42)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (1, N'Chester', N'Guerra', 30)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (2, N'Whoopi', N'Marsh', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (3, N'Avye', N'Dixon', 8)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (4, N'Leah', N'Mcclain', 23)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (5, N'Clare', N'Morse', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (6, N'Linda', N'Webster', 22)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (7, N'Emery', N'Houston', 21)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (8, N'Janna', N'Poole', 22)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (9, N'Blair', N'Chambers', 16)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (10, N'Tana', N'Guzman', 10)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (11, N'Finn', N'Vincent', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (12, N'Grace', N'Dyer', 14)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (13, N'Merritt', N'Newman', 5)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (14, N'Kay', N'Alexander', 14)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (15, N'Davis', N'Avila', 15)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (16, N'Wyoming', N'Dickson', 5)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (17, N'Armand', N'Avery', 16)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (18, N'Ulric', N'Vaughan', 3)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (19, N'Caleb', N'Woods', 6)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (20, N'Morgan', N'Kirby', 12)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (21, N'Amena', N'Acevedo', 12)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (22, N'Hunter', N'Calderon', 1)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (23, N'Dalton', N'Joyce', 29)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (24, N'Brett', N'Perkins', 9)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (25, N'Xena', N'Kirkland', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (26, N'Axel', N'Booth', 9)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (27, N'Hedwig', N'Nichols', 29)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (28, N'Judah', N'Levine', 26)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (29, N'Ira', N'Ross', 27)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (30, N'Lane', N'Stein', 1)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (31, N'Jameson', N'Blackburn', 3)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (32, N'Phoebe', N'Calderon', 25)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (33, N'Quyn', N'Yates', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (34, N'Ariana', N'Richards', 11)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (35, N'Ingrid', N'Peters', 9)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (36, N'Aileen', N'Mckay', 27)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (37, N'Hedy', N'Wilkerson', 23)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (38, N'Mara', N'Roy', 22)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (39, N'Dylan', N'Shaffer', 26)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (40, N'Kelsey', N'Burns', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (41, N'Thane', N'Pugh', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (42, N'Urielle', N'Meyer', 13)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (43, N'Derek', N'Jensen', 5)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (44, N'Shad', N'Cervantes', 22)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (45, N'Kessie', N'Gallagher', 17)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (46, N'Liberty', N'Coleman', 4)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (47, N'Megan', N'Pacheco', 15)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (48, N'Clayton', N'Wagner', 10)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (49, N'Marshall', N'Campos', 28)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (50, N'Rhonda', N'Porter', 26)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (51, N'Tarik', N'Raymond', 24)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (52, N'Tatum', N'England', 2)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (53, N'Eleanor', N'Farley', 6)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (54, N'Derek', N'Compton', 16)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (55, N'Ignatius', N'Barr', 26)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (56, N'Amity', N'Marshall', 14)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (57, N'Lev', N'Hancock', 22)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (58, N'Garth', N'Collins', 16)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (59, N'Wylie', N'Pena', 26)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (60, N'Paloma', N'Marsh', 10)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (61, N'Hermione', N'Sykes', 1)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (62, N'Barrett', N'Hardy', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (63, N'Jeremy', N'Wolf', 22)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (64, N'Armand', N'Holland', 15)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (65, N'Eliana', N'Camacho', 12)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (66, N'Echo', N'Estrada', 4)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (67, N'Ali', N'Morrison', 25)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (68, N'Veronica', N'Holt', 6)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (69, N'Joan', N'Gray', 30)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (70, N'Whoopi', N'Carpenter', 22)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (71, N'TaShya', N'Hartman', 13)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (72, N'Phoebe', N'Mcintosh', 15)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (73, N'Ingrid', N'Camacho', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (74, N'Lars', N'Cain', 5)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (75, N'Gil', N'Burt', 24)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (76, N'Seth', N'Hess', 11)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (77, N'Joan', N'Winters', 4)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (78, N'Wade', N'Klein', 25)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (79, N'Erica', N'Bright', 27)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (80, N'Alec', N'Mcbride', 20)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (81, N'Bruce', N'Wise', 21)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (82, N'Wyoming', N'Tran', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (83, N'Jana', N'Shields', 3)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (84, N'Coby', N'Camacho', 20)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (85, N'Grant', N'Estrada', 10)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (86, N'Tana', N'Savage', 17)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (87, N'Judah', N'Miller', 21)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (88, N'Dominique', N'Pierce', 13)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (89, N'Dai', N'Joyner', 30)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (90, N'Gareth', N'Acevedo', 8)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (91, N'Imelda', N'Mendoza', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (92, N'Howard', N'Howe', 8)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (93, N'Charlotte', N'Moore', 19)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (94, N'Clio', N'Sharpe', 16)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (95, N'Ruth', N'Martin', 8)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (96, N'Iliana', N'Walls', 21)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (97, N'Noble', N'Barker', 9)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (98, N'Nadine', N'Mayer', NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (99, N'Leo', N'Holder', 21)
GO
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId]) VALUES (100, N'Porter', N'Morton', 27)
SET IDENTITY_INSERT [dbo].[Persons] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Cities]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Countries]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Cities] FOREIGN KEY([Capital])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Cities]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continents] ([Id])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Addresses] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Addresses]
GO
USE [master]
GO
ALTER DATABASE [World] SET  READ_WRITE 
GO
