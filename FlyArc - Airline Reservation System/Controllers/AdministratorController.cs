using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


    [Authorize]
public class AdministratorController : Controller
{
    private readonly AdministratorService administratorsService;
    private string administratorId;
    private string CustomerId;
    private object UserId;

    public AdministratorController(AdministratorService administratorsService)
    {
        this.administratorsService = administratorsService;
    }

    public ActionResult Index()
    {
        try
        {
            var administrator = administratorsService.GetAdministratorByAdministratorId(administratorId);
            var administratorCustomers = administratorsService.GetAdministratorCustomers(administratorId);

            return View(new AdministratorCustomersViewModel { Administrator = administrator, Customers = administratorCustomers });
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
    public IActionResult AddCustomer()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddCustomer([FromForm]AdministratorAddCustomerViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        try
        {
            administratorsService.AddCustomer(CustomerId, UserId, model.UserName, model.Password);
            return Redirect(Url.Action("Index", "Administrator"));
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }

    }



}
