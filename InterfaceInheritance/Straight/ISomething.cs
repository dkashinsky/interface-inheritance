namespace InterfaceInheritance.Straight
{
	// Non-generic interface.
	interface ISomething
	{
		bool CheckSomething(object thing);
	}
	
	// Usual approach of generics is to inherit from non-generic. 
	// We can see this in IEnumerable for example.
	interface ISomething<T> : ISomething
	{
		bool CheckSomething(T thing);
	}
}
