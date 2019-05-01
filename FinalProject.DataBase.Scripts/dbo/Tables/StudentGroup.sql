CREATE TABLE [dbo].[StudentGroup] (
    [StudentId] INT NOT NULL,
    [GroupId]   INT NOT NULL,
    CONSTRAINT [PK_StudentGroup] PRIMARY KEY CLUSTERED ([StudentId] ASC, [GroupId] ASC),
    CONSTRAINT [FK_StudentGroup_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_StudentGroup_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id])
);

