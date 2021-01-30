--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir  from Customers 

Select * from Customers where City = 'Berlin'

Select * from Products  where CategoryID=1 or CategoryID=3

Select * from Products  where CategoryID=1 and UnitPrice>=20

Select * from Products where categoryId=1 order by   UnitPrice desc -- azalan fiyata göre --descending

Select count(*) from Products 
 
Select categoryId,count(*) from products group by CategoryID

Select categoryId,count(*) from products group by CategoryID having count(*) <10

Select Products.ProductId, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories 
on Products.CategoryId = Categories.CategoryId
where Products.UnitPrice>10

Select * from .Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null