using System;
namespace HarvestBands.Services
{
    public interface IBandService
    {
        System.Collections.Generic.IList<HarvestBands.Models.BandIndexDTO> IndexList();
    }
}
