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
    private readonly FlightService flightsService;
    private string FlightId;
    private IEnumerable<Ticket> flightTickets;

    public FlightService FlightService { get; }

    public FlightController(FlightService flightsService)
    {
        this.FlightService = flightsService;
    }

    public ActionResult Index()
    {
        try
        {
            var flight = flightsService.GetFlightByFlightId(FlightId);
            var flightTicket = flightsService.GetFlightsTickets(FlightId);

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
            var FlightId = GetFlightId();
            FlightService.AddTicket(FlightId, model.PassengerFirstName, model.PassengerLastName, model.Type);
            return Redirect(Url.Action("Index", "Flight"));
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }

    }

    private Flight GetFlightId()
    {
        return FlightService.GetFlightByFlightId(FlightId);
    }
}
