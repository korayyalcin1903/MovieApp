﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.RoleDtos
{
    public class AddRoleToUser
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
