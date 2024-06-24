using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Core.Dtos;

public class DocumentAccessDto
{
    public int Id { get; set; }
    public int DocumentId { get; set; }
    public int UserId { get; set; }
    public DocumentDto? Document { get; set; }
    public UserDto? User { get; set; }
}
