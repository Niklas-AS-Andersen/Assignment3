using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment02
{
    public class Queries
    {
        public static IEnumerable<string> ReturnRowlingExt()
        {
            var wizards =  Wizard.Wizards.Value;

            var wizardNames = wizards.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);
            return wizardNames;
        }

        public static IEnumerable<string> ReturnRowlingLinq()
        {
            var wizards =  Wizard.Wizards.Value;

            var wizardNames = from w in wizards
                              where w.Creator.Contains("Rowling")
                              select w.Name;
            return wizardNames;
        }

        public static int? ReturnFirstSithlordYearExt()
        {
            var wizards = Wizard.Wizards.Value;

            var vader = wizards.Where(w => w.Name.StartsWith("Darth")).OrderBy(w => w.Year).First().Year;

            return vader;
        }

        public static int? ReturnFirstSithlordYearLinq()
        {
            var wizards = Wizard.Wizards.Value;

            var vader = (from w in wizards
                        where w.Name.StartsWith("Darth")
                        orderby w.Year
                        select w.Year).First();
            return vader;
        }

        public static IEnumerable<(string, int?)> ReturnHarryPotterBooksNameAndYearExt()
        {
            var wizards = Wizard.Wizards.Value;
            
            var harry = wizards.Where(w => w.Medium.StartsWith("Harry Potter")).Select(w => (w.Name,w.Year)).Distinct();

            return harry;
        }

        public static IEnumerable<(string, int?)> ReturnHarryPotterBooksNameAndYearLinq()
        {
            var wizards = Wizard.Wizards.Value;

            var harry = (from w in wizards
                        where w.Medium.StartsWith("Harry Potter")
                        select (w.Name,w.Year)).Distinct();
            return harry;
        }

        public static IEnumerable<string> ReturnWizardNamesGroupedByCreatorReverseOrderExt()
        {
            var wizards = Wizard.Wizards.Value;
            
            var reverse = wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).Select(w => w.Name);
            
            return reverse;
        }

        public static IEnumerable<string> ReturnWizardNamesGroupedByCreatorReverseOrderLinq()
        {
            var wizards = Wizard.Wizards.Value;

            var reverse = from w in wizards
                          orderby w.Creator descending, w.Name 
                          select w.Name;

            return reverse;
        }
    }
}
