USE [ELMS]
GO
/****** Object:  Table [StandardOptions].[States]    Script Date: 3/18/2016 1:03:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [StandardOptions].[States](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Abbreviation] [nvarchar](max) NULL,
	[CountryId] [int] NOT NULL,
	[Active] [bit] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_StandardOptions.States] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [StandardOptions].[States] ON 

INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (2, N'Alabama', N'AL', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (3, N'Alaska', N'AK', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (4, N'Arizona', N'AZ', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (5, N'Arkansas', N'AR', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (6, N'California', N'CA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (7, N'Colorado', N'CO', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (8, N'Connecticut', N'CT', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (9, N'Delaware', N'DE', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (10, N'Florida', N'FL', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (11, N'Georgia', N'GA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (12, N'Hawaii', N'HI', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (13, N'Idaho', N'ID', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (14, N'Illinois', N'IL', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (15, N'Indiana', N'IN', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (16, N'Iowa', N'IA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (17, N'Kansas', N'KS', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (18, N'Kentucky', N'KY', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (19, N'Louisiana', N'LA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (20, N'Maine', N'ME', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (21, N'Maryland', N'MD', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (22, N'Massachusetts', N'MA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (23, N'Michigan', N'MI', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (24, N'Minnesota', N'MN', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (25, N'Mississippi', N'MS', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (26, N'Missouri', N'MO', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (27, N'Montana', N'MT', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (28, N'Nebraska', N'NE', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (29, N'Nevada', N'NV', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (30, N'New Hampshire', N'NH', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (31, N'New Jersey', N'NJ', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (32, N'New Mexico', N'NM', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (33, N'New York', N'NY', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (34, N'North Carolina', N'NC', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (35, N'North Dakota', N'ND', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (36, N'Ohio', N'OH', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (37, N'Oklahoma', N'OK', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (38, N'Oregon', N'OR', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (39, N'Pennsylvania', N'PA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (40, N'Rhode Island', N'RI', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (41, N'South Carolina', N'SC', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (42, N'South Dakota', N'SD', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (43, N'Tennessee', N'TN', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (44, N'Texas', N'TX', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (45, N'Utah', N'UT', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (46, N'Vermont', N'VT', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (47, N'Virginia', N'VA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (48, N'Washington', N'WA', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (49, N'West Virginia', N'WV', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (50, N'Wisconsin', N'WI', 236, 1)
INSERT [StandardOptions].[States] ([Id], [Name], [Abbreviation], [CountryId], [Active]) VALUES (51, N'Wyoming', N'WY', 236, 1)
SET IDENTITY_INSERT [StandardOptions].[States] OFF
ALTER TABLE [StandardOptions].[States]  WITH CHECK ADD  CONSTRAINT [FK_StandardOptions.States_StandardOptions.Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [StandardOptions].[Countries] ([Id])
GO
ALTER TABLE [StandardOptions].[States] CHECK CONSTRAINT [FK_StandardOptions.States_StandardOptions.Countries_CountryId]
GO
