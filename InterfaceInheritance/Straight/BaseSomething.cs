namespace InterfaceInheritance.Straight
{
	//abstract class to implement non generic interface, and expose generic method to be implemented
	abstract class BaseSomething<T> : ISomething<T>
	{
		//let user implement generic interface
		public abstract bool CheckSomething(T thing);

		//process non-generic version internally
		public bool CheckSomething(object thing)
		{
			return CheckSomething((T)thing);
		}
	}
}
