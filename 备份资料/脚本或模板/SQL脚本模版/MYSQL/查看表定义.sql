-- 查询formId
SELECT FormId FROM `eform_formsetting` 
WHERE  Controls LIKE '%HierarchyType%' and FormVer =0
GROUP BY FormId


-- 查询表字段
select table_name 
from information_schema.COLUMNS 
WHERE column_name='HierarchyType'


-- 查询视图是否包含字段
select TABLE_NAME
from information_schema.VIEWS 
WHERE  VIEW_DEFINITION LIKE '%HierarchyType%'




