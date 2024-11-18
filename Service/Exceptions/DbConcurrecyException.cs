namespace Bookstore.Service.Exceptions
{
	public class DbConcurrecyException : ApplicationException
	{
		public DbConcurrecyException(string message) : base(message) 
		{

		}
	}
}
