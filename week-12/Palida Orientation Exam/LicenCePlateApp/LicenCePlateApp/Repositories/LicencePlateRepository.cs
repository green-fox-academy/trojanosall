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
                                where searchedPlates.Plate.StartsWith(userInput)
                                select searchedPlates).ToList();
            return searchedList;
        }

        public List<LicencePlate> SearchPoliceCarList()
        {
            string policeCarCode = "RB";

            var searchedList = (from searchedPlates in LicencePlateContext.LicencePlates
                                where searchedPlates.Plate.StartsWith(policeCarCode)
                                select searchedPlates).ToList();
            return searchedList;
        }

        public List<LicencePlate> SearchDiplomatsCarList()
        {
            string diplomatsCarCode = "DT";

            var searchedList = (from searchedPlates in LicencePlateContext.LicencePlates
                                where searchedPlates.Plate.StartsWith(diplomatsCarCode)
                                select searchedPlates).ToList();
            return searchedList;
        }

        public List<LicencePlate> RefineTheOriginalSearchingBasedOnBrand(string brandName)
        {
            var searchedList = (from searchedPlates in LicencePlateContext.LicencePlates
                                where searchedPlates.Brand == brandName
                                select searchedPlates).ToList();
            return searchedList;
        }
    }
}
