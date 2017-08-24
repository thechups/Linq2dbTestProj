using System.Linq;
using LinqToDB.Linq;
using Xunit;

namespace Linq2dbTestProj
{
    public class TestClass
    {
		[Fact]
	    public void InvalidQuery()
		{
			LinqToDB.Common.Configuration.Linq.AllowMultipleQuery = true;

			var userId = 10;
			var childId = 100;

			using (var db = new Linq2DbTestDb())
		    {
			    var query = db.Parents
				    .Where(p => p.ParentPermissions.Any(permission => permission.UserId == userId))
				    .SelectMany(parent => parent.Childs)
					.Where(child => child.Id == childId)
					.Select(child => child.Parent);

			    var sql = ((IExpressionQuery) query).SqlText;

				Assert.Null(sql);
		    }
		}
    }
}
