using LicenCePlateApp.Entities;
using LicenCePlateApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace LicenCePlateApp.Repositories
{
    public class LicencePlateRepository
    {
        LicencePlateContext LicencePlateContext;

        public LicencePlateRepository(LicencePlateContext licencePlateContext)
        {
            LicencePlateContext = licencePlateContext;
        }

        public List<LicencePlate> SearchLicencePlateListByUserInput(string userInput)
        {
            var searchedList = (from searchedPlates in LicencePlateContext.LicencePlates
                                where searchedPlates.Plate.Contains(userInput)
                                select searchedPlates).ToList();
            return searchedList;
        }
    }
}
