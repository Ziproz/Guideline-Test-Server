using Services.DataObjects;
using System.Collections.Generic;

namespace GuidelineTest.ServicesBL
{
    public class OrganizationServiceBL : IOrganizationService
    {

        public OrganizationServiceBL() { }

        //async
        public IEnumerable<Worker> GetWorkerList()
        {
            IEnumerable<Worker> list = new List<Worker>();

            return list;
        }
    }
}
