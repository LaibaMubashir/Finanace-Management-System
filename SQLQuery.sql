/*CREATE TABLE Budgets (
    [BudgetID]          INT             IDENTITY (1, 1) NOT NULL,
    [BudgetName]        NVARCHAR (255)  NULL,
    [StartDate]         DATE            NULL,
    [EndDate]           DATE            NULL,
    [TotalAmount]       DECIMAL (10, 2) NULL,
    [ActualAmount]      DECIMAL (10, 2) NULL,
    [BudgetDescription] NVARCHAR (MAX)  NULL,
    [Notes]             NVARCHAR (MAX)  NULL,
    PRIMARY KEY CLUSTERED ([BudgetID] ASC),
    
);
*/
select * from budgets
