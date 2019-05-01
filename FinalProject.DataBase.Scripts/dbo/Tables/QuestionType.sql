CREATE TABLE [dbo].[QuestionType] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Type]      NVARCHAR (MAX) NULL,
    [IsDeleted] BIT            NULL,
    CONSTRAINT [PK_QuestionType] PRIMARY KEY CLUSTERED ([Id] ASC)
);



