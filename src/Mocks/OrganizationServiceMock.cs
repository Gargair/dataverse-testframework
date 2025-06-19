using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace DataverseTestFramework.Mocks
{
    internal class OrganizatinServiceMock : IOrganizationService
    {
        void IOrganizationService.Associate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            throw new NotImplementedException();
        }

        Guid IOrganizationService.Create(Entity entity)
        {
            throw new NotImplementedException();
        }

        void IOrganizationService.Delete(string entityName, Guid id)
        {
            throw new NotImplementedException();
        }

        void IOrganizationService.Disassociate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            throw new NotImplementedException();
        }

        OrganizationResponse IOrganizationService.Execute(OrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        Entity IOrganizationService.Retrieve(string entityName, Guid id, ColumnSet columnSet)
        {
            throw new NotImplementedException();
        }

        EntityCollection IOrganizationService.RetrieveMultiple(QueryBase query)
        {
            throw new NotImplementedException();
        }

        void IOrganizationService.Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}