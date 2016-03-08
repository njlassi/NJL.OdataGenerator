using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJL.OdataGenerator.AppCode
{
    class OrderingItem
    {
        public string SchemaName { get; set; }
        public string Order { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", SchemaName, Order);
        }
    }


    class ExpandSelectItem
    {
        public string SchemaName { get; set; }
        public string RelationShipSchemaName { get; set; }
        public string RelationShipDisplayName { get; set; }

        public override string ToString()
        {
            return string.Format("{0}/{1}", RelationShipSchemaName, SchemaName);
        }
    }
}
