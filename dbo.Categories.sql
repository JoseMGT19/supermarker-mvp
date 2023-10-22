CREATE TABLE [dbo].[Categories] (
    [Categories_Id]          INT           IDENTITY (100000, 1) NOT NULL,
    [Categories_Name]        NVARCHAR (50) NOT NULL,
    [Categories_Observation] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Categories_Id] ASC)
);

