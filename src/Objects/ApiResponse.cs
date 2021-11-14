namespace FnTool.Objects;

public class ApiResponse<T>
{

    public int Status { get; set; }
    public T Data { get; set; }

}
