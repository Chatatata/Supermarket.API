﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public IList<PoolPickHandle> PoolPickHandles { get; set; } = new List<PoolPickHandle>();
    }
}
