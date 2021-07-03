USE [OfficeManagementSystem]
GO

/****** Object:  Table [dbo].[Projects]    Script Date: 7/3/2021 11:35:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Projects](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ManagerNID] [varchar](50) NULL,
	[title] [varchar](50) NULL,
	[description] [varchar](50) NULL,
	[tag] [varchar](50) NULL,
	[duration] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[StartingTime] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


