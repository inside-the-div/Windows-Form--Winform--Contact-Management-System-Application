USE CMSDB
GO
UPDATE Categories
SET CategoryName = 'Colleagues'
WHERE CategoryID = 4
GO

UPDATE Contacts
SET CatagoryID = 3
WHERE ContactID = 3
GO

DELETE FROM Catagories
WHERE CategoryID = 4
GO

DELETE FROM Contacts
WHERE ContactID = 3
GO

SELECT * FROM Categories
GO

SELECT * FROM Contacts
GO

SELECT Name, MobileNumber AS 'Mobile Number', Email, Address, CatagoryName AS 'Catagory' 
FROM Contacts
LEFT JOIN Catagories ON Contacts.CategoryID = Categories.CategoryID
GO

SELECT  ct.CategoryID AS ID, ct.CategoryName AS Catagory, COUNT(c.Categoryid) AS 'Total Number' 
FROM Catagories ct
LEFT JOIN 
Contacts c 
ON 
c.CategoryID = ct.CategoryID 

GROUP BY ct.CategoryID
, ct.CategoryName
GO

UPDATE Contacts SET CategoryID = 1 WHERE  CategoryID in ()