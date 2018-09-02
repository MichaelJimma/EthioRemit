CREATE TABLE [dbo].[StatusDetails] (
    [StatusDetailId]   UNIQUEIDENTIFIER NOT NULL,
    [StatusId]         UNIQUEIDENTIFIER NOT NULL,
    [Detail]           NVARCHAR (500)   NOT NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([StatusDetailId] ASC),
    CONSTRAINT [FK_Status_StatusDetail] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([StatusId])
);

