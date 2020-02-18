

IF OBJECT_ID(N'tempdb.dbo.#TempApiKeyDeveloperInfo', N'U') IS NOT NULL
	DROP TABLE #TempApiKeyDeveloperInfo

CREATE TABLE #TempApiKeyDeveloperInfo (
	[ID] [int] IDENTITY(1,1),
	DeveloperName NVARCHAR(100), 
	CountryCode char(3),
	PlatformName varchar(24)
)

--1. select data to update table
INSERT INTO #TempApiKeyDeveloperInfo
(	DeveloperName,
	CountryCode,
	PlatformName
)
SELECT 
	a.DeveloperName,
	a.CountryCode,
	a.PlatformName 
FROM(
	SELECT DISTINCT c.DeveloperName
	,d.CountryCode
	,PlatformName = 
		CASE 
			WHEN d.CountryCode = 'USA' THEN 'Newegg.com' 
			WHEN d.CountryCode = 'USB' THEN 'BusinessNewegg.com'
			ELSE 'Newegg.ca' 
		END
	FROM MKTPLS.[dbo].[MPS_Seller_APIAuthorizedInfo] b(NOLOCK) 
	INNER JOIN MKTPLS.dbo.MPS_Seller_APIDeveloperInfo c(NOLOCK) ON c.ApiKey = b.DevAPIKey
	INNER JOIN MKTPLS.dbo.EDI_Seller_BasicInfo d(NOLOCK) ON b.sellerID = d.sellerID
	--WHERE  DeveloperName NOT LIKE 'Test%'
) AS a
--select COUNT(*) from #TempApiKeyDeveloperInfo

--2. batch execute code
DECLARE @PerCount int=500 -- 每批处理的记录数 
DECLARE @DataCount int, --未处理的数据量
		@CurCount int, --单次循环时的剩余数据量
		@CurID INT, --单次循环中，要操作的ID
		@CurDeveloperName NVARCHAR(100), 
		@CurCountryCode char(3) 
DECLARE @TempApiKeyDeveloperTalbe TABLE(
	ID INT,
	DeveloperName NVARCHAR(100), 
	CountryCode char(3) 
)

WHILE(1=1)
BEGIN  
	INSERT INTO @TempApiKeyDeveloperTalbe(ID,DeveloperName,CountryCode)
	SELECT TOP(@PerCount) 
		T.ID,
		T.DeveloperName,
		T.CountryCode 
	FROM #TempApiKeyDeveloperInfo T 
	ORDER BY T.ID
	
	SELECT @DataCount = COUNT(ID) FROM @TempApiKeyDeveloperTalbe
	SELECT @CurCount = COUNT(ID) FROM @TempApiKeyDeveloperTalbe
	WHILE(@CurCount>0)
		BEGIN
			SELECT TOP(1) 
				@CurID=ID,
				@CurDeveloperName=DeveloperName,
				@CurCountryCode=CountryCode 
			FROM @TempApiKeyDeveloperTalbe

			IF EXISTS(SELECT TOP 1 1 FROM MKTPLS.dbo.MPS_Seller_APIDeveloperInfo (NOLOCK) WHERE DeveloperName=@CurDeveloperName AND (PlatformCode=@CurCountryCode OR PlatformCode IS NULL))
				BEGIN
					UPDATE top(1) MKTPLS.dbo.MPS_Seller_APIDeveloperInfo 
						set PlatformCode=@CurCountryCode 
					where DeveloperName=@CurDeveloperName AND PlatformCode IS NULL
				END

			ELSE
				BEGIN
					INSERT INTO MKTPLS.dbo.MPS_Seller_APIDeveloperInfo(
						DeveloperName,
						EmailAddress,
						CompanyName,
						CompanyURL,
						FirstName,
						LastName,
						ContactPhone,
						ApiKey,
						InDate,
						InUser,
						InUserName,
						PlatformCode)
					SELECT TOP(1) 
						A.DeveloperName,
						A.EmailAddress,
						A.CompanyName,
						A.CompanyURL,
						A.FirstName,
						A.LastName,
						A.ContactPhone,
						A.ApiKey,
						A.InDate,
						A.InUser,
						A.InUserName,
						@CurCountryCode
					FROM MKTPLS.dbo.MPS_Seller_APIDeveloperInfo A WITH(NOLOCK) WHERE DeveloperName=@CurDeveloperName 
				END	
							
			DELETE @TempApiKeyDeveloperTalbe WHERE ID = @CurID
			SELECT @CurCount = COUNT(ID) FROM @TempApiKeyDeveloperTalbe
			DELETE #TempApiKeyDeveloperInfo WHERE ID = @CurID
		END	
    
	--SELECT @DataCount
	IF @DataCount < @PerCount
		BREAK --Jump out
	WAITFOR DELAY '00:00:05'
END 

IF OBJECT_ID(N'tempdb.dbo.#TempApiKeyDeveloperInfo', N'U') IS NOT NULL
	DROP TABLE #TempApiKeyDeveloperInfo