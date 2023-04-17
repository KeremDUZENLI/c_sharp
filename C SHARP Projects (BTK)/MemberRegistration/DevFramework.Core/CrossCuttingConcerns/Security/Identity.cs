﻿using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace DevFramework.Core.CrossCuttingConcerns.Security
{
    public class Identity : IIdentity
    {
        public string AuthenticationType { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Name { get; set; }


        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }

    }
}
