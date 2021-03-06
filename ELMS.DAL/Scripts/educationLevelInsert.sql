USE [ELMS]
GO
SET IDENTITY_INSERT [StandardOptions].[EducationLevels] ON 

INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (1, N'Still In High School', 0, 1)
INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (2, N'Did Not Complete High School', 1, 1)
INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (3, N'Graduated High School', 2, 1)
INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (4, N'Received a GED', 3, 1)
INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (5, N'Associates Degree', 4, 1)
INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (6, N'Bachelors Degree', 5, 1)
INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (7, N'Masters Degree', 6, 1)
INSERT [StandardOptions].[EducationLevels] ([Id], [Name], [DisplayOrder], [Active]) VALUES (8, N'Doctorates Degree', 7, 1)
SET IDENTITY_INSERT [StandardOptions].[EducationLevels] OFF
