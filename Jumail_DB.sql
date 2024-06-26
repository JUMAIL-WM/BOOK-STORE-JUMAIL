USE [jml]
GO
/****** Object:  Table [dbo].[Add_Expence_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Add_Expence_Table](
	[Expence_Title] [nvarchar](50) NOT NULL,
	[Amount] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Add_Expence_Table] PRIMARY KEY CLUSTERED 
(
	[Expence_Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Add_NewBook_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Add_NewBook_Table](
	[Tracking_ID] [nvarchar](50) NOT NULL,
	[Author] [nvarchar](50) NULL,
	[Publisher] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[Selling_Price] [nvarchar](50) NULL,
	[Remarks] [nvarchar](50) NULL,
	[Book_Title] [nvarchar](50) NULL,
	[Date] [date] NULL,
	[Cost_Price] [nvarchar](50) NULL,
	[Bar_Code] [nvarchar](50) NULL,
 CONSTRAINT [PK_Add_NewBook_Table] PRIMARY KEY CLUSTERED 
(
	[Tracking_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Add_Stock_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Add_Stock_Table](
	[Tracking_ID] [nvarchar](50) NOT NULL,
	[Existing_Stock] [nvarchar](50) NULL,
	[New_Stock] [nvarchar](50) NULL,
	[Total_Stock] [nvarchar](50) NULL,
	[Cost] [nvarchar](50) NULL,
	[Selling_Price] [nvarchar](50) NULL,
 CONSTRAINT [PK_Add_Stock_Table] PRIMARY KEY CLUSTERED 
(
	[Tracking_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Finish_Order_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Finish_Order_Table](
	[ID] [nvarchar](50) NOT NULL,
	[Net_Amount] [nvarchar](50) NULL,
	[Discount] [nvarchar](50) NULL,
	[Total_Amount] [nvarchar](50) NULL,
	[Paid_Amount] [nvarchar](50) NULL,
	[Balance_Amount] [nvarchar](50) NULL,
 CONSTRAINT [PK_Finish_Order_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_Table](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Login_Table] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UC_ManageExpence_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UC_ManageExpence_Table](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Expence_Title] [nvarchar](50) NULL,
	[Amount] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_UC_ManageExpence_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UC_ManageUser_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UC_ManageUser_Table](
	[User_Id] [nvarchar](50) NOT NULL,
	[Full_Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[NIC] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[User_Name] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
 CONSTRAINT [PK_UC_ManageUser_Table] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UC_Sales_Table]    Script Date: 1/14/2023 9:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UC_Sales_Table](
	[Bar_Code] [nvarchar](50) NOT NULL,
	[Book_Title] [nvarchar](50) NULL,
	[Publisher] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
	[Tracking_ID] [nvarchar](50) NULL,
	[Author] [nvarchar](50) NULL,
	[Discount] [nvarchar](50) NULL,
 CONSTRAINT [PK_UC_Sales_Table] PRIMARY KEY CLUSTERED 
(
	[Bar_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
