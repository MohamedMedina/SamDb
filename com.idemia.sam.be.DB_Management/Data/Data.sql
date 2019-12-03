﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [SAM_DB]

--[Lookups].[RequestType]
GO
DELETE FROM [Lookups].[RequestType]
GO
SET IDENTITY_INSERT [Lookups].[RequestType] ON 

INSERT [Lookups].[RequestType] ([Id], [name], [nameAr]) VALUES (1, N'RequestType', N'نوع الطلب ')
INSERT [Lookups].[RequestType] ([Id], [name], [nameAr]) VALUES (2, N'RequestType', N'نوع الطلب ')
INSERT [Lookups].[RequestType] ([Id], [name], [nameAr]) VALUES (3, N'RequestType', N'نوع الطلب ')
INSERT [Lookups].[RequestType] ([Id], [name], [nameAr]) VALUES (4, N'RequestType', N'نوع الطلب ')
INSERT [Lookups].[RequestType] ([Id], [name], [nameAr]) VALUES (5, N'RequestType', N'نوع الطلب ')

SET IDENTITY_INSERT [Lookups].[RequestType] OFF

--[Lookups].[RequestStatus]
GO
DELETE FROM [Lookups].[RequestStatus]
GO
SET IDENTITY_INSERT [Lookups].[RequestStatus] ON 

INSERT [Lookups].[RequestStatus] ([Id], [name], [nameAr]) VALUES (1, N'RequestStatus', N'حالة الطلب ')
INSERT [Lookups].[RequestStatus] ([Id], [name], [nameAr]) VALUES (2, N'RequestStatus', N'حالة الطلب ')
INSERT [Lookups].[RequestStatus] ([Id], [name], [nameAr]) VALUES (3, N'RequestStatus', N'حالة الطلب ')
INSERT [Lookups].[RequestStatus] ([Id], [name], [nameAr]) VALUES (4, N'RequestStatus', N'حالة الطلب ')
INSERT [Lookups].[RequestStatus] ([Id], [name], [nameAr]) VALUES (5, N'RequestStatus', N'حالة الطلب ')

SET IDENTITY_INSERT [Lookups].[RequestStatus] OFF

--[Lookups].[RequestPriority]
GO
DELETE FROM [Lookups].[RequestPriority]
GO
SET IDENTITY_INSERT [Lookups].[RequestPriority] ON 

INSERT [Lookups].[RequestPriority] ([Id], [name], [nameAr]) VALUES (1, N'RequestPriority', N'أولوية الطلب ')
INSERT [Lookups].[RequestPriority] ([Id], [name], [nameAr]) VALUES (2, N'RequestPriority', N'أولوية الطلب ')
INSERT [Lookups].[RequestPriority] ([Id], [name], [nameAr]) VALUES (3, N'RequestPriority', N'أولوية الطلب ')
INSERT [Lookups].[RequestPriority] ([Id], [name], [nameAr]) VALUES (4, N'RequestPriority', N'أولوية الطلب ')
INSERT [Lookups].[RequestPriority] ([Id], [name], [nameAr]) VALUES (5, N'RequestPriority', N'أولوية الطلب ')

SET IDENTITY_INSERT [Lookups].[RequestPriority] OFF

--[Lookups].[RequestClass]
GO
DELETE FROM [Lookups].[RequestClass]
GO
SET IDENTITY_INSERT [Lookups].[RequestClass] ON 

INSERT [Lookups].[RequestClass] ([Id], [name], [nameAr]) VALUES (1, N'RequestClass', N'تصنيف الطلب ')
INSERT [Lookups].[RequestClass] ([Id], [name], [nameAr]) VALUES (2, N'RequestClass', N'تصنيف الطلب ')
INSERT [Lookups].[RequestClass] ([Id], [name], [nameAr]) VALUES (3, N'RequestClass', N'تصنيف الطلب ')
INSERT [Lookups].[RequestClass] ([Id], [name], [nameAr]) VALUES (4, N'RequestClass', N'تصنيف الطلب ')
INSERT [Lookups].[RequestClass] ([Id], [name], [nameAr]) VALUES (5, N'RequestClass', N'تصنيف الطلب ')

SET IDENTITY_INSERT [Lookups].[RequestClass] OFF

--[Lookups].[RejectReason]
GO
DELETE FROM [Lookups].[RejectReason]
GO
SET IDENTITY_INSERT [Lookups].[RejectReason] ON 

INSERT [Lookups].[RejectReason] ([Id], [name], [nameAr]) VALUES (1, N'RejectReason', N'سبب الرفض')
INSERT [Lookups].[RejectReason] ([Id], [name], [nameAr]) VALUES (2, N'RejectReason', N'سبب الرفض')
INSERT [Lookups].[RejectReason] ([Id], [name], [nameAr]) VALUES (3, N'RejectReason', N'سبب الرفض')
INSERT [Lookups].[RejectReason] ([Id], [name], [nameAr]) VALUES (4, N'RejectReason', N'سبب الرفض')
INSERT [Lookups].[RejectReason] ([Id], [name], [nameAr]) VALUES (5, N'RejectReason', N'سبب الرفض')

SET IDENTITY_INSERT [Lookups].[RejectReason] OFF

--[Lookups].[CardType]
GO
DELETE FROM [Lookups].[CardType]
GO
SET IDENTITY_INSERT [Lookups].[CardType] ON 

INSERT [Lookups].[CardType] ([Id], [name], [nameAr]) VALUES (1, N'CardType', N'نوع البطاقة')
INSERT [Lookups].[CardType] ([Id], [name], [nameAr]) VALUES (2, N'CardType', N'نوع البطاقة')
INSERT [Lookups].[CardType] ([Id], [name], [nameAr]) VALUES (3, N'CardType', N'نوع البطاقة')
INSERT [Lookups].[CardType] ([Id], [name], [nameAr]) VALUES (4, N'CardType', N'نوع البطاقة')
INSERT [Lookups].[CardType] ([Id], [name], [nameAr]) VALUES (5, N'CardType', N'نوع البطاقة')

SET IDENTITY_INSERT [Lookups].[CardType] OFF

--[Lookups].[CardValidity]
GO
DELETE FROM [Lookups].[CardValidity]
GO
SET IDENTITY_INSERT [Lookups].[CardValidity] ON 

INSERT [Lookups].[CardValidity] ([Id], [name], [nameAr]) VALUES (1, N'CardValidity', N'صلاحية البطاقة')
INSERT [Lookups].[CardValidity] ([Id], [name], [nameAr]) VALUES (2, N'CardValidity', N'صلاحية البطاقة')
INSERT [Lookups].[CardValidity] ([Id], [name], [nameAr]) VALUES (3, N'CardValidity', N'صلاحية البطاقة')
INSERT [Lookups].[CardValidity] ([Id], [name], [nameAr]) VALUES (4, N'CardValidity', N'صلاحية البطاقة')
INSERT [Lookups].[CardValidity] ([Id], [name], [nameAr]) VALUES (5, N'CardValidity', N'صلاحية البطاقة')

SET IDENTITY_INSERT [Lookups].[CardValidity] OFF

--[Lookups].[WorkField]
GO
DELETE FROM [Lookups].[WorkField]
GO
SET IDENTITY_INSERT [Lookups].[WorkField] ON 

INSERT [Lookups].[WorkField] ([Id], [name], [nameAr]) VALUES (3, N'WorkField', N'مجال العمل')
INSERT [Lookups].[WorkField] ([Id], [name], [nameAr]) VALUES (4, N'WorkField', N'مجال العمل')
INSERT [Lookups].[WorkField] ([Id], [name], [nameAr]) VALUES (5, N'WorkField', N'مجال العمل')
INSERT [Lookups].[WorkField] ([Id], [name], [nameAr]) VALUES (1, N'WorkField', N'مجال العمل')
INSERT [Lookups].[WorkField] ([Id], [name], [nameAr]) VALUES (2, N'WorkField', N'مجال العمل')

SET IDENTITY_INSERT [Lookups].[WorkField] OFF