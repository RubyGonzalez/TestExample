﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Northwind.ORM.ServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TestService.svc or TestService.svc.cs at the Solution Explorer and start debugging.
    public class TestService : ITestService
    {
        public void DoWork()
        {
        }


        public string WhoAmI()
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
                return Thread.CurrentPrincipal.Identity.Name;
            return @"DAN001\Haeckr";
        }
    }
}
