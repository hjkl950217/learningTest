SELECT
	* 
FROM
	(
	SELECT
		* 
	FROM
		(
		SELECT
			Region_Code,
			Region_Name,
			Region_FullName,
			Type_Code,
			Parent_Region_Code,
			Dict_EnName,
			Pinyin_Code,
			Wubi_Code,
			Standard_Code,
			Order_No,
			Search_Code,
			Tag,
			Remark 
		FROM
			dict_region 
		UNION ALL
		SELECT
			Region_Code,
			Region_Name,
			Region_FullName,
			Type_Code,
			Parent_Region_Code,
			Dict_EnName,
			Pinyin_Code,
			Wubi_Code,
			Standard_Code,
			Order_No,
			Search_Code,
			Tag,
			Remark 
		FROM
			dict_region_group 
		) AS c 
	ORDER BY
		Parent_Region_Code,
		Region_Code 
	) AS RegionList,
	( SELECT @pv := '54' ) initialisation 
WHERE
	FIND_IN_SET( Parent_Region_Code, @pv ) 
	AND LENGTH(@pv := CONCAT( @pv, ',', Region_Code ) )