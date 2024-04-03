# SematicBackUp MSSQL

Create Database SemanticBackup
USE [SemanticBackup]
GO

/****** Object:  Table [dbo].[History]    Script Date: 2024/04/03 12:31:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SignUp](
	[Email_Address] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Email_Address] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[History](
	[Email_Address] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[Path] [nvarchar](max) NULL,
	[Size] [int] NULL,
	[Date] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[History]  WITH CHECK ADD FOREIGN KEY([Email_Address])
REFERENCES [dbo].[SignUp] ([Email_Address])
GO



 
