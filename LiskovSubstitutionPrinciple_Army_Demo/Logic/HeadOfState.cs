﻿using System;

namespace LiskovSubstitutionPrinciple_Army_Demo.Logic
{
    public class HeadOfState : Officer
    {
        public HeadOfState(int id, string name, string rank)
            : base(id, name, rank)
        {
        }

        public override void ReportToSuperior()
        {
            throw new NotImplementedException();
        }

        public void DeclareWar()
        {
            Console.WriteLine("WAAAAR");
        }
    }
}
