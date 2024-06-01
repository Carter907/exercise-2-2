```
BEGIN
	CLASS Program
		Main METHOD
			CONST INTEGER baseCost = 200
			CONST INTEGER hourlyRate = 150
			CONST INTEGER mileRate = 2

			PRINT
			- "how many hours will the move take?"
			VAR hours = (To Double)(PROMPT FOR INPUT)

			PRINT
			- "how many miles is the move"
			VAR miles = (To Double)(PROMPT FOR INPUT)

			PRINT
			- "Total: {FORMAT TO CURRENCY}", hours * hourlyRate + mileRate * miles + baseCost)
		END Main
	END Program
END
```
