﻿CREATE TABLE [dbo].[Users]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[PasswordHash] BINARY(512) NOT NULL,
	[PasswordSalt] BINARY(512) NOT NULL,

)
