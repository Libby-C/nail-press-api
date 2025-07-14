using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using NailPressApi.Data;
using NailPressApi.Models;

namespace NailPressApi.GraphQL.Queries
{
    public class Query
    {
        public IQueryable<Listing> GetListings(NailPressDb db)
            => db.Listings;
    }
}
