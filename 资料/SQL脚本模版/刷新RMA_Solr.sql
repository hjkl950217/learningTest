--暂时在读库上面

select top 5 * from NSVC2005.dbo.UV_RMA_I_SellerRMAMaster with(nolock) 
-- where RMANumber = 39664200
 where SourceSoNumber = 230278695

INSERT INTO mktpls.dbo.MPS_rma_rmaUpdateBuffer   
(   
     SellerID   
    ,RMANumber   
    ,[EventCode]   
    ,EventTime  
    ,EventChannel  
    ,[Status]   
    ,UpdateTime   
    ,InUser   
    ,InUserName  
    ,InDate   
)  
SELECT    
    B.SellerID   
   ,B.RMANumber  
   ,9  
   ,GETDATE()  
   ,'MKPL BSD'   
   ,'I'   
   ,NULL  
   ,'lw47'   
   ,'lw47'   
   ,GETDATE()   
FROM NSVC2005.dbo.UV_RMA_I_SellerRMAMaster B with(nolock)
-- where B.RMANumber = 39664200
 where B.SourceSoNumber = 230278695