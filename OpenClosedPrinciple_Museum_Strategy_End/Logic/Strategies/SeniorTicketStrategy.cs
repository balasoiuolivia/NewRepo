﻿namespace OpenClosedPrinciple_Museum_Strategy_End.Logic.Strategies
{
    public class SeniorTicketStrategy : ITicketStrategy
    {
        public double TicketPriceMultiplier
        {
            get
            {
                return 0.5;
            }
        }
    }
}
