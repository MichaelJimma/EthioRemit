CREATE TABLE [dbo].[Status] (
    [StatusId]         UNIQUEIDENTIFIER NOT NULL,
    [Name]             NVARCHAR (150)   NOT NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([StatusId] ASC)
);

