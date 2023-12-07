namespace NSwagSample;

/// <summary>
/// 気象状況
/// </summary>
public class WeatherForecast
{
    /// <summary>
    /// 観測日時
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// 気温（摂氏）
    /// </summary>
    public int TemperatureC { get; set; }

    /// <summary>
    /// 気温（華氏）
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// 概況
    /// </summary>
    public string? Summary { get; set; }
}
