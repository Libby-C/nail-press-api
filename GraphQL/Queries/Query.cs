// GraphQL/Queries/Query.cs
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using NailPressApi.Data;
using NailPressApi.Models;

namespace NailPressApi.GraphQL.Queries
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Listing> GetListings(NailPressDb db)
            => db.Listings;
    }
}
