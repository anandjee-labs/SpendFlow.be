CREATE TABLE PaymentMode
(
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(200) NOT NULL UNIQUE,
    IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE ExpenseCategory
(
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(200) NOT NULL UNIQUE,
    IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE ExpenseSubCategory
(
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(200) NOT NULL,
    CategoryId INT NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,

    CONSTRAINT FK_SubCategory_Category
        FOREIGN KEY (CategoryId) REFERENCES ExpenseCategory(Id),

    CONSTRAINT UQ_SubCategory UNIQUE(Name, CategoryId)
);

CREATE TABLE Expenses
(
    Id INT IDENTITY PRIMARY KEY,

    Title NVARCHAR(250) NOT NULL,

    Amount DECIMAL(10,2) NOT NULL DEFAULT 0,

    CategoryId INT NOT NULL,

    SubCategoryId INT NOT NULL,

    PaymentModeId INT NOT NULL,

    Comments NVARCHAR(MAX) NULL,

    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Expenses_Category 
        FOREIGN KEY (CategoryId) REFERENCES ExpenseCategory(Id),

    CONSTRAINT FK_Expenses_SubCategory 
        FOREIGN KEY (SubCategoryId) REFERENCES ExpenseSubCategory(Id),

    CONSTRAINT FK_Expenses_PaymentMode 
        FOREIGN KEY (PaymentModeId) REFERENCES PaymentMode(Id)
);
