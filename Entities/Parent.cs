using System.Collections.Generic;
using LinqToDB.Mapping;

namespace Linq2dbTestProj.Entities
{
	[Table(Name = "Parent")]
	public class Parent
	{
		[PrimaryKey, Identity]
		public int Id { get; set; }

		[Association(ThisKey = "Id", OtherKey = "ParentId", CanBeNull = true, IsBackReference = true)]
		public IList<ParentPermission> ParentPermissions { get; set; }

		[Association(ThisKey = "Id", OtherKey = "ParentId", CanBeNull = true, IsBackReference = true)]
		public IList<Child> Childs { get; set; }
	}
}