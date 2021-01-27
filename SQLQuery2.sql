select ContactName Adi,CompanyName SirketAdi from Customers

Select * from Customers where City ='Berlin'

Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>10
--order by sıralama
select * from Products order by CategoryID,UnitPrice
select * from Products order by UnitPrice

select * from Products order by UnitPrice asc -- artan

select * from Products where CategoryID=1 order by UnitPrice desc --düşen

select COUNT(*) from Products where CategoryID=2

select COUNT(*) adet from Customers
-- hangi kategoride kaç ürün var--
select CategoryID, COUNT(*)  AdetSayısı from Products group by  CategoryID having  COUNT(*)<10

-- inner join 2 tabloda eşleşeleri getirir.
select Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName from 
Products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10

Select * from Products  p left join [Order Details] od on p.ProductID=od.ProductID

--solda olup sağda olmayan/ kayıtlı olan müşteriler ama sipariş yapmayanlar
Select * from Customers c left join Orders o on  c.CustomerID=o.CustomerID
where o.CustomerID is null
