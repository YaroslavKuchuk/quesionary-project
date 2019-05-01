CREATE TABLE [dbo].[TeacherGroup] (
    [TeacherId] INT NOT NULL,
    [GroupId]   INT NOT NULL,
    CONSTRAINT [PK_TeacherGroup] PRIMARY KEY CLUSTERED ([TeacherId] ASC, [GroupId] ASC),
    CONSTRAINT [FK_TeacherGroup_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_TeacherGroup_Teacher] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([Id])
);

