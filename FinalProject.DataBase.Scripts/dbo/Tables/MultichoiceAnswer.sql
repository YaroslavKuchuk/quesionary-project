CREATE TABLE [dbo].[MultichoiceAnswer] (
    [Id]         INT            NOT NULL,
    [QuestionId] INT            NULL,
    [AnswerText] NVARCHAR (MAX) NULL,
    [IsCorrect]  INT            NULL,
    [IsDeleted]  BIT            NULL,
    CONSTRAINT [PK_MultichoiceAnswer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MultichoiceAnswer_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([Id])
);



