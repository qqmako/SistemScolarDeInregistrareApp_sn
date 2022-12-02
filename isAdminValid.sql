use SistemScolar
drop procedure if exists isAdminValid
go
CREATE PROCEDURE [dbo].[isAdminValid]
(
@Admin NVARCHAR(50),
@Parola NVARCHAR(50)
)
AS
	BEGIN

		DECLARE @IsAdminValid BIT
		SET @IsAdminValid = 0

		IF EXISTS(SELECT * FROM tblAdmin WHERE [Admin] = @Admin
										AND Parola = @Parola)										
		BEGIN
		SET @IsAdminValid = 1
		END

		SELECT @IsAdminValid
	END
