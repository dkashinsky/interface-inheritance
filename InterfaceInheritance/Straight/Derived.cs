namespace InterfaceInheritance.Straight
{
	// When we inherit from generic, we still need to implement non generic version of interface
	class LessThan25 : ISomething<string>
	{
		//generic interface method
		public bool CheckSomething(string thing)
		{
			return thing.Length < 25;
		}
		
		//non generic interface method
		public bool CheckSomething(object thing)
		{
			return CheckSomething((string)thing);
		}
	}

	//the other way is to use some base abstract class, and write less in derived
	//it may work, but seems a bit complicated.
	class LessThan50 : BaseSomething<string>
	{
		//non generic version is implemented internally so we only need to implement actual generic method
		public override bool CheckSomething(string thing)
		{
			return thing.Length < 50;
		}
	}
}
