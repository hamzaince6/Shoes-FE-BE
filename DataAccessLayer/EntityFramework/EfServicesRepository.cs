﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;

namespace DataAccessLayer.EntityFramework;

public class EfServicesRepository: GenericRepository<Services>, IServicesDal
{
    
}