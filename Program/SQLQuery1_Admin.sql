SELECT TOP (1000) [AdminID]
      ,[UserName]
      ,[Password]
      ,[FullName]
      ,[Email]
      ,[Contact]
      ,[ImagePath]
  FROM [Fitness_Tracker_DB].[dbo].[Admin]

  Delete from Admin;