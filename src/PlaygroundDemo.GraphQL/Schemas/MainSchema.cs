using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using PlaygroundDemo.Queries.Container;
using System;

namespace PlaygroundDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}