﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.DepartmentDtos
{
    public record DepartmentToListDto
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
}
