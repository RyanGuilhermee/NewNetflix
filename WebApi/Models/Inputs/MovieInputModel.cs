﻿using Domain.Models;

namespace WebApi.Models
{
    public class MovieInputModel
    {
        public string MvTitle { get; set; } = null!;
        public string MvDate { get; set; } = null!;
        public string? MvImg { get; set; }
        public int? MvDuration { get; set; }
        public string? MvSynopsis { get; set; }
        public int? GrId { get; set; }
    }
}
