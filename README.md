BEGIN
	CLASS Program
		Main METHOD
			const int baseCost = 200;
        			const int hourlyRate = 150;
        			const int mileRate = 2;
	   			Console.WriteLine("how many hours will the move take?");
        			var hours = Convert.ToDouble(Console.ReadLine());
	   			Console.WriteLine("how many miles is the move");
        			var miles = Convert.ToDouble(Console.ReadLine());
        			Console.WriteLine("Total: {0:C}", hours*hourlyRate + mileRate * miles + baseCost);
		END Main
	END Program
END
