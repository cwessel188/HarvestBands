using AutoMapper;
using HarvestBands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarvestBands
{
    public class AutoMapperStartup
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<Band, BandIndexDTO>();

            // TODO create more band DTOs
        }

    }
}