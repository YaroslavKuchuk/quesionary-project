CREATE TABLE [dbo].[Group] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [CourseId]    INT            NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [BeginigDate] DATETIME       NULL,
    [IsDeleted]   BIT            NULL,
    CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Group_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id])
);



