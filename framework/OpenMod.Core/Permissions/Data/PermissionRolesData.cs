﻿using System;
using System.Collections.Generic;

namespace OpenMod.Core.Permissions.Data
{
    [Serializable]
    public sealed class PermissionRolesData
    {
        public List<PermissionRoleData>? Roles { get; set; }
    }
}