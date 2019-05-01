CREATE TABLE [dbo].[TestPassing] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [StudentId] INT      NULL,
    [TestId]    INT      NOT NULL,
    [TeacherId] INT      NULL,
    [Date]      DATETIME NULL,
    [IsDeleted] BIT      NULL,
    CONSTRAINT [PK_TestPassing] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TestPassing_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id]),
    CONSTRAINT [FK_TestPassing_Teacher] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([Id]),
    CONSTRAINT [FK_TestPassing_Test] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Test] ([Id])
);



