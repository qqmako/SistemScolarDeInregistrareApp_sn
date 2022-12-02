use SistemScolar
go
drop procedure if exists verificareAdmin
go
CREATE PROCEDURE verificareAdmin
@Admin nvarchar(50),
@Parola nvarchar(50)
AS
BEGIN
	
	SELECT * FROM tblAdmin
	WHERE [Admin] = @Admin AND Parola = @Parola

END

