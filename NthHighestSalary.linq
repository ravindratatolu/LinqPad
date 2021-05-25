<Query Kind="SQL">
  <Connection>
    <ID>69858fc5-5e91-45df-9410-5c232d43cba1</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>SQLPlayGround</Database>
  </Connection>
</Query>

;with cte as
(
Select *,Dense_Rank() over(order by Salary) as Rank
From Employees
)
select top 1* from cte
where rank = 3