using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlerData.Models.ViewModels
{
    //This model is for packaging data about bowlers with page data to pass in together
    public class IndexViewModel
    {
        public IEnumerable<Bowlers> Bowlers { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string TeamName { get; set; }
    }
}
