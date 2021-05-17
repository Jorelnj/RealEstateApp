CREATE TABLE [dbo].[Proprietaire] (
    [Id]          INT        IDENTITY (1, 1) NOT NULL,
    [Name]        NCHAR (10) NOT NULL,
    [CreatedDate] DATETIME   NOT NULL,
    CONSTRAINT [PK_Proprietaire] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Proprietaire] UNIQUE NONCLUSTERED ([Name] ASC)
);

