﻿using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IRepository
{
    public interface IReunionesRepository
    {
        Task CreateReunion(Reuniones reuniones);
        Task <Reuniones>GetReunionById(int id);
    }
    
}
