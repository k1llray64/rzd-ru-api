﻿using System;
using System.Collections.Generic;

namespace Kaolin.Models.Rail
{
    public class ReserveCreate
    {
        public class Request
        {
            public OptionParams Option { get; set; }
            public Person[] Passengers { get; set; }

            public class OptionParams
            {
                public string SessionId { get; set; }
                public int TrainOptionRef { get; set; }
                public int CarOptionRef { get; set; }
                public PlacesRange Range { get; set; }
                public bool Bedding { get; set; }
                public string Updown { get; set; }
                public string Location { get; set; }
            }

            public class PlacesRange
            {
                public int From { get; set; }
                public int To { get; set; }
            }
        }


        public class Result
        {
            public string SaleOrderId { get; set; }
            public Price Price { get; set; }
            public IEnumerable<ResultOrder> Orders { get; set; }
            public IEnumerable<PaymentSystem> PaymentSystems { get; set; }

            public class ResultOrder
            {
                public string OrderId { get; set; }
                public decimal Cost { get; set; }
                public decimal TotalCostPt { get; set; }

                public TrainInfo Train { get; set; }
                public Car Car { get; set; }
                public IEnumerable<Ticket> Tickets { get; set; }

                public string Created { get; set; }
                public string SeatNums { get; set; }
                public string DirName { get; set; }
                public string Agent { get; set; }
                //public bool DeferredPayment { get; set; }
            }

            public class Car
            {
                public string Number { get; set; }
                public CarType Type { get; set; }
                public string ServiceClass { get; set; }
                public string AdditionalInfo { get; set; }
            }

            public class Ticket
            {
                public string TicketId { get; set; }
                public decimal Cost { get; set; }
                public string Seats { get; set; }
                public string SeatsType { get; set; }
                public Tariff Tariff { get; set; }
                public bool Teema { get; set; }
                public IEnumerable<ResultPassenger> Passengers { get; set; } // TODO: change to Person
            }

            public class Tariff
            {
                public string Code { get; set; }
                public string Name { get; set; }

                public Tariff(string code, string name)
                {
                    Code = code;
                    Name = name;
                }
            }

            public class ResultPassenger
            {
                public Gender Gender { get; set; }
                public string FirstName { get; set; }
                public string MiddleName { get; set; }
                public string LastName { get; set; }
                public DateTime? BirthDate { get; set; }
                public int DocType { get; set; }
                public string DocTypeName { get; set; }
                public string DocNumber { get; set; }
                public int Insurance { get; set; } // TODO: add insurance, ref #49
            }

            public class PaymentSystem
            {
                public int Id { get; set; }
                public string Code { get; set; }
                public string Name { get; set; }
                public string Tip { get; set; }
            }
        }
    }
}
