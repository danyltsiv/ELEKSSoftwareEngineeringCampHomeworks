--1
select Name from Product 
		where Number > 0;

--2
select Name from Product 
		where Name like '%2%';

--3
select Name, Price from Product where Price < 10;

--4
select BarCode, Name from Product where Comment IS NULL;

--5
select sum(Number) from Product;

--6
select Name,Number from Product;

--7
select Product.Name from Product where ProductId not in (select ProductId from DocumentDetail);

--8
select Name,
	(select Count(DocumentId) from DocumentDetail where DocumentDetail.ProductId = Product.ProductId)
	from Product;

--9
select ProductID,SUM(Number) from DocumentDetail GROUP BY ProductId;

--10
select Name,BarCode,(select SUM(Amount) 
					from DocumentDetail 
					where Product.ProductId = DocumentDetail.ProductId 
					GROUP BY ProductId)
					from Product  order by Name;

--11
 select Name from Client;

 --12
 select Name from Client where Name like 'Cl%';

 --13
 select Name,Address from Client where Address is not null;

 --14
 select Name, ClientId from Client
				where Amount !>0;
				
--15
select sum(amount) from client;

--16
select name,ClientId from client where clientId not in 
						(select ClientId from Document);
												
--18
select Name,(select count(DocumentId) from Document 
				where Document.ClientId=Client.ClientId) 
				from Client;

--19
select Name,Amount from Client where ClientId in (
				select ClientId from Document where Document.DocumentTypeKey in 
				(select DocumentTypeKey from DocumentType where DocumentType.Name='Invoice'));

--20
select Client.Name,Client.ClientId,t.Suma from Client,(select Clientid,sum(Amount) as Suma 
				from Document where DocumentTypeKey in (select DocumentTypeKey 
				from DocumentType where Name = 'Payment') group by ClientId) as t
				where Client.ClientId=t.ClientId order by ClientId;