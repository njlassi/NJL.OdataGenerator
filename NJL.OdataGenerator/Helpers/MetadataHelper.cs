// PROJECT : NJL.OdataGenerator
// This plugin was developed by Nizar JLASSI

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox;
using NJL.OdataGenerator.AppCode;

namespace NJL.OdataGenerator.Helpers
{
    /// <summary>
    /// Class for querying Crm Metadata 
    /// </summary>
    class MetadataHelper
    {
        /// <summary>
        /// Gets the list of entities metadata (only Entity Items)
        /// </summary>
        /// <returns>List of entities metadata</returns>
        public static List<EntityMetadata> RetrieveEntities(IOrganizationService oService)
        {
            List<EntityMetadata> entities = new List<EntityMetadata>();

            RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest
                                                     {
                EntityFilters = EntityFilters.Entity
            };

            RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)oService.Execute(request);

            foreach (EntityMetadata emd in response.EntityMetadata)
            {
                if (emd.DisplayName.UserLocalizedLabel != null && (emd.IsCustomizable.Value || emd.IsManaged.Value == false))
                {
                    entities.Add(emd);
                }
            }

            return entities;
        }

        /// <summary>
        /// Gets specified entity metadata (include attributes)
        /// </summary>
        /// <param name="logicalName">Logical name of the entity</param>
        /// <param name="oService">Crm organization service</param>
        /// <returns>Entity metadata</returns>
        public static EntityMetadata RetrieveEntityAttributes(string logicalName, IOrganizationService oService)
        {
            try
            {
                RetrieveEntityRequest request = new RetrieveEntityRequest
                                                    {
                    LogicalName = logicalName,
                    EntityFilters = EntityFilters.Attributes,
                    RetrieveAsIfPublished = true
                };

                RetrieveEntityResponse response = (RetrieveEntityResponse)oService.Execute(request);

                return response.EntityMetadata;
            }
            catch (Exception error)
            {
                string errorMessage = CrmExceptionHelper.GetErrorMessage(error, false);
                throw new Exception("Error while retrieving entity: " + errorMessage);
            }
        }


        /// <summary>
        /// Gets specified entity Relationships
        /// </summary>
        /// <param name="logicalName">Logical name of the entity</param>
        /// <param name="oService">Crm organization service</param>
        /// <returns>Entity metadata</returns>
        public static EntityMetadata RetrieveEntityRelationShips(string logicalName, IOrganizationService oService)
        {
            try
            {
                RetrieveEntityRequest request = new RetrieveEntityRequest
                {
                    LogicalName = logicalName,
                    EntityFilters = EntityFilters.Relationships,
                    RetrieveAsIfPublished = true
                };

                RetrieveEntityResponse response = (RetrieveEntityResponse)oService.Execute(request);

                return response.EntityMetadata;
            }
            catch (Exception error)
            {
                string errorMessage = CrmExceptionHelper.GetErrorMessage(error, false);
                throw new Exception("Error while retrieving entity: " + errorMessage);
            }
        }


        public static List<OptionSetItem> GetOptionSetTextsAndValues(string optionSetName, string entityName, IOrganizationService oService)
        {
            RetrieveAttributeRequest request = new RetrieveAttributeRequest();
            request.EntityLogicalName = entityName;
            request.LogicalName = optionSetName;
            request.RetrieveAsIfPublished = true;

            RetrieveAttributeResponse response = (RetrieveAttributeResponse)oService.Execute(request);
            PicklistAttributeMetadata picklist = (PicklistAttributeMetadata)response.AttributeMetadata;

            var query = from option in picklist.OptionSet.Options
                        select new OptionSetItem { Text = option.Label.UserLocalizedLabel.Label, Value = option.Value.Value };
            return query.ToList<OptionSetItem>();
        }


        public static List<OptionSetItem> GetStatusCodeTextsAndValues(string entityName, IOrganizationService oService)
        {
            RetrieveAttributeRequest request = new RetrieveAttributeRequest
            {
                EntityLogicalName = entityName,
                LogicalName = "statuscode",
                RetrieveAsIfPublished = true
            };
            RetrieveAttributeResponse response = (RetrieveAttributeResponse)oService.Execute(request);
            StatusAttributeMetadata statusMetadata = (StatusAttributeMetadata)response.AttributeMetadata;


            var query = from option in statusMetadata.OptionSet.Options
                        select new OptionSetItem { Text = ((StatusOptionMetadata)option).Label.UserLocalizedLabel.Label, Value = ((StatusOptionMetadata)option).State.Value };
            return query.ToList<OptionSetItem>();

        }


        public static List<OptionSetItem> GetStateCodeTextsAndValues(string entityName, IOrganizationService oService)
        {
            RetrieveAttributeRequest request = new RetrieveAttributeRequest
            {
                EntityLogicalName = entityName,
                LogicalName = "statecode",
                RetrieveAsIfPublished = true
            };
            RetrieveAttributeResponse response = (RetrieveAttributeResponse)oService.Execute(request);
            StateAttributeMetadata stateMetadata = (StateAttributeMetadata)response.AttributeMetadata;


            var query = from option in stateMetadata.OptionSet.Options
                        select new OptionSetItem { Text = ((StateOptionMetadata)option).Label.UserLocalizedLabel.Label, Value = ((StateOptionMetadata)option).Value.Value };
            return query.ToList<OptionSetItem>();

        }
    }
}