USE CMSDB
GO
INSERT INTO Categories (CategoryName)
VALUES ('Unassigned'), ('Family'), ('Friends'), ('Work'), ('Other');
GO
INSERT INTO Contacts (Name, MobileNumber, Email, CategoryID, Address)
VALUES
('Emily Davis', '+14567891230', 'emilydavis@gmail.com', 1, '789 Maple Street'),
('James Smith', '+11593579640', 'jamessmith@gmail.com', 2, '321 Pine Avenue'),
('Lauren Kim', '+12468527410', 'laurenkim@gmail.com', 4, '654 Birch Road'),
('David Williams', '+13697418520', 'davidwilliams@gmail.com', 3, '159 Oak Avenue')
GO
INSERT INTO Contacts (Name, MobileNumber, Email, CategoryID, Address)
VALUES
('Kane Smith', '+1 456 789 1232', 'kanesmith2@gmail.com', 3, '788 Birch Road')