﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel
{
    public class UserRegistrationDTO
    {
        public int AuthId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }  // Mund të shtohet nëse është pjesë e event-it
    }
}
