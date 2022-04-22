
DROP TABLE IF EXISTS #res1
DROP TABLE IF EXISTS #res2
select sh.shipperid as 'id',sh.companyname, CAST(SUM(ord.freight) as DECIMAL(10,2)) as 'TotalFreight'
 INTO #res1
 from Sales.Shippers sh
inner join Sales.Orders ord
on ord.shipperid=sh.shipperid
--inner join Sales.OrderDetails det
--on det.orderid=ord.orderid
GROUP BY sh.shipperid,sh.companyname

select ord.shipperid as 'id',  CAST(sum(de.unitprice*de.qty) as DECIMAL(10,2) )as 'TotalCosstShipped',sum(de.qty) as 'TotalItemsShipped' 
into #res2
from Sales.Orders ord
inner JOIN Sales.OrderDetails de
on ord.orderid=de.orderid
GROUP BY ord.shipperid

select r1.companyname,r1.TotalFreight,r2.TotalCosstShipped,r2.TotalItemsShipped from #res1 r1
inner join #res2 r2
on r1.id=r2.id
order by companyname asc

DROP TABLE #res1
DROP TABLE #res2