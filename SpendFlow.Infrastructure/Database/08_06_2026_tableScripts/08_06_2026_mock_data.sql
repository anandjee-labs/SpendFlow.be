INSERT INTO PaymentMode (Name) VALUES
('UPI'),
('CASH'),
('CREDIT CARD'),
('DEBIT CARD'),
('CHEQUE');
GO
INSERT INTO ExpenseCategory (Name) VALUES
('Housing'),
('Utilities'),
('Food & Groceries'),
('Transportation'),
('Insurance & Loans');
Go
-- Housing
INSERT INTO ExpenseSubCategory (Name, CategoryId)
VALUES
('Rent / Home Loan EMI', (SELECT Id FROM ExpenseCategory WHERE Name = 'Housing')),
('Maintenance', (SELECT Id FROM ExpenseCategory WHERE Name = 'Housing')),
('Property Tax', (SELECT Id FROM ExpenseCategory WHERE Name = 'Housing')),
('Repairs', (SELECT Id FROM ExpenseCategory WHERE Name = 'Housing'));

-- Utilities
INSERT INTO ExpenseSubCategory (Name, CategoryId)
VALUES
('Electricity', (SELECT Id FROM ExpenseCategory WHERE Name = 'Utilities')),
('Water', (SELECT Id FROM ExpenseCategory WHERE Name = 'Utilities')),
('Gas', (SELECT Id FROM ExpenseCategory WHERE Name = 'Utilities')),
('Internet & Mobile', (SELECT Id FROM ExpenseCategory WHERE Name = 'Utilities'));

-- Food & Groceries
INSERT INTO ExpenseSubCategory (Name, CategoryId)
VALUES
('Groceries', (SELECT Id FROM ExpenseCategory WHERE Name = 'Food & Groceries')),
('Milk & Dairy', (SELECT Id FROM ExpenseCategory WHERE Name = 'Food & Groceries')),
('Vegetables & Fruits', (SELECT Id FROM ExpenseCategory WHERE Name = 'Food & Groceries')),
('Household Essentials', (SELECT Id FROM ExpenseCategory WHERE Name = 'Food & Groceries'));

-- Transportation
INSERT INTO ExpenseSubCategory (Name, CategoryId)
VALUES
('Fuel', (SELECT Id FROM ExpenseCategory WHERE Name = 'Transportation')),
('Public Transport', (SELECT Id FROM ExpenseCategory WHERE Name = 'Transportation')),
('Vehicle Maintenance', (SELECT Id FROM ExpenseCategory WHERE Name = 'Transportation')),
('Parking & Tolls', (SELECT Id FROM ExpenseCategory WHERE Name = 'Transportation'));

-- Insurance & Loans
INSERT INTO ExpenseSubCategory (Name, CategoryId)
VALUES
('Home Insurance', (SELECT Id FROM ExpenseCategory WHERE Name = 'Insurance & Loans')),
('Car Insurance', (SELECT Id FROM ExpenseCategory WHERE Name = 'Insurance & Loans')),
('Car EMI', (SELECT Id FROM ExpenseCategory WHERE Name = 'Insurance & Loans')),
('Personal Loan EMI', (SELECT Id FROM ExpenseCategory WHERE Name = 'Insurance & Loans'));
GO
----------------------------------

-- 1
INSERT INTO Expenses
(Title, Amount, CategoryId, SubCategoryId, PaymentModeId, Comments)
VALUES
(
    'June House Rent',
    18000,
    (SELECT Id FROM ExpenseCategory WHERE Name = 'Housing'),
    (SELECT Id FROM ExpenseSubCategory WHERE Name = 'Rent / Home Loan EMI'),
    (SELECT Id FROM PaymentMode WHERE Name = 'UPI'),
    'Paid via UPI'
);

-- 2
INSERT INTO Expenses
(Title, Amount, CategoryId, SubCategoryId, PaymentModeId, Comments)
VALUES
(
    'Electricity Bill',
    2500,
    (SELECT Id FROM ExpenseCategory WHERE Name = 'Utilities'),
    (SELECT Id FROM ExpenseSubCategory WHERE Name = 'Electricity'),
    (SELECT Id FROM PaymentMode WHERE Name = 'CREDIT CARD'),
    'Monthly bill'
);

-- 3
INSERT INTO Expenses
(Title, Amount, CategoryId, SubCategoryId, PaymentModeId, Comments)
VALUES
(
    'Grocery Shopping',
    3200,
    (SELECT Id FROM ExpenseCategory WHERE Name = 'Food & Groceries'),
    (SELECT Id FROM ExpenseSubCategory WHERE Name = 'Groceries'),
    (SELECT Id FROM PaymentMode WHERE Name = 'DEBIT CARD'),
    'Weekly groceries'
);

-- 4
INSERT INTO Expenses
(Title, Amount, CategoryId, SubCategoryId, PaymentModeId, Comments)
VALUES
(
    'Petrol Fill',
    1500,
    (SELECT Id FROM ExpenseCategory WHERE Name = 'Transportation'),
    (SELECT Id FROM ExpenseSubCategory WHERE Name = 'Fuel'),
    (SELECT Id FROM PaymentMode WHERE Name = 'CASH'),
    'Bike fuel'
);

-- 5
INSERT INTO Expenses
(Title, Amount, CategoryId, SubCategoryId, PaymentModeId, Comments)
VALUES
(
    'Car Insurance Renewal',
    12000,
    (SELECT Id FROM ExpenseCategory WHERE Name = 'Insurance & Loans'),
    (SELECT Id FROM ExpenseSubCategory WHERE Name = 'Car Insurance'),
    (SELECT Id FROM PaymentMode WHERE Name = 'CHEQUE'),
    'Annual premium'
);
