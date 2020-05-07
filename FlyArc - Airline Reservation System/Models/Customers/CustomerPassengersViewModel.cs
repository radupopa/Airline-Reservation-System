using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Data;


public class CustomerPassengersViewModel
{
    public Customer Customer { get; set; }
    public IEnumerable<Passenger> Passengers { get; set; }
}
