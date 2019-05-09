CREATE TABLE [dbo].[User] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [UserTypeId] INT            NOT NULL,
    [FirstName]  NVARCHAR (MAX) NOT NULL,
    [LastName]   NVARCHAR (MAX) NOT NULL,
    [Login]      NVARCHAR (450) NOT NULL,
    [Password]   NVARCHAR (MAX) NOT NULL,
    [IsDeleted]  BIT            NULL,
    CONSTRAINT [PK_User1] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserTypeId]) REFERENCES [dbo].[UserType] ([Id]),
    CONSTRAINT [U_Login] UNIQUE NONCLUSTERED ([Login] ASC)
);









