﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSTrackerModel.SharedKernel
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }
}
