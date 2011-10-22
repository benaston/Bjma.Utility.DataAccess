
namespace NHibernate.Linq.Tests.Entities
{
	public class UserComponent
	{
		public string Property1 { get; set; }
		public string Property2 { get; set; }
		public UserComponent2 OtherComponent { get; set; }
	}

	public class UserComponent2
	{
		public string OtherProperty1 { get; set; }
	}
}
