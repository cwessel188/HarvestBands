using HarvestBands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace HarvestBands.Services
{
    public class BandService : HarvestBands.Services.IBandService
    {
        // ensures this clas uses only generics
        private IGenericRepository _repo;

        // maps the generic repo to one that's more useful
        public BandService(IGenericRepository repo)
        {
            _repo = repo;
        }
        /// <summary>
        /// creates a list of BandIndexDTOs
        /// </summary>
        /// <returns></returns>
        public IList<BandIndexDTO> IndexList()
        {

            var bandIndexDTOs = _repo.Query<Band>().Project().To<BandIndexDTO>();
            return bandIndexDTOs.ToList();
        }

    }
}