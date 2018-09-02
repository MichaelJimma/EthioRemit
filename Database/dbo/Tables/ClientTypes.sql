CREATE TABLE [dbo].[ClientTypes] (
    [ClientTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [Name]             NVARCHAR (200)   NOT NULL,
    [Description]      NVARCHAR (2000)  NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ClientTypeId] ASC)
);

