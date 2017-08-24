using Linq2dbTestProj.Entities;
using LinqToDB;

namespace Linq2dbTestProj
{
	public class Linq2DbTestDb : LinqToDB.Data.DataConnection
	{
		public Linq2DbTestDb() : base("Linq2DbTestDb") { }

		public ITable<Parent> Parents { get { return GetTable<Parent>(); } }
	}
}