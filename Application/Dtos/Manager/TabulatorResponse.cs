using System.Collections.Generic;

namespace Application.Dtos.Manager;

public class TabulatorResponse<T>
{
    public int last_page { get; set; }
    public List<T> data { get; set; } = new List<T>();
}
