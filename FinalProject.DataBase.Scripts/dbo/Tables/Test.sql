CREATE TABLE [dbo].[Test] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [CourseId]  INT NULL,
    [IsDeleted] BIT NULL,
    CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Test_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id])
);



