CREATE TABLE [dbo].[Clients] (
    [ClientId]         UNIQUEIDENTIFIER NOT NULL,
    [AgentCode]        NVARCHAR (50)    NOT NULL,
    [Name]             NVARCHAR (250)   NOT NULL,
    [Address]          NVARCHAR (2000)  NULL,
    [Phone]            NVARCHAR (15)    NULL,
    [ClientTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [IsActive]         BIT              DEFAULT ((1)) NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ClientId] ASC),
    CONSTRAINT [FK_Agents_ClientTypes] FOREIGN KEY ([ClientTypeId]) REFERENCES [dbo].[ClientTypes] ([ClientTypeId])
);

