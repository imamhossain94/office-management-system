USE [OfficeManagementSystem]
GO

/****** Object:  Table [dbo].[EmployeeAttendence]    Script Date: 7/3/2021 11:34:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeAttendence](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](50) NULL,
	[Employee_NID] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Time] [varchar](50) NULL,
	[Brunch_Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


