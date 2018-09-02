CREATE TABLE [dbo].[EmailCommunication] (
    [EmailCommunicationId] UNIQUEIDENTIFIER NOT NULL,
    [Email]                NVARCHAR (50)    NOT NULL,
    [CreatedBy]            UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]      DATETIME         NOT NULL,
    [ModifiedBy]           UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified]     DATETIME         NOT NULL,
    [IsDeleted]            BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmailCommunicationId] ASC)
);

