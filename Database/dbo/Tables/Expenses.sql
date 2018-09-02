CREATE TABLE [dbo].[Expenses] (
    [ExpenseId]   UNIQUEIDENTIFIER NOT NULL,
    [Date]        DATETIME         NOT NULL,
    [Amount]      DECIMAL (9, 2)   NOT NULL,
    [Description] NVARCHAR (2000)  NULL,
    PRIMARY KEY CLUSTERED ([ExpenseId] ASC)
);

