USE MKTPLS
GO

/*================================================================================  
Server:    S7EDIDB01  
DataBase:  MKTPLS  
Author:    Lynn.X.Wnag
Object:    MPS_Portal_SystemFeedback
Version:   1.0  
Date:      2019-10-16
Content:   https://confluence.newegg.org/display/MKPL/seller+portal+3.0+New+menu+and+function
----------------------------------------------------------------------------------  
Modified history:      
      
Date        Modified by		VER    Description      
------------------------------------------------------------  
2019-10-16  Lynn.X.Wnag		1.0    Create.  
================================================================================*/   
--DROP TABLE MKTPLS.dbo.MPS_Portal_SystemFeedback
CREATE Table MKTPLS.dbo.MPS_Portal_SystemFeedback
(
	TransactionNumber					INT IDENTITY(10000,1)		NOT NULL,
	SellerID							CHAR(6)						NOT NULL,

	CategoryType						TINYINT						NOT NULL,
	CategoryTypeDescription				VARCHAR(30)					NOT NULL,
	SystemType							TINYINT						NOT NULL,
	SystemName							VARCHAR(30)					NOT NULL,
	FunctionUrl							VARCHAR(200),
	FunctionName						VARCHAR(200),
	PlatformName						VARCHAR(200)				NOT NULL,
	Rating								TINYINT						NOT NULL,
	Detail								NVARCHAR(2000)				NOT NULL,
	ScreenShotFilePath					VARCHAR(256),
	AttachmentFilePathList				VARCHAR(1000),
	PlatformCode						CHAR(3)						NOT NULL,


	InUserID							INT							NOT NULL,
	InUser								VARCHAR(128)				NOT NULL,
	InDate								DATETIME					NOT NULL CONSTRAINT DF_MPS_Portal_SystemFeedback_InDate DEFAULT GETDATE(),  

	LastEditUserID						INT							NULL,
	LastEditUser						VARCHAR(128)				NULL,
	LastEditDate						DATETIME					NULL
	CONSTRAINT MPS_Portal_SystemFeedback PRIMARY KEY CLUSTERED 
	(
		TransactionNumber ASC
	)
) ON [PRIMARY]
GO


CREATE NONCLUSTERED INDEX IX_SellerID ON MKTPLS.dbo.MPS_Portal_SystemFeedback
(
	SellerID
)WITH (FILLFACTOR = 90)
Go
--create standard nonclustered index 
CREATE NONCLUSTERED INDEX IX_MPS_MPS_Portal_SystemFeedback_InDate ON MKTPLS.dbo.MPS_Portal_SystemFeedback
(
	InDate
)WITH (FILLFACTOR = 90)
Go

CREATE NONCLUSTERED INDEX IX_MPS_MPS_Portal_SystemFeedback_LastEditDate ON MKTPLS.dbo.MPS_Portal_SystemFeedback
(
	LastEditDate
)WITH (FILLFACTOR = 90)
Go