﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO.StoreDto;
public class UpdateStoreDto
{
    public long Id { get; set; }
    public string? Address { get; set; }
}
