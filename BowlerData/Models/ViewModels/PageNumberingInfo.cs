using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//This file has the model info for page numbers, including for how many results to show
namespace BowlerData.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }
        public int NumPages => (int) (Math.Ceiling((decimal)TotalNumItems/NumItemsPerPage));
    }
}
