namespace InterfaceInheritance.Inverted
{
	// When we inherit from generic, no need to implement non generic as it is already here
	// due to inversed inheritance and contravariance
	class LessThan25 : ISomething<string>
	{
		//generic interface method
		public bool CheckSomething(string thing)
		{
			return thing.Length < 25;
		}
	}

	//no need to have separate abstract base implementation
}
