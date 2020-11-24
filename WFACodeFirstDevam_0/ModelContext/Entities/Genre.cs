﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirstDevam_0.ModelContext.Entities
{
    public class Genre:BaseEntity
    {
        public string GenreName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual List<Movie> Movies { get; set; }


    }
}
