insert into Customers values('CustomerID','CompanyName','ContactName','Country')
insert into Customers values('CustomerID01','CompanyName01','ContactName01','Country01')
insert into Customers values('CustomerID09','CompanyName01','ContactName02','Country01')
insert into Customers values('CustomerID10','CompanyName02','ContactName03','Country01')
insert into Customers values('CustomerID08','CompanyName03','ContactName04','Country01')
insert into Customers values('CustomerID06','CompanyName04','ContactName05','Country01')
insert into Customers values('CustomerID04','CompanyName05','ContactName06','Country01')
insert into Customers values('CustomerID05','CompanyName06','ContactName07','Country01')



insert into Customers values('CustomerID010','CompanyName01','ContactName010','Country01')
insert into Customers values('CustomerID090','CompanyName01','ContactName020','Country011')
insert into Customers values('CustomerID100','CompanyName01','ContactName003','Country0120')
insert into Customers values('CustomerID080','CompanyName01','ContactName040','Country0130')
insert into Customers values('CustomerID060','CompanyName01','ContactName050','Country041')
insert into Customers values('CustomerID040','CompanyName01','ContactName006','Country051')
insert into Customers values('CustomerID050','CompanyName01','ContactName070','Country601')



insert into Customers values('CustomerID1010','CompanyName021','ContactName010','Country014')
insert into Customers values('CustomerID1090','CompanyName031','ContactName010','Country0112')
insert into Customers values('CustomerID1100','CompanyName014','ContactName010','Country01120')
insert into Customers values('CustomerID1080','CompanyName015','ContactName010','Country2130')
insert into Customers values('CustomerID1060','CompanyName051','ContactName010','Country141')
insert into Customers values('CustomerID1040','CompanyName061','ContactName010','Country1251')
insert into Customers values('CustomerID1050','CompanyName017','ContactName010','Country12601')


select distinct Country from Customers where LEN(country)>10

update Customers set Country ='Country014' where LEN(country)>10