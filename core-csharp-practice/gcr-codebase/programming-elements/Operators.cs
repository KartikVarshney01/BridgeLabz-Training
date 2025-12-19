class Operators {
	static void Main(string[] args) {
			int a = 10;
			int b = 5;
			
			bool x = true;
			bool y = false;
			
			// 1. Arithmetic Operators
			
			Console.WriteLine("Arithmetic Operators");
			Console.WriteLine();
			Console.WriteLine("Addition: " + (a + b)); // 15 - Addition Operator
			Console.WriteLine("Subtraction: " + (a - b)); // 5 - Subtraction
			Console.WriteLine("Multiplication: " + (a * b)); // 50 - Multiplication
			Console.WriteLine("Division: " + (a / b)); // 2 - Division
			Console.WriteLine("Modulus: " + (a % b)); // 0 - Modulus
			Console.WriteLine();
			
			// 2. Relational Operators
			
			Console.WriteLine("Relational Operators");
			Console.WriteLine();
			Console.WriteLine("a == b: " + (a == b)); // false - Equal To
			Console.WriteLine("a != b: " + (a != b)); // true - Not Equal To
			Console.WriteLine("a > b: " + (a > b)); // true - Greater Than
			Console.WriteLine("a < b: " + (a < b)); // false - Less Than
			Console.WriteLine("a >= b: " + (a >= b)); // true - Greater Than or Equal To
			Console.WriteLine("a <= b: " + (a <= b)); // false - Less Than or Equal To
			Console.WriteLine();
			
			// 3. Logical Operators
			
			Console.WriteLine("Logical Operators");
			Console.WriteLine();
			Console.WriteLine("x && y: " + (x && y)); // false - Logical And (&&)
			Console.WriteLine("x || y: " + (x || y)); // true - Logical Or (||)
			Console.WriteLine("!x: " + (!x)); // false - Logical Not (!)
			Console.WriteLine("!y: " + (!y)); // true - Logical Not (!)
			Console.WriteLine();
			
			// 4. Assignment Operators
			
			Console.WriteLine("Assignment Operators");
			Console.WriteLine();
			a += b; // a = a + b
			Console.WriteLine("a += b: " + a); // 15 - Addition assignment (+=)

			a -= b; // a = a - b
			Console.WriteLine("a -= b: " + a); // 10 - Subtraction assignment (-=)

			a *= b; // a = a * b
			Console.WriteLine("a *= b: " + a); // 50 - Multiplication assignment (*=)

			a /= b; // a = a / b
			Console.WriteLine("a /= b: " + a); // 10 - Division assignment (/=)

			a %= b; // a = a % b
			Console.WriteLine("a %= b: " + a); // 0 - Modulus assignment (%=)
			Console.WriteLine();
			
			// 5. Unary Operators
			
			Console.WriteLine("Unary Operators");
			Console.WriteLine();
			Console.WriteLine("a: " + a); // 0
			Console.WriteLine("++a: " + ++a); // 1 (pre-increment)
			Console.WriteLine("a++: " + a++); // 1 (post-increment)
			Console.WriteLine("a: " + a); // 2
			Console.WriteLine("--a: " + --a); // 1 (pre-decrement)
			Console.WriteLine("a--: " + a--); // 1 (post-decrement)
			Console.WriteLine("a: " + a); // 0
			Console.WriteLine();
			
			// 6. Ternary Operator
			
			Console.WriteLine("Ternary Operator");
			Console.WriteLine();
			int max = (a > b) ? a : b;
			Console.WriteLine("Max: " + max); // 10
			Console.WriteLine();
			
			// 7. is Operator
			
			Console.WriteLine("Is Operator");
			Console.WriteLine();
			Operators op = new Operators();
			Console.WriteLine("op is Operator : " + op is object);
			Console.WriteLine("op is Integer : " + op is int);
			Console.WriteLine();
	}
}

