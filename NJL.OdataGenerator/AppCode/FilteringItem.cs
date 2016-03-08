using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJL.OdataGenerator.AppCode
{
    class FilteringItem
    {
        public AttributeTypeCode Atc { get; set; }
        public string SchemaName { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            var returnedString = string.Empty;
            switch (Atc)
            {
                case AttributeTypeCode.String:
                case AttributeTypeCode.Memo:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0} eq '{1}'", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0} ne '{1}'", SchemaName, Value);
                            break;
                        case "Ends With":
                            returnedString = string.Format("endswith({0}, '{1}')", SchemaName, Value);
                            break;
                        case "Starts With":
                            returnedString = string.Format("startswith({0}, '{1}')", SchemaName, Value);
                            break;
                        case "Substring Of":
                            returnedString = string.Format("substringof('{0}', {1})", Value, SchemaName);
                            break;
                    }

                    break;

                case AttributeTypeCode.DateTime:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0} eq datetime'{1}'", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0} ne datetime'{1}'", SchemaName, Value);
                            break;
                        case "Greater than":
                            returnedString = string.Format("{0} gt datetime'{1}'", SchemaName, Value);
                            break;
                        case "Greater than or equal":
                            returnedString = string.Format("{0} ge datetime'{1}'", SchemaName, Value);
                            break;
                        case "Less than":
                            returnedString = string.Format("{0} lt datetime'{1}'", SchemaName, Value);
                            break;
                        case "Less than or equal":
                            returnedString = string.Format("{0} le datetime'{1}'", SchemaName, Value);
                            break;
                    }
                    break;

                case AttributeTypeCode.Money:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0}/Value eq {1}", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0}/Value ne {1}", SchemaName, Value);
                            break;
                        case "Greater than":
                            returnedString = string.Format("{0}/Value gt {1}", SchemaName, Value);
                            break;
                        case "Greater than or equal":
                            returnedString = string.Format("{0}/Value ge {1}", SchemaName, Value);
                            break;
                        case "Less than":
                            returnedString = string.Format("{0}/Value lt {1}", SchemaName, Value);
                            break;
                        case "Less than or equal":
                            returnedString = string.Format("{0}/Value le {1}", SchemaName, Value);
                            break;
                    }
                    break;

                case AttributeTypeCode.BigInt:
                case AttributeTypeCode.Boolean:
                case AttributeTypeCode.Decimal:
                case AttributeTypeCode.Integer:
                case AttributeTypeCode.Double:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0} eq {1}", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0} ne {1}", SchemaName, Value);
                            break;
                        case "Greater than":
                            returnedString = string.Format("{0} gt {1}", SchemaName, Value);
                            break;
                        case "Greater than or equal":
                            returnedString = string.Format("{0} ge {1}", SchemaName, Value);
                            break;
                        case "Less than":
                            returnedString = string.Format("{0} lt {1}", SchemaName, Value);
                            break;
                        case "Less than or equal":
                            returnedString = string.Format("{0} le {1}", SchemaName, Value);
                            break;
                    }
                    break;

                case AttributeTypeCode.Customer:
                case AttributeTypeCode.Lookup:
                case AttributeTypeCode.Owner:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0}/Id eq (guid'{1}')", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0}/Id ne (guid'{1}')", SchemaName, Value);
                            break;
                    }
                    break;

                case AttributeTypeCode.Uniqueidentifier:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0} eq (guid'{1}')", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0} ne (guid'{1}')", SchemaName, Value);
                            break;
                    }
                    break;

                case AttributeTypeCode.Picklist:
                case AttributeTypeCode.State:
                case AttributeTypeCode.Status:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0}/Value eq {1}", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0}/Value ne {1}", SchemaName, Value);
                            break;
                    }
                    break;

                default:

                    switch (Operator)
                    {
                        case "Equal":
                            returnedString = string.Format("{0} eq '{1}'", SchemaName, Value);
                            break;
                        case "Not Equal":
                            returnedString = string.Format("{0} ne '{1}'", SchemaName, Value);
                            break;
                        case "Greater than":
                            returnedString = string.Format("{0} gt '{1}'", SchemaName, Value);
                            break;
                        case "Greater than or equal":
                            returnedString = string.Format("{0} ge '{1}'", SchemaName, Value);
                            break;
                        case "Less than":
                            returnedString = string.Format("{0} lt '{1}'", SchemaName, Value);
                            break;
                        case "Less than or equal":
                            returnedString = string.Format("{0} le '{1}'", SchemaName, Value);
                            break;
                        case "Ends With":
                            returnedString = string.Format("endswith({0}, '{1}')", SchemaName, Value);
                            break;
                        case "Starts With":
                            returnedString = string.Format("startswith({0}, '{1}')", SchemaName, Value);
                            break;
                        case "Substring Of":
                            returnedString = string.Format("substringof('{0}', {1})", Value, SchemaName);
                            break;
                    }
                    break;
            }

            return returnedString;
        }
    }
}
