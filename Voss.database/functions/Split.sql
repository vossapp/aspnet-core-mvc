CREATE FUNCTION [dbo].[Split]
(
	@Delimiter		char(1),		-- The delimiter
	@List			nvarchar(max)	-- The delimited list 
)
RETURNS @Table1 TABLE
(
	[Index]		int identity(1,1) NOT NULL,
	Column1		nvarchar(max)
)
AS
BEGIN

	DECLARE @Position	int,
			@Item		nvarchar(max);
	
	IF LEN(ISNULL(@List, '')) > 0
	BEGIN

		-- Need to tack a delimiter onto the end of the input string if one doesn't exist
		IF @List IS NULL SET @List = '';
		IF RIGHT(RTRIM(@List), 1) <> @Delimiter SET @List = @List  + @Delimiter;
		
		SET @Position =  PATINDEX('%' + @Delimiter + '%' , @List);
		
		WHILE @Position <> 0
		BEGIN
			SET @Item = LEFT(@List, @Position - 1);
		
			-- Insert item into the table that will be returned.	
			INSERT INTO @Table1 (Column1) VALUES (@Item);
		
			SET @List = STUFF(@List, 1, @Position, '');
			SET @Position =  PATINDEX('%' + @Delimiter + '%' , @List);
		END

	END

	RETURN
END

GO

