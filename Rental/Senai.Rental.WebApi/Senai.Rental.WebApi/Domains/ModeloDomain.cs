﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Domains
{
    public class ModeloDomain
    {
        public int IdModelo { get; set; }
        public string NomeModelo { get; set; }
        public int IdMarca { get; set; }

        public MarcaDomain marca { get; set; }
    }
}
