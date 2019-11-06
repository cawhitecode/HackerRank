// Oracle
select * from (select city c, length(city) l
from   station
order by l desc, c asc)
where rownum = 1;

select * from (select city c, length(city) l
from   station
order by l asc, c asc)
where rownum = 1;

// MySQL

SELECT CITY, LENGTH(CITY) FROM STATION
ORDER BY LENGTH(CITY), CITY
LIMIT 1;

SELECT CITY, LENGTH(CITY) FROM STATION
ORDER BY LENGTH(CITY) DESC, CITY
LIMIT 1;