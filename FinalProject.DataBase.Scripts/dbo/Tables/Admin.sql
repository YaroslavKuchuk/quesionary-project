CREATE TABLE [dbo].[Admin] (
    [Id]        INT NOT NULL,
    [UserId]    INT NULL,
    [IsDeleted] BIT NULL,
    CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Admin_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);



