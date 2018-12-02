namespace InterfaceInheritance.Inverted
{
	//nature of interface is generic
	//T is defined with 'in' keyword which allows contravariance
	interface ISomething<in T>
	{
		bool CheckSomething(T thing);
	}

	//non-generic version is based on generic where T is object.
	//this way we don't need to implement 2 separate methods intended for the same thing
	interface ISomething : ISomething<object> { }
}
