using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Data;
using FlyArcARS.ApplicationLogic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


    [Authorize]
public class FlightController : Controller
{
    private readonly FlightsService flightsService;
    public FlightController(FlightService flightsService)
    {
        this.flightservice = flightsService;
    }

    public ActionResult Index()
    {
        try
        {
            var flight = flightsService.GetFlightByFlightId(FlightId);
            var flightTicket = flightsService.GetFlightTickets(FlightId);

            return View(new FlightTicketsViewModel { Flight = flight, Tickets = flightTickets });
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
    public IActionResult AddCourse()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddTicket([FromForm]FlightAddTicketViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        try
        {
            flightsService.AddTicket(Ticket, model.PassengerFirstName, model.PassengerLastName, model.Type);
            return Redirect(Url.Action("Index", "Flight"));
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }

    }



}
