using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarvestBands.Models
{
    public class Score
    {
        public decimal MusicEnsembleScore { get; set; }
        public decimal MusicIndividualPerformance { get; set; }
        public decimal Percussion { get; set; }
        public decimal MusicPerformanceAverage { get; set; }
        public decimal VisualPerformanceEnsemble { get; set; }
        public decimal VisualPerformanceIndividual { get; set; }
        public decimal Auxilary { get; set; }
        public decimal VisualPerformanceAverage { get; set; }
        public decimal MusicalEffect { get; set; }
        public decimal VisualEffect { get; set; }
        public decimal EffectAverage { get; set; }
        public decimal DrumMajor { get; set; }
        public decimal FinalScore { get; set; }
    }
}