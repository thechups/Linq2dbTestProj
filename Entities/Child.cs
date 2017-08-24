using LinqToDB.Mapping;

namespace Linq2dbTestProj.Entities
{
	[Table(Name = "Child")]
	public class Child
	{
		[PrimaryKey, Identity]
		public int Id { get; set; }

		[Column, NotNull]
		public int ParentId { get; set; }

		/// <summary>
		/// FK_ClientUsers_Clients
		/// </summary>
		[Association(ThisKey = "ParentId", OtherKey = "Id", CanBeNull = false)]
		public Parent Parent { get; set; }
	}
}