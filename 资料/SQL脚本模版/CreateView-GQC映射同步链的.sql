USE [MKTPLS]
GO


USE MKTPLS
GO
sp_refreshview MPS_Seller_PolicyViolationTicket  --刷新同步链

--下面是创建的
--Create view MPS_Seller_PolicyViolationTicket
--as    
--select * from S7EDIDB01.MKTPLS.dbo.MPS_Seller_PolicyViolationTicket with(nolock) 


--Create view MPS_Seller_PolicyViolationTicket_CommentConent
--as    
--select * from S7EDIDB01.MKTPLS.dbo.MPS_Seller_PolicyViolationTicket_CommentConent with(nolock) 

--Create view MPS_Seller_PolicyViolationTicket_CommentFile
--as    
--select * from S7EDIDB01.MKTPLS.dbo.MPS_Seller_PolicyViolationTicket_CommentFile with(nolock)

--Create view MPS_Seller_PolicyViolationTicket_Items
--as    
--select * from S7EDIDB01.MKTPLS.dbo.MPS_Seller_PolicyViolationTicket_Items with(nolock)

--Create view MPS_Seller_PolicyViolationTicket_EventLog
--as    
--select * from S7EDIDB01.MKTPLS.dbo.MPS_Seller_PolicyViolationTicket_EventLog with(nolock)
GO


