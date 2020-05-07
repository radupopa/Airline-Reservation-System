using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Services;
//using FlyArcARS.ApplicationLogic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


    [Authorize]
public class CustomerController : Controller
{
    private readonly UserManager<IdentityUser> userManager;
    private readonly CustomerService customersService;
    public CustomerController(UserManager<IdentityUser> userManager, CustomerService customersService)
    {
        this.customersService = customersService;
    }

    public ActionResult Index()
    {
        try
        {
            var userId = userManager.GetUserId(User);
            var customer = customersService.GetCustomerByUserId(userId);
            var customerPassengers = customersService.GetCustomerPassengers(userId);

            return View(new CustomerPassengersViewModel { Customer = customer, Passengers = customerPassengers });
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }
        catch (Exception)
        {
            return BadRequest("Invalid request received ");
        }
    }

    [HttpGet]
    public IActionResult AddPassenger()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddPassenger([FromForm]CustomerAddPassengerViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        try
        {
            var userId = userManager.GetUserId(User);
            customersService.AddPassenger(userId, model.FirstName, model.LastName, model.Address, model.City, model.Country, model.Age);
            return Redirect(Url.Action("Index", "Customer"));
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }

    }



}
