using LinqToDB.Mapping;

namespace Linq2dbTestProj.Entities
{
	[Table(Name = "ParentPermission")]
	public class ParentPermission
	{
		[PrimaryKey, Identity]
		public int Id { get; set; }

		[Column, NotNull]
		public int ParentId { get; set; }

		[Column, NotNull]
		public int UserId { get; set; }
	}
}