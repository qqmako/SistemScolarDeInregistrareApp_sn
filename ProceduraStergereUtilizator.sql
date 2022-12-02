use SistemScolar
drop procedure if exists StergereUtilizator
go
CREATE PROCEDURE StergereUtilizator
(
@UtilizatorID int
)
AS
	BEGIN
		Delete From tblUtilizatori
		Where UtilizatorID = @UtilizatorID
	END
