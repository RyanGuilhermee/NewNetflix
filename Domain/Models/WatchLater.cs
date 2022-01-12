﻿using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class WatchLater
    {
        public int WatchLaterId { get; set; }
        public int? UsrId { get; set; }
        public int? MvId { get; set; }
        public int? SeId { get; set; }

        public virtual Movie? Mv { get; set; }
        public virtual Serie? Se { get; set; }
        public virtual User? Usr { get; set; }
    }
}
