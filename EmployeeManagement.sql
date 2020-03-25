CREATE Database EmployeeManagement

USE [EmployeeManagement]
GO

/****** Object:  Table [dbo].[RoleDetails]    Script Date: 3/25/2020 2:06:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RoleDetails](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_RoleDetails] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO [dbo].[RoleDetails]
([RoleName],[CreatedDate],[UpdatedDate])
VALUES ('Admin', GETDATE(), GETDATE());

INSERT INTO [dbo].[RoleDetails]
([RoleName],[CreatedDate],[UpdatedDate])
VALUES ('Supervisor', GETDATE(), GETDATE());

INSERT INTO [dbo].[RoleDetails]
([RoleName],[CreatedDate],[UpdatedDate])
VALUES ('Agent', GETDATE(), GETDATE());

/****** Object:  Table [dbo].[UserDetails]    Script Date: 3/25/2020 2:06:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserDetails](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[RoleId] [int] NOT NULL,
	[Status] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
