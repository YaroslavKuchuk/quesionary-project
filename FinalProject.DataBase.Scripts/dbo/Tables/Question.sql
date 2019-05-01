CREATE TABLE [dbo].[Question] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [ModuleId]       INT            NULL,
    [Text]           NVARCHAR (MAX) NULL,
    [ThemeId]        INT            NULL,
    [QuestionTypeId] INT            NULL,
    [TestId]         INT            NULL,
    [IsDeleted]      BIT            NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Question_Module] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Module] ([Id]),
    CONSTRAINT [FK_Question_QuestionType] FOREIGN KEY ([QuestionTypeId]) REFERENCES [dbo].[QuestionType] ([Id]),
    CONSTRAINT [FK_Question_Test] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Test] ([Id]),
    CONSTRAINT [FK_Question_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id])
);



