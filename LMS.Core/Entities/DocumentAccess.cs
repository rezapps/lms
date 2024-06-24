using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Core.Entities;

public class DocumentAccess
{
    public int Id { get; set; }
    public int DocumentId { get; set; }
    public int UserId { get; set; }
    public Document? Document { get; set; }
    public User? User { get; set; }
}
