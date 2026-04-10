namespace Database;

public class Sensor
{

    public int Id { get; set; }
    public string? Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime MeasurementDate { get; set; }
    
}
