CREATE TABLE [dbo].[OrderStatus] (
    [OrderStatusId]    UNIQUEIDENTIFIER NOT NULL,
    [OrderId]          UNIQUEIDENTIFIER NOT NULL,
    [StatusId]         UNIQUEIDENTIFIER NOT NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderStatusId] ASC),
    CONSTRAINT [FK_OrderStatus_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]),
    CONSTRAINT [FK_OrderStatus_Status] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([StatusId])
);

