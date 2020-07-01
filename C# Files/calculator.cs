using System;
class Calculator {
  static void Main() {
    Console.Write("x = ");
	int x;
	
	try{
		x = Convert.ToInt32(Console.ReadLine());
	} catch(Exception e){
		Console.WriteLine("Invalid Entry");
		return;
	}
	
    Console.Write("y = ");
	int y;
	
    try{
		y = Convert.ToInt32(Console.ReadLine());
	} catch(Exception e){
		Console.WriteLine("Invalid Entry");
		return;
	}
    
    Console.WriteLine("Enter operator: ");
    char op = Convert.ToChar(Console.ReadLine()[0]);
    
    int result = 0;
    
	switch (op){
        case '+':
            result = x + y;
			Console.WriteLine("{0} {2} {1} = {3}", x, y, op, result);
            break;
        case '-':
            result = x - y;
			Console.WriteLine("{0} {2} {1} = {3}", x, y, op, result);
            break;
        case '*':
            result = x * y;
			Console.WriteLine("{0} {2} {1} = {3}", x, y, op, result);
            break;
        case '/':
			if(y == 0)
				Console.WriteLine("Cannot divide by zero");
			else{
				result = x / y;
				Console.WriteLine("{0} {2} {1} = {3}", x, y, op, result);
			}
            break;
        default:
            Console.WriteLine("Invalid Operator");
            break;
    }
}
}