/* Write your T-SQL query statement below */
select pro.product_name, sum(ord.unit) as unit
from Products pro join Orders ord
on pro.product_id = ord.product_id 
where ord.order_date between '2020-02-01' and '2020-02-29'
group by pro.product_name
having sum(ord.unit)>=100