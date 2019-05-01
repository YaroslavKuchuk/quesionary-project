CREATE TABLE [dbo].[Student] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [UserId]    INT NULL,
    [IsDeleted] BIT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);



