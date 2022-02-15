﻿using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IService
{
    public interface ICursoService
    {
        Task<List<Curso>> GetCursos(string rbd, int anoCursando);
    }
}
