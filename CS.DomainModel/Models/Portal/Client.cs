﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.DomainModel.Models.Portal
{
    public class Client
    {
        public Guid ClientGuid { get; set; }
        public string DocumentLink { get; set; }
        public List<DocumentFolder> Folders { get; set; }
        public string Name { get; set; }
    }
}
