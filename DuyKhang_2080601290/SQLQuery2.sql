/****** Script for SelectTopNRows command from SSMS  ******/
SELECT * FROM Categories
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [BigSchool].[dbo].[Categories]