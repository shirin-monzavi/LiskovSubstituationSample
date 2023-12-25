using LiskovSubstituationSample;

var numbers = new[] { 5, 7, 9, 8, 1, 6, 4 };

Calculator sumCalculator = new SumCalculator(numbers);


Console.WriteLine("Sum All Numbers " + sumCalculator.Calculate());


Calculator evenNumbersCalculator1 = new EvenNumbersCalculator(numbers);


Console.WriteLine("Sum Even Numbers " + evenNumbersCalculator1.Calculate());



Calculator evenNumbersCalculator2 = new EvenNumbersCalculator(numbers);
Console.WriteLine("Store child reference to parent " + evenNumbersCalculator2.Calculate());