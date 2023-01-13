USE CMSDB
GO
INSERT INTO Catagorys (CatagoryName)
VALUES ('Family'), ('Friends'), ('Work'), ('Other');
GO
INSERT INTO Contacts (Name, MobileNumber, Email, CatagoryID, Address)
VALUES
('Emily Davis', '+1 456 789 1230', 'emilydavis@gmail.com', 1, '789 Maple Street'),
('James Smith', '+1 159 357 9640', 'jamessmith@gmail.com', 2, '321 Pine Avenue'),
('Lauren Kim', '+1 246 852 7410', 'laurenkim@gmail.com', 4, '654 Birch Road'),
('David Williams', '+1 369 741 8520', 'davidwilliams@gmail.com', 3, '159 Oak Avenue')
GO
INSERT INTO Contacts (Name, MobileNumber, Email, CatagoryID, Address)
VALUES
('Kane Smith', '+1 456 789 1232', 'kanesmith2@gmail.com', 3, '788 Birch Road')