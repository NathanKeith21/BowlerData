using BowlerData.Models;
using BowlerData.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BowlerData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BowlingLeagueContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int? teamId, string team, int pageNum = 0)
        {
            int pageSize = 5;

            return View(new IndexViewModel
            {
                Bowlers = (_context.Bowlers
                .FromSqlInterpolated($"SELECT * FROM Bowlers WHERE TeamId = {teamId} OR {teamId} IS NULL ORDER BY BowlerLastName, BowlerFirstName")
                .Skip(pageSize * (pageNum - 1))
                .Take(pageSize)
                .ToList()),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalNumItems = (teamId == null ? _context.Bowlers.Count() :
                        _context.Bowlers.Where(x => x.TeamId == teamId).Count())
                },

                TeamName = team
            }); ;
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
