CREATE TABLE [db_owner].[Blodtryk] (
    [Systole]  INT      NOT NULL,
    [Diastole] INT      NOT NULL,
	[Tid]      DATETIME primary key,
    [Puls] INT NOT NULL, 
	[CPR] NCHAR(11) FOREIGN KEY REFERENCES [db_owner].[Personer] (CPR)
);