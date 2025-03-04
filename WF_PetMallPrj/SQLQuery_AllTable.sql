USE [MyDB]
GO
/****** Object:  Table [dbo].[FoodProducts]    Script Date: 2024/11/12 下午 04:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodProducts](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](255) NOT NULL,
	[Category] [nvarchar](100) NULL,
	[QuantityInStock] [int] NULL,
	[UnitPrice] [int] NOT NULL,
	[Brand] [nvarchar](100) NULL,
	[ReorderLevel] [int] NULL,
	[DateAdded] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[Description] [nvarchar](300) NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 2024/11/12 下午 04:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[Discount] [int] NULL,
	[TotalPrice] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2024/11/12 下午 04:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[OrderDate] [datetime] NULL,
	[TotalAmount] [int] NOT NULL,
	[ShippingAddress] [nvarchar](255) NULL,
	[PaymentMethod] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NOT NULL,
	[ShippingFee] [int] NULL,
	[Discount] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 2024/11/12 下午 04:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](300) NOT NULL,
	[Ingredient] [nvarchar](300) NOT NULL,
	[Nutrients] [nvarchar](300) NOT NULL,
	[LastUpdated] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImages]    Script Date: 2024/11/12 下午 04:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImages](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[ImageFilename] [nvarchar](255) NOT NULL,
	[IsPrimary] [bit] NULL,
	[DateAdded] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersInfo]    Script Date: 2024/11/12 下午 04:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserPhone] [nvarchar](15) NOT NULL,
	[UserEmail] [nvarchar](100) NOT NULL,
	[UserPassword] [nvarchar](100) NOT NULL,
	[CreateDate] [datetime] NULL,
	[UserRole] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FoodProducts] ON 
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (1, N'DoggyMan 犬用野菜棒 30g (南瓜)', N'狗零食', 48, 105, N'DoggyMan', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'不使用麵粉，無麩質零食。', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (2, N'DoggyMan 消臭餅乾 80克 (起司動物造型)', N'狗零食', 40, 105, N'DoggyMan', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'濃郁牛奶風味，酥脆口感，嗜口性佳 ', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (3, N'貪貪 貓高蛋白肉泥 13g 4入 (原野鮮雞)', N'貓零食', 49, 105, N'貪貪', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'蜂王胎+高蛋白，美味機能一次滿足！', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (4, N'貪貪 貓高蛋白肉泥 13g 4入 (極鮮虱目魚)', N'貓零食', 50, 105, N'貪貪', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'貪貪首度跨界聯名蜂之鄉！', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (5, N'CHARM 貓副食罐頭 80g 6入 (鮪魚佐蟹味棒)', N'貓副食罐', 25, 246, N'CHARM', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'CHARM野性魅力特級貓罐給喵喵優質的營養！', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (6, N'CHARM 貓飼料 340g (幼貓配方)', N'貓飼料', 19, 300, N'CHARM', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'100%無穀低敏配方，不含小麥、玉米或大豆等穀類，降低消化負擔。', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (7, N'CHARM 狗飼料 2kg (海陸盛宴)', N'狗飼料', 9, 1780, N'CHARM', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'90%優質蛋白好吸收，提供多種肉類營養，均衡豐沛。', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (8, N'CHARM 狗飼料 340g (幼犬配方)', N'狗飼料', 10, 270, N'CHARM', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'100%無穀低敏配方，不含小麥、玉米或大豆等穀類，降低消化負擔。', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (9, N'極光 狗飼料 15磅 (雞肉 & 鴨肉)', N'狗飼料', 10, 2450, N'極光', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'適合全齡犬。', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (10, N'極光 狗飼料 1磅 (低脂羊肉)', N'狗飼料', 15, 250, N'極光', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'適合全齡犬。', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (11, N'極光 貓飼料 1磅 (雞肉 & 鮭魚)', N'貓飼料', 4, 250, N'極光', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'適合全齡貓、室內貓。', 1)
GO
INSERT [dbo].[FoodProducts] ([ProductID], [ProductName], [Category], [QuantityInStock], [UnitPrice], [Brand], [ReorderLevel], [DateAdded], [LastUpdated], [Description], [IsActive]) VALUES (12, N'極光 貓飼料 4磅 (雞肉)', N'貓飼料', 10, 980, N'極光', 0, CAST(N'2024-11-04T08:55:47.580' AS DateTime), CAST(N'2024-11-04T08:55:47.580' AS DateTime), N'適合全齡貓。', 1)
GO
SET IDENTITY_INSERT [dbo].[FoodProducts] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (1, 1, 3, 1, 105, 0, 105)
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (2, 1, 7, 1, 1780, 0, 1780)
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (3, 1, 11, 1, 250, 0, 250)
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (4, 2, 1, 1, 105, 0, 105)
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (5, 3, 1, 1, 105, 0, 105)
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (6, 3, 6, 1, 300, 0, 300)
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (7, 4, 2, 10, 105, 0, 1050)
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [TotalAmount], [ShippingAddress], [PaymentMethod], [Status], [ShippingFee], [Discount], [CreatedAt], [UpdatedAt]) VALUES (1, 1, CAST(N'2024-11-07T08:42:27.820' AS DateTime), 2195, NULL, N'信用卡', N'待付款', 60, NULL, CAST(N'2024-11-07T08:42:27.820' AS DateTime), CAST(N'2024-11-07T08:42:27.820' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [TotalAmount], [ShippingAddress], [PaymentMethod], [Status], [ShippingFee], [Discount], [CreatedAt], [UpdatedAt]) VALUES (2, 1, CAST(N'2024-11-07T10:05:08.620' AS DateTime), 165, NULL, N'信用卡', N'待付款', 60, NULL, CAST(N'2024-11-07T10:05:08.620' AS DateTime), CAST(N'2024-11-07T10:05:08.620' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [TotalAmount], [ShippingAddress], [PaymentMethod], [Status], [ShippingFee], [Discount], [CreatedAt], [UpdatedAt]) VALUES (3, 1, CAST(N'2024-11-07T11:37:12.990' AS DateTime), 465, NULL, N'信用卡', N'待付款', 60, NULL, CAST(N'2024-11-07T11:37:12.990' AS DateTime), CAST(N'2024-11-07T11:37:12.990' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [TotalAmount], [ShippingAddress], [PaymentMethod], [Status], [ShippingFee], [Discount], [CreatedAt], [UpdatedAt]) VALUES (4, 1, CAST(N'2024-11-07T11:38:11.440' AS DateTime), 1110, NULL, N'信用卡', N'待付款', 60, NULL, CAST(N'2024-11-07T11:38:11.440' AS DateTime), CAST(N'2024-11-07T11:38:11.440' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[ProductDetails] ([ProductID], [ProductName], [Description], [Ingredient], [Nutrients], [LastUpdated]) VALUES (1, N'DoggyMan 犬用野菜棒 30g (南瓜)', N'商品介紹測試', N'成份顯示測試', N'營養分析顯示測試', CAST(N'2024-11-11T11:32:24.857' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ProductImages] ON 
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (1, 1, N'DoggyMan犬用野菜棒(南瓜).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (2, 2, N'DoggyMan消臭餅乾(起司).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (3, 3, N'貪貪高蛋白貓肉泥(原野鮮雞).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (4, 4, N'貪貪高蛋白貓肉泥(極鮮虱目魚).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (5, 5, N'CHARM貓副食罐(鮪魚蟹味棒).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (6, 6, N'CHARM貓飼料(幼貓配方).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (7, 7, N'CHARM狗飼料(海陸盛宴).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (8, 8, N'CHARM狗飼料(幼犬配方).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (9, 9, N'極光狗飼料(雞肉鴨肉).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (10, 10, N'極光狗飼料(羊肉).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (11, 11, N'極光貓飼料(雞肉).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (12, 12, N'極光貓飼料(雞肉鮭魚).png', 1, CAST(N'2024-11-04T08:56:11.100' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (13, 1, N'PID1_2.png', 0, CAST(N'2024-11-11T11:42:36.407' AS DateTime))
GO
INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImageFilename], [IsPrimary], [DateAdded]) VALUES (14, 1, N'PID1_N.png', 0, CAST(N'2024-11-11T11:42:47.583' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ProductImages] OFF
GO
SET IDENTITY_INSERT [dbo].[UsersInfo] ON 
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (1, N'AdminUser1', N'0988877700', N'adminuser@gmail.com', N'AdminUser0', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 0)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (2, N'Manager1', N'0911166600', N'manager1@gmail.com', N'Manager11', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 1)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (3, N'Manager2', N'0922288800', N'manager2@gmail.com', N'Manager21', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 1)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (4, N'Staff1', N'0923423466', N'staff1@gmail.com', N'Staff12', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 2)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (5, N'Staff2', N'0945645600', N'staff2@gmail.com', N'Staff22', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 2)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (6, N'Staff3', N'0962039389', N'staff3@gmail.com', N'Staff32', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 2)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (7, N'JohnDoe', N'0912345678', N'JohnDoe@gmail.com', N'JohnDoe5', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 5)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (8, N'JaneSmith', N'0923456789', N'JaneSmith@gmail.com', N'JaneSmith5', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 5)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (9, N'MichaelJohnson', N'0934567890', N'MichaelJohnson@gmail.com', N'MichaelJohnson5', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 5)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (10, N'EmilyDavis', N'0945678901', N'EmilyDavis@gmail.com', N'EmilyDavis5', CAST(N'2024-11-01T09:04:17.913' AS DateTime), 5)
GO
INSERT [dbo].[UsersInfo] ([Id], [UserName], [UserPhone], [UserEmail], [UserPassword], [CreateDate], [UserRole]) VALUES (12, N'123@123.com', N'0955123123', N'123@123.com', N'Qerqw130', CAST(N'2024-11-04T15:05:21.047' AS DateTime), 5)
GO
SET IDENTITY_INSERT [dbo].[UsersInfo] OFF
GO
/****** Object:  Index [UQ__OrderDet__D3B9D30D05E5024B]    Script Date: 2024/11/12 下午 04:17:20 ******/
ALTER TABLE [dbo].[OrderDetails] ADD UNIQUE NONCLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__UsersInf__08638DF8EE9AB0F9]    Script Date: 2024/11/12 下午 04:17:20 ******/
ALTER TABLE [dbo].[UsersInfo] ADD UNIQUE NONCLUSTERED 
(
	[UserEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__UsersInf__F2577C47B552A5F9]    Script Date: 2024/11/12 下午 04:17:20 ******/
ALTER TABLE [dbo].[UsersInfo] ADD UNIQUE NONCLUSTERED 
(
	[UserPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FoodProducts] ADD  DEFAULT ((0)) FOR [QuantityInStock]
GO
ALTER TABLE [dbo].[FoodProducts] ADD  DEFAULT ((0)) FOR [ReorderLevel]
GO
ALTER TABLE [dbo].[FoodProducts] ADD  DEFAULT (getdate()) FOR [DateAdded]
GO
ALTER TABLE [dbo].[FoodProducts] ADD  DEFAULT (getdate()) FOR [LastUpdated]
GO
ALTER TABLE [dbo].[FoodProducts] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [dbo].[ProductDetails] ADD  DEFAULT (getdate()) FOR [LastUpdated]
GO
ALTER TABLE [dbo].[ProductImages] ADD  DEFAULT ((0)) FOR [IsPrimary]
GO
ALTER TABLE [dbo].[ProductImages] ADD  DEFAULT (getdate()) FOR [DateAdded]
GO
ALTER TABLE [dbo].[UsersInfo] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[UsersInfo]  WITH CHECK ADD CHECK  (([UserRole]>=(0) AND [UserRole]<=(10)))
GO
