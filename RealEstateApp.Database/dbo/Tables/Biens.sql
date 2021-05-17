CREATE TABLE [dbo].[Biens] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Reference]   NVARCHAR (5)   NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Price]       FLOAT (53)     NOT NULL,
    [CreatedDate] DATETIME       NOT NULL,
    [IdPro]       INT            NOT NULL,
    CONSTRAINT [PK_Biens] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Biens_Proprietaire] FOREIGN KEY ([IdPro]) REFERENCES [dbo].[Proprietaire] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [IX_Biens] UNIQUE NONCLUSTERED ([Reference] ASC)
);

