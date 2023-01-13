USE CMSDB
GO
UPDATE Catagorys
SET CatagoryName = 'Colleagues'
WHERE CatagoryID = 4
GO

UPDATE Contacts
SET CatagoryID = 3
WHERE ContactID = 3
GO

DELETE FROM Catagorys
WHERE CatagoryID = 4
GO

DELETE FROM Contacts
WHERE ContactID = 3
GO

SELECT * FROM Catagorys
GO

SELECT * FROM Contacts
GO

SELECT Name, MobileNumber AS 'Mobile Number', Email, Address, CatagoryName AS 'Catagory' 
FROM Contacts
LEFT JOIN Catagorys ON Contacts.CatagoryID = Catagorys.CatagoryID
GO

SELECT  ct.CatagoryID AS ID, ct.CatagoryName AS Catagory, COUNT(c.Catagoryid) AS 'Total Number' 
FROM Catagorys ct
LEFT JOIN 
Contacts c 
ON 
c.CatagoryID = ct.CatagoryID 

GROUP BY ct.CatagoryID
, CatagoryName
GO

UPDATE Contacts SET CatagoryID = 1 WHERE CatagoryID = 3