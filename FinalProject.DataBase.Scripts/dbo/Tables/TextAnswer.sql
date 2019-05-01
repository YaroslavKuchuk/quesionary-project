CREATE TABLE [dbo].[TextAnswer] (
    [Id]         INT            NOT NULL,
    [QuestionId] INT            NULL,
    [TextBox]    NVARCHAR (MAX) NULL,
    [IsCorrect]  INT            NULL,
    [IsDeleted]  BIT            NULL,
    CONSTRAINT [PK_TextAnswer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TextAnswer_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([Id])
);



