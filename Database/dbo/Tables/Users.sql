CREATE TABLE [dbo].[Users]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Username] VARCHAR(65) NOT NULL,
	[PasswordHash] BINARY(64) NOT NULL,
	[PasswordSalt] BINARY(128) NOT NULL,
	[CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL
)
