// GraphQL/Mutations/Mutation.cs
using HotChocolate;
using NailPressApi.Data;
using NailPressApi.Models;

namespace NailPressApi.GraphQL.Mutations
{
    public class Mutation
    {
        public async Task<Listing> AddListing(
            NailPressDb db,
            string title)
        {
            var listing = new Listing { Title = title };
            db.Listings.Add(listing);
            await db.SaveChangesAsync();
            return listing;
        }
    }
}