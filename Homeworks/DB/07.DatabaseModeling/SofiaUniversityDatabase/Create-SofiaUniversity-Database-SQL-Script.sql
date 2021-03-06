USE [master]
GO
/****** Object:  Database [SofiaUniversity]    Script Date: 02-Oct-15 13:46:34 ******/
CREATE DATABASE [SofiaUniversity]
 CONTAINMENT = NONE
 GO
ALTER DATABASE [SofiaUniversity] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SofiaUniversity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SofiaUniversity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SofiaUniversity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SofiaUniversity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SofiaUniversity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SofiaUniversity] SET ARITHABORT OFF 
GO
ALTER DATABASE [SofiaUniversity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SofiaUniversity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SofiaUniversity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SofiaUniversity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SofiaUniversity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SofiaUniversity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SofiaUniversity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SofiaUniversity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SofiaUniversity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SofiaUniversity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SofiaUniversity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SofiaUniversity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SofiaUniversity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SofiaUniversity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SofiaUniversity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SofiaUniversity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SofiaUniversity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SofiaUniversity] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SofiaUniversity] SET  MULTI_USER 
GO
ALTER DATABASE [SofiaUniversity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SofiaUniversity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SofiaUniversity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SofiaUniversity] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SofiaUniversity] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SofiaUniversity]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorsCourses]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorsCourses](
	[ProfessorId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_ProfessorsCourses] PRIMARY KEY CLUSTERED 
(
	[ProfessorId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorsTitles]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorsTitles](
	[ProfessorId] [int] NOT NULL,
	[TitleId] [int] NOT NULL,
 CONSTRAINT [PK_ProfessorsTitles] PRIMARY KEY CLUSTERED 
(
	[ProfessorId] ASC,
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FacultyNumber] [nchar](8) NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentsCourses]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsCourses](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_StudentsCourses] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 02-Oct-15 13:46:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (1, 1)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (2, 2)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (4, 2)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (5, 7)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (6, 8)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (9, 11)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (10, 11)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (11, 12)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (12, 10)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (13, 11)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (14, 14)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (15, 16)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (16, 17)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (17, 12)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (18, 20)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (19, 21)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (20, 22)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (21, 19)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (22, 1)
INSERT [dbo].[Courses] ([Id], [DepartmentId]) VALUES (23, 23)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (1, N'Music', 7)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (2, N'Theatre', 7)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (7, N'Veterinary physiology', 6)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (8, N'Industrial and production engineering', 5)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (9, N'Mechanical engineering', 5)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (10, N'Electrical and electronic engineering', 5)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (11, N'Sociology', 4)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (12, N'Geography', 4)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (13, N'Economics', 4)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (14, N'Psychology', 4)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (15, N'Mathematics', 3)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (16, N'Physics', 3)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (17, N'Geology', 3)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (18, N'Statistics', 3)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (19, N'Pharmaceutics and industrial pharmacy', 2)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (20, N'Human nutrition', 1)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (21, N'Physiotherapy', 1)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (22, N'Surgery', 1)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (23, N'Health Policy And Management', 1)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (24, N'Biochemistry', 1)
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (1, N'Medicine')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (2, N'Pharmacy')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (3, N'Science')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (4, N'Social science')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (5, N'Technology')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (6, N'Veterinary medicine')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (7, N'Art')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
SET IDENTITY_INSERT [dbo].[Professors] ON 

INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (1, N'Raja', N'Beach')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (2, N'Ferdinand', N'Collins')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (3, N'Jessamine', N'Knowles')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (4, N'Kibo', N'Lindsey')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (5, N'September', N'Suarez')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (6, N'Jerry', N'Wells')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (7, N'Whilemina', N'Rivera')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (8, N'Dara', N'Rhodes')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (9, N'Ariana', N'Serrano')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (10, N'Anthony', N'Lynch')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (11, N'Belle', N'Mcintosh')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (12, N'Tasha', N'Mcneil')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (13, N'Brandon', N'Christensen')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (14, N'Brian', N'Compton')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (15, N'Zane', N'Wagner')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (16, N'Declan', N'Koch')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (17, N'Lionel', N'Santiago')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (18, N'Claire', N'Little')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (19, N'Davis', N'Pate')
INSERT [dbo].[Professors] ([Id], [FirstName], [LastName]) VALUES (20, N'Nyssa', N'England')
SET IDENTITY_INSERT [dbo].[Professors] OFF
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (1, 4)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (1, 15)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (2, 4)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (2, 22)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (6, 1)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (6, 10)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (8, 18)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (11, 9)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (16, 4)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (18, 17)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (20, 1)
INSERT [dbo].[ProfessorsCourses] ([ProfessorId], [CourseId]) VALUES (20, 11)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (1, 1)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (5, 3)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (6, 5)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (7, 3)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (8, 2)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (8, 3)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (8, 4)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (8, 6)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (11, 4)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (11, 5)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (12, 1)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (12, 3)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (12, 5)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (12, 6)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (13, 2)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (13, 4)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (13, 5)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (13, 6)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (14, 1)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (17, 5)
INSERT [dbo].[ProfessorsTitles] ([ProfessorId], [TitleId]) VALUES (19, 1)
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (1, N'Pesho', N'Peshov', N'12345678', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (2, N'Kevin', N'Emerson', N'80227471', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (3, N'Jonas', N'Nichols', N'00195645', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (4, N'Karyn', N'Peck', N'57212587', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (5, N'Kane', N'Gillespie', N'57873806', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (6, N'Kieran', N'Tucker', N'36161144', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (7, N'Giacomo', N'Velez', N'83780492', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (8, N'Ruby', N'Bowers', N'63873436', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (9, N'Carson', N'Baxter', N'82807333', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (10, N'Breanna', N'Mills', N'81952913', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (11, N'Laith', N'Hurley', N'55361576', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (12, N'Ora', N'Kirkland', N'86876950', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (13, N'Hadley', N'Mccarthy', N'95678821', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (14, N'Edan', N'Bell', N'79892806', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (15, N'Galena', N'Gibbs', N'86428269', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (16, N'Isabella', N'Hawkins', N'49066669', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (17, N'Meghan', N'Webb', N'07349736', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (18, N'Ivor', N'Knapp', N'32045641', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (19, N'Isaac', N'Manning', N'89559880', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (20, N'Beatrice', N'Stone', N'66057195', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (21, N'Desiree', N'Santiago', N'85576530', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (22, N'Grady', N'Duke', N'44054638', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (23, N'Germane', N'Roman', N'81014238', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (24, N'Adele', N'Scott', N'58087858', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (25, N'Casey', N'Herring', N'83998668', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (26, N'Griffith', N'Olson', N'36449247', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (27, N'Kai', N'Pickett', N'59059997', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (28, N'Eaton', N'Graham', N'33200512', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (29, N'Frances', N'Carpenter', N'31758631', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (30, N'Jorden', N'Graham', N'48059097', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (31, N'Adrian', N'Roman', N'56854875', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (32, N'Iola', N'Webster', N'26859039', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (33, N'Jessamine', N'Calderon', N'38008318', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (34, N'Julie', N'Roberts', N'07741343', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (35, N'Ciara', N'Guzman', N'02492610', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (36, N'Declan', N'Mcmahon', N'49208137', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (37, N'Kaye', N'Pollard', N'85123267', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (38, N'Dorian', N'Hurley', N'62931669', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (39, N'Giacomo', N'Horn', N'72272422', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (40, N'Isabelle', N'Fleming', N'74307875', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (41, N'Cullen', N'Lara', N'18312341', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (42, N'Hillary', N'Leonard', N'01093584', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (43, N'Sacha', N'Browning', N'85240637', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (44, N'Jenna', N'Roberson', N'24111976', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (45, N'Emerald', N'Richardson', N'68967519', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (46, N'May', N'Wise', N'75953900', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (47, N'Deanna', N'Fuller', N'02978231', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (48, N'Karina', N'Hubbard', N'27629978', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (49, N'Lisandra', N'Kim', N'98240048', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (50, N'Buffy', N'Watts', N'32987009', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (51, N'Imani', N'Douglas', N'95336980', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (52, N'Steel', N'Dejesus', N'13795568', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (53, N'Halla', N'Washington', N'06224373', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (54, N'Rylee', N'Rowland', N'54958639', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (55, N'Eugenia', N'Casey', N'25362108', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (56, N'Sierra', N'Lamb', N'83079254', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (57, N'Mariko', N'Knox', N'21630616', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (58, N'Xenos', N'Collier', N'74891204', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (59, N'Nichole', N'Colon', N'19977016', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (60, N'Knox', N'Bruce', N'76380529', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (61, N'Deirdre', N'Booker', N'83060798', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (62, N'Wayne', N'Macdonald', N'80270237', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (63, N'Uriel', N'Higgins', N'81307814', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (64, N'Geoffrey', N'Herman', N'12757090', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (65, N'Zeus', N'Bridges', N'75477623', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (66, N'Peter', N'Sloan', N'01988212', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (67, N'Jacqueline', N'Rocha', N'24438416', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (68, N'Jana', N'Pennington', N'64088509', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (69, N'Althea', N'Barton', N'85307854', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (70, N'Stacy', N'Dunlap', N'77618232', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (71, N'Bell', N'Marquez', N'88760713', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (72, N'Kane', N'Jarvis', N'96555556', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (73, N'Garth', N'Taylor', N'22889363', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (74, N'Calista', N'Flowers', N'83881836', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (75, N'Cain', N'Hood', N'13636603', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (76, N'Amena', N'Gomez', N'57815061', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (77, N'Chadwick', N'Kinney', N'25552738', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (78, N'Clark', N'Rhodes', N'27482622', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (79, N'Amos', N'Carr', N'31962479', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (80, N'Ifeoma', N'Evans', N'11307349', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (81, N'Ishmael', N'Farrell', N'78915262', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (82, N'Ivor', N'Roach', N'69747500', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (83, N'Elmo', N'Sears', N'59367132', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (84, N'Juliet', N'Carter', N'80849512', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (85, N'Jennifer', N'Bryant', N'40670570', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (86, N'Devin', N'Mays', N'97223686', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (87, N'Cooper', N'Lott', N'56183206', 5)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (88, N'Medge', N'Moses', N'65993137', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (89, N'Jael', N'Valenzuela', N'85102271', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (90, N'Liberty', N'Macdonald', N'79323297', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (91, N'Nelle', N'Gomez', N'19367840', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (92, N'Odessa', N'Scott', N'36283892', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (93, N'Phoebe', N'Bartlett', N'25000304', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (94, N'Eliana', N'Barrera', N'68689367', 3)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (95, N'Tamara', N'Pierce', N'83122193', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (96, N'Quail', N'Henderson', N'54196489', 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (97, N'Adam', N'Ramos', N'95539999', 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (98, N'Kellie', N'Roberson', N'47103207', 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (99, N'Neville', N'Clay', N'32742505', 1)
GO
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (100, N'Fitzgerald', N'Townsend', N'72087498', 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [FacultyNumber], [FacultyId]) VALUES (101, N'Renee', N'Phelps', N'50774020', 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Titles] ON 

INSERT [dbo].[Titles] ([Id], [Name]) VALUES (4, N'Academican')
INSERT [dbo].[Titles] ([Id], [Name]) VALUES (5, N'Docent')
INSERT [dbo].[Titles] ([Id], [Name]) VALUES (2, N'Junior Assistant')
INSERT [dbo].[Titles] ([Id], [Name]) VALUES (3, N'Ph. D')
INSERT [dbo].[Titles] ([Id], [Name]) VALUES (6, N'Professor')
INSERT [dbo].[Titles] ([Id], [Name]) VALUES (1, N'Senior Assistant')
SET IDENTITY_INSERT [dbo].[Titles] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Titles]    Script Date: 02-Oct-15 13:46:34 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Titles] ON [dbo].[Titles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[ProfessorsCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[ProfessorsCourses] CHECK CONSTRAINT [FK_ProfessorsCourses_Courses]
GO
ALTER TABLE [dbo].[ProfessorsCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsCourses_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[ProfessorsCourses] CHECK CONSTRAINT [FK_ProfessorsCourses_Professors]
GO
ALTER TABLE [dbo].[ProfessorsTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsTitles_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[ProfessorsTitles] CHECK CONSTRAINT [FK_ProfessorsTitles_Professors]
GO
ALTER TABLE [dbo].[ProfessorsTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsTitles_Titles] FOREIGN KEY([TitleId])
REFERENCES [dbo].[Titles] ([Id])
GO
ALTER TABLE [dbo].[ProfessorsTitles] CHECK CONSTRAINT [FK_ProfessorsTitles_Titles]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Courses]
GO
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Students]
GO
USE [master]
GO
ALTER DATABASE [SofiaUniversity] SET  READ_WRITE 
GO
