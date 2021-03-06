﻿using System.Collections.Generic;

namespace Octopus.Client.Model
{
    public class CertificateUsageResource
    {
        public ICollection<ProjectResource> ProjectUsages { get; set; }

        public ICollection<LibraryVariableSetResource> LibraryVariableSetUsages { get; set; }

        public ICollection<TenantResource> TenantUsages { get; set; }
    }
}