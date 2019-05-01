CREATE TABLE [dbo].[Module] (
    [Id]              INT IDENTITY (1, 1) NOT NULL,
    [CourseId]        INT NULL,
    [QuantityLessons] INT NULL,
    [TestId]          INT NULL,
    [IsDeleted]       BIT NULL,
    CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Module_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Module_Test] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Test] ([Id])
);



