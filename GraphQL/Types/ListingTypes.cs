using HotChocolate.Types;
using NailPressApi.Models;

namespace NailPressApi.GraphQL.Types
{
    public class ListingType : ObjectType<Listing>
    {
        protected override void Configure(IObjectTypeDescriptor<Listing> descriptor)
        {
            descriptor.Field(l => l.Id).Type<IdType>();
            descriptor.Field(l => l.Title).Type<StringType>();
        }
    }
}