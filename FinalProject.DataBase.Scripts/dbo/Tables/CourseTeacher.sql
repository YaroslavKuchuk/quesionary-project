CREATE TABLE [dbo].[CourseTeacher] (
    [TeacherId] INT NOT NULL,
    [CourseId]  INT NOT NULL,
    CONSTRAINT [PK_CourseTeacher] PRIMARY KEY CLUSTERED ([TeacherId] ASC, [CourseId] ASC),
    CONSTRAINT [FK_CourseTeacher_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_CourseTeacher_Teacher] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([Id])
);

