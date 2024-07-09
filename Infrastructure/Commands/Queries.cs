using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public static class Queries
    {
        public static class Entity1
        {
            public const string Get = @"
                SELECT [Id]
					,[Prop1]
					,[Prop2]
					,[Prop3]
				FROM [dbo].[Table_Entity1]
				WHERE Id=@id
            ";

            public const string GetAll = "GetAll Query";
        }

        public static class Entity2
        {

        }
    }
}
