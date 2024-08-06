SELECT TOP (1000) [GoalID]
      ,[MemberID]
      ,[TargetWeightLoss]
      ,[TargetCalories]
      ,[StartDate]
      ,[EndDate]
      ,[Duration]
  FROM [Fitness_Tracker_DB].[dbo].[Goal]

  Delete from Goal;

  