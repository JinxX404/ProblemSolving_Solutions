select * , case
when (x >= 0) AND (y >= 0) AND (z >= 0) AND (x + y > z) AND (y + z > x) AND (z + x > y) then 'Yes' else 'No'
end
as triangle
from Triangle