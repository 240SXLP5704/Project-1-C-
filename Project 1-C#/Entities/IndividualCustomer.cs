﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_C_.Entities;

public class IndividualCustomer:BaseCustomer
{
    public string FirstName { get; set;}
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    
}
