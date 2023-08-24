USE MKTPLS
GO

/*================================================================================  
Server:    S7EDIDB01  
DataBase:  MKTPLS  
Author:    Lynn.X.Wnag
Object:    MPS_Seller_PriceSafeguardSetting
Version:   1.0  
Date:      2020-02-15
Content:   https://confluence.newegg.org/x/hTkWB
----------------------------------------------------------------------------------  
Modified history:      
      
Date        Modified by		VER    Description      
------------------------------------------------------------  
2020-02-15  Lynn.X.Wnag		1.0    Create.  
================================================================================*/   
--DROP TABLE MKTPLS.dbo.MPS_Seller_PriceSafeguardSetting
CREATE Table DBO.MPS_Seller_PriceSafeguardSetting
(
	TransactionNumber					INT IDENTITY(1,1)			NOT NULL,
	SellerID							CHAR(6)						NOT NULL,

	EnablePriceSafeguard				BIT							NOT NULL,
	PriceSafeguardMode					INT							NOT NULL,
	ThresholdAmount						DECIMAL(18,4),				
	ThresholdPercentage					NUMERIC(6,4),			

	InUserID							INT							NOT NULL,
	InUser								VARCHAR(128)				NOT NULL,
	InDate								DATETIME					NOT NULL CONSTRAINT DF_MPS_Seller_PriceSafeguardSetting_InDate DEFAULT GETDATE(),  

	LastEditUserID						INT							NULL,
	LastEditUser						VARCHAR(128)				NULL,
	LastEditDate						DATETIME					NULL
	CONSTRAINT PK_MPS_Seller_PriceSafeguardSetting PRIMARY KEY CLUSTERED 
	(
		TransactionNumber ASC
	)
) ON [PRIMARY]
GO


CREATE NONCLUSTERED INDEX IX_MPS_Seller_PriceSafeguardSetting_SellerID ON dbo.MPS_Seller_PriceSafeguardSetting
(
	SellerID
)WITH (FILLFACTOR = 90)
Go
--create standard nonclustered index 
CREATE NONCLUSTERED INDEX IX_MPS_Seller_PriceSafeguardSetting_InDate ON dbo.MPS_Seller_PriceSafeguardSetting
(
	InDate
)WITH (FILLFACTOR = 90)
Go

CREATE NONCLUSTERED INDEX IX_MPS_Seller_PriceSafeguardSetting_LastEditDate ON dbo.MPS_Seller_PriceSafeguardSetting
(
	LastEditDate
)WITH (FILLFACTOR = 90)
Go