﻿using CoreApi.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Services.Contratos
{
    public interface IEmailServices : IDisposable
    {
        void EnviarEmailCopiaOculta();
    }
}
