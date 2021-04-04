using BowlerData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//This file collects and brings in the info about the Teams
namespace BowlerData.Components
{
    public class TeamsViewComponent : ViewComponent
    {
        private BowlingLeagueContext _context;

        public TeamsViewComponent (BowlingLeagueContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
