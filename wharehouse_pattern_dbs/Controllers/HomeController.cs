using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wharehouse_pattern_dbs.Models;
using wharehouse_pattern_dbs.Roles;

namespace wharehouse_pattern_dbs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Testes
            string factoryName = "ConcellorFactory"; // Replace with the desired factory name

            Type factoryType = Type.GetType("wharehouse_pattern_dbs.Roles." + factoryName); // Adjust the namespace
            if (factoryType != null)
            {
                RolesFactory rolesFactory = (RolesFactory)Activator.CreateInstance(factoryType);

                if (rolesFactory == null) return View();
                
                IRoles role = rolesFactory.CreateRole();
                ViewBag.Message = role.GetRoleName();
            }
            else
            {
                // Handle the case where the factory type is not found
            }

            
            //RolesFactory rolesFactory = new AdminFactory();
            //IRoles role = rolesFactory.CreateRole();
            
            
            return View();
        }

        public async Task<IActionResult> SetExernal()
        {
            //Testes
            string factoryName = "ExternalFactory"; // Replace with the desired factory name

            Type factoryType = Type.GetType("wharehouse_pattern_dbs.Roles." + factoryName); // Adjust the namespace
            if (factoryType != null)
            {
                RolesFactory rolesFactory = (RolesFactory)Activator.CreateInstance(factoryType);

                if (rolesFactory == null) return View("Index");
                
                IRoles role = rolesFactory.CreateRole();
                ViewBag.Message = role.GetRoleName();
            }

            return View("Index");
        }
        
        public async Task<IActionResult> SetConcellor()
        {
            //Testes
            string factoryName = "ConcellorFactory"; // Replace with the desired factory name

            Type factoryType = Type.GetType("wharehouse_pattern_dbs.Roles." + factoryName); // Adjust the namespace
            if (factoryType != null)
            {
                RolesFactory rolesFactory = (RolesFactory)Activator.CreateInstance(factoryType);

                if (rolesFactory == null) return View("Index");
                
                IRoles role = rolesFactory.CreateRole();
                ViewBag.Message = role.GetRoleName();
            }

            return View("Index");
        }
        
        public async Task<IActionResult> SetAdmin()
        {
            //Testes
            string factoryName = "AdminFactory"; // Replace with the desired factory name

            Type factoryType = Type.GetType("wharehouse_pattern_dbs.Roles." + factoryName); // Adjust the namespace
            if (factoryType != null)
            {
                RolesFactory rolesFactory = (RolesFactory)Activator.CreateInstance(factoryType);

                if (rolesFactory == null) return View("Index");
                
                IRoles role = rolesFactory.CreateRole();
                ViewBag.Message = role.GetRoleName();
            }

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}