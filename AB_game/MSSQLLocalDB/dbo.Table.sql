CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NULL, 
    [mode] VARCHAR(50) NULL, 
    [date] DATE NULL, 
    [time] TIME NULL, 
    [tries] INT NULL, 
    [seconds] INT NULL, 
    [secretNum] INT NULL, 
    [guessNum] INT NULL, 
    [guessHint] VARCHAR(5) NULL, 
    [score] NCHAR(10) NULL
)
