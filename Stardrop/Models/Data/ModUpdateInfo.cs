﻿using Semver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stardrop.Models.Data
{
    public class ModUpdateInfo
    {
        public string UniqueId { get; set; }
        public string SuggestedVersion { get; set; }
        public string Status { get; set; }
        public string Link { get; set; }


        public ModUpdateInfo()
        {

        }

        public ModUpdateInfo(string uniqueId, string recommendedVersion, string status, string link)
        {
            UniqueId = uniqueId;
            SuggestedVersion = recommendedVersion;
            Status = status;
            Link = link;
        }
    }
}
