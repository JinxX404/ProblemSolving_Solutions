select FORMAT(trans_date, 'yyyy-MM') as month , country, count(*) as trans_count, sum(iif(state='approved',1,0)) as approved_count,sum(amount) as trans_total_amount,sum(iif(state='approved',1,0) * amount) as approved_total_amount
from Transactions 
group by country,FORMAT(trans_date, 'yyyy-MM')