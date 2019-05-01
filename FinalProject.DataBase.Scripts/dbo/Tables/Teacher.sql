CREATE TABLE [dbo].[Teacher] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [UserId]    INT NULL,
    [IsDeleted] BIT NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Teacher_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);



