CREATE [MusicApp]
USE [MusicApp]
GO
/****** Object:  Table [dbo].[Baihat]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Baihat](
	[IdBaihat] [int] IDENTITY(1,1) NOT NULL,
	[Tenbaihat] [nvarchar](255) NOT NULL,
	[Link] [varchar](255) NOT NULL,
	[Luotxem] [int] NOT NULL,
	[Lyrics] [nvarchar](max) NOT NULL,
	[Anhbaihat] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Baihat__4A742C1A7848B092] PRIMARY KEY CLUSTERED 
(
	[IdBaihat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Casi]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Casi](
	[IdCasi] [int] IDENTITY(1,1) NOT NULL,
	[Tencasi] [nvarchar](255) NOT NULL,
	[Nghedanh] [nvarchar](255) NOT NULL,
	[AnhCasi] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Casi__3B7B2B26B8C3B1A5] PRIMARY KEY CLUSTERED 
(
	[IdCasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChitietBaihat]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietBaihat](
	[IdBaihat] [int] NOT NULL,
	[IdCasi] [int] NOT NULL,
 CONSTRAINT [PK_ChitietBaihat] PRIMARY KEY CLUSTERED 
(
	[IdCasi] ASC,
	[IdBaihat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChitietPlayList]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietPlayList](
	[IdPlayList] [int] NOT NULL,
	[IdBaihat] [int] NOT NULL,
 CONSTRAINT [PK_ChitietPlayList] PRIMARY KEY CLUSTERED 
(
	[IdPlayList] ASC,
	[IdBaihat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChitietTheloai]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietTheloai](
	[IdTheloai] [int] NOT NULL,
	[IdBaihat] [int] NOT NULL,
 CONSTRAINT [PK_ChitietTheloai] PRIMARY KEY CLUSTERED 
(
	[IdTheloai] ASC,
	[IdBaihat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PlayList]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayList](
	[IdPlayList] [int] IDENTITY(1,1) NOT NULL,
	[TenPlayList] [nvarchar](255) NOT NULL,
	[Idtaikhoan] [varchar](50) NOT NULL,
 CONSTRAINT [PK__PlayList__663CEF5EBB04A856] PRIMARY KEY CLUSTERED 
(
	[IdPlayList] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[IdTaikhoan] [varchar](50) NOT NULL,
	[Matkhau] [varchar](255) NOT NULL,
	[Tennguoidung] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__Taikhoan__99B296A3B492EFDB] PRIMARY KEY CLUSTERED 
(
	[IdTaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Theloai]    Script Date: 12/29/2021 6:27:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Theloai](
	[IdTheloai] [int] IDENTITY(1,1) NOT NULL,
	[TenTheloai] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__Theloai__9A190A17423B2CA9] PRIMARY KEY CLUSTERED 
(
	[IdTheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChitietBaihat]  WITH CHECK ADD  CONSTRAINT [FK__ChitietBa__IdBai__239E4DCF] FOREIGN KEY([IdBaihat])
REFERENCES [dbo].[Baihat] ([IdBaihat])
GO
ALTER TABLE [dbo].[ChitietBaihat] CHECK CONSTRAINT [FK__ChitietBa__IdBai__239E4DCF]
GO
ALTER TABLE [dbo].[ChitietBaihat]  WITH CHECK ADD  CONSTRAINT [FK__ChitietBa__IdCas__24927208] FOREIGN KEY([IdCasi])
REFERENCES [dbo].[Casi] ([IdCasi])
GO
ALTER TABLE [dbo].[ChitietBaihat] CHECK CONSTRAINT [FK__ChitietBa__IdCas__24927208]
GO
ALTER TABLE [dbo].[ChitietPlayList]  WITH CHECK ADD  CONSTRAINT [FK__ChitietLi__IdBai__1ED998B2] FOREIGN KEY([IdBaihat])
REFERENCES [dbo].[Baihat] ([IdBaihat])
GO
ALTER TABLE [dbo].[ChitietPlayList] CHECK CONSTRAINT [FK__ChitietLi__IdBai__1ED998B2]
GO
ALTER TABLE [dbo].[ChitietPlayList]  WITH CHECK ADD  CONSTRAINT [FK__ChitietLi__Idlis__1DE57479] FOREIGN KEY([IdPlayList])
REFERENCES [dbo].[PlayList] ([IdPlayList])
GO
ALTER TABLE [dbo].[ChitietPlayList] CHECK CONSTRAINT [FK__ChitietLi__Idlis__1DE57479]
GO
ALTER TABLE [dbo].[ChitietTheloai]  WITH CHECK ADD  CONSTRAINT [FK__ChitietTh__IdBai__1B0907CE] FOREIGN KEY([IdBaihat])
REFERENCES [dbo].[Baihat] ([IdBaihat])
GO
ALTER TABLE [dbo].[ChitietTheloai] CHECK CONSTRAINT [FK__ChitietTh__IdBai__1B0907CE]
GO
ALTER TABLE [dbo].[ChitietTheloai]  WITH CHECK ADD  CONSTRAINT [FK__ChitietTh__IdThe__1A14E395] FOREIGN KEY([IdTheloai])
REFERENCES [dbo].[Theloai] ([IdTheloai])
GO
ALTER TABLE [dbo].[ChitietTheloai] CHECK CONSTRAINT [FK__ChitietTh__IdThe__1A14E395]
GO
ALTER TABLE [dbo].[PlayList]  WITH CHECK ADD  CONSTRAINT [FK_PlayList_Taikhoan] FOREIGN KEY([Idtaikhoan])
REFERENCES [dbo].[Taikhoan] ([IdTaikhoan])
GO
ALTER TABLE [dbo].[PlayList] CHECK CONSTRAINT [FK_PlayList_Taikhoan]
GO
