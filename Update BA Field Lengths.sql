USE [BPES]
Go

-- Update BatchAction table with increased field lengths
Alter Table BDR.BatchAction
Alter Column Phase NVarchar(80)
Alter Table BDR.BatchAction
Alter Column Recipe NVarchar(80)

GO

-- =============================================
-- Author:		PRL
-- Create date: 1 Jan 2017
-- Description:	Adds Batch Action Record
-- Updated: 3/19/23 to increase field size for Phase, Recipe
-- =============================================
ALTER PROCEDURE [BDR].[uspAddBatchAction] 
	@TS datetime,
	@State nvarchar(10),
	@UserID nvarchar(50),
	@Phase nvarchar(80),
	@Recipe nvarchar(80)

AS
BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

Declare @BatchFK int
	
SElect @BatchFK=        MAX(BatchID)
FROM            BDR.Batch

INSERT INTO BDR.BatchAction
                         (BatchFK, EventTimeStamp, State, UserID, Phase, Recipe)
VALUES        (@BatchFK,@TS,@State,@UserID,@Phase,@Recipe)


END

