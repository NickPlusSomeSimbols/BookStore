using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Models;
public class Store : BaseEntity
{
    public string? Address { get; set; }

    public Chain Chain { get; set; }
    public long ChainId { get; set; }
    public Storage Storage { get; set; }
    public long StorageId { get; set; }
}
