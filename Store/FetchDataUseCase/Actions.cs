using BlazorFluxorStateManagement.Data;

namespace BlazorFluxorStateManagement.Store.FetchDataUseCase
{
    public record FetchDataAction();
    public record FetchDataSuccessAction(IEnumerable<WeatherForecast> Forecasts);
    public record FetchDataErrorAction(string Error);
}
