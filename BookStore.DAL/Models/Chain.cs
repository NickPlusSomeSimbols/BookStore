﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Models;
public class Chain : BaseEntity
{
    public string Name {  get; set; }  

    public ICollection<Store> Stores{ get; set; }
}
