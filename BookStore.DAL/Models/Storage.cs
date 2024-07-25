using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Models;
public class Storage : BaseEntity
{
    public long StoreId { get; set; }
    public Store Store { get; set; }
}
