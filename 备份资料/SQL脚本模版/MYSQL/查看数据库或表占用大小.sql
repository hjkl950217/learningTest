-- 查看指定数据库占用大小
select
table_schema as '数据库',
sum(table_rows) as '记录数',
sum(truncate(data_length/1024/1024, 2)) as '数据占用(MB)',
sum(truncate(index_length/1024/1024, 2)) as '索引占用(MB)',
(sum(truncate((data_length+index_length)/1024/1024, 2))) as '总占用(MB)'
from information_schema.tables
where table_schema='mysql';


-- 查看指定数据库各表容量大小
select
table_schema as '数据库',
table_name as '表名',
table_rows as '记录数',
truncate(data_length/1024/1024, 2) as '数据占用(MB)',
truncate(index_length/1024/1024, 2) as '索引占用(MB)',
truncate((data_length+index_length)/1024/1024, 2) as '总占用(MB)'
from information_schema.tables
where table_schema='mysql'
order by data_length desc, index_length desc;