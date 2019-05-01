CREATE TABLE [dbo].[Theme] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [ModuleId]  INT            NOT NULL,
    [Name]      NVARCHAR (MAX) NULL,
    [IsDeleted] BIT            NULL,
    CONSTRAINT [PK_Theme] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Theme_Module] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Module] ([Id])
);



