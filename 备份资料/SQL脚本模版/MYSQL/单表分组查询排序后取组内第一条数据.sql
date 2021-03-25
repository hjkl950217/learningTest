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