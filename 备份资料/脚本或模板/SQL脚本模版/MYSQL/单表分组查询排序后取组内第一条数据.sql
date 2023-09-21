SELECT
pre.* 
FROM
sensor_data_water_meter_dlss AS pre
INNER JOIN ( 
	SELECT 
	MAX ( gatherTime ) AS gatherTime,
	mid 
	FROM sensor_data_water_meter_dlss  
	GROUP BY mid ) lastest 
		ON lastest.gatherTime = pre.gatherTime AND lastest.mid = pre.mid 


另一种：
SELECT * FROM
(
	SELECT *, ROW_NUMBER() OVER (PARTITION BY mid  ORDER BY gatherTime DESC) as rn
	FROM sensor_data_water_meter_dlss
) t
WHERE rn = 1 

另一种:
# WHERE t.id = t1.id  是分组条件
# max( t.update_time ) 是排序

SELECT
	* 
FROM
	table_name t1 
WHERE
	t1.update_time = ( SELECT max( t.update_time ) FROM table_name t WHERE t.id = t1.id );