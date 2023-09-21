
由子查到父

set @r := 90, @l := 0;

SELECT *
FROM (
    SELECT
        @r AS _id,
        (SELECT @r := ParentId FROM partition_info WHERE id = _id) AS parent_id,
        @l := @l + 1 AS lvl
    FROM
        partition_info m
    WHERE @r <> 0) T1
JOIN partition_info T2
ON T1._id = T2.id
ORDER BY T1.lvl DESC;

-- 由父查到子
set @ids := 88, @l := 0;
SELECT t1.*
FROM
    (
        SELECT
            @ids AS _ids,
            (
                SELECT
                    @ids := GROUP_CONCAT(id)
                FROM
                    partition_info
                WHERE
                    FIND_IN_SET(ParentId, @ids)
                # 表内查询条件（AND site_id = 2）
										
            ) AS cids,
            @l := @l + 1 AS LEVEL
        FROM
            partition_info
           -- (SELECT @ids := 0, @l := 0) b
        WHERE
            @ids IS NOT NULL
    ) as t,
    partition_info as t1
WHERE
    FIND_IN_SET(t1.id, t._ids)
ORDER BY
    LEVEL DESC;


-- 由父查到子2
SELECT t1.*, t.*
FROM
(
  SELECT
    @ids AS _ids,
    (
      SELECT @ids := GROUP_CONCAT(id) FROM partition_info
      WHERE FIND_IN_SET(ParentId, @ids)
    ) AS cids,
    @l := @l + 1 AS LEVEL
  FROM partition_info, (SELECT @ids := 88, @l := 0) b
  WHERE @ids IS NOT NULL
) as t,
partition_info as t1
WHERE FIND_IN_SET(t1.id, t._ids)
ORDER BY LEVEL

		
