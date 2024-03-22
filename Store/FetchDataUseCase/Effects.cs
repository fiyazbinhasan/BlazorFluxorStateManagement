using BlazorFluxorStateManagement.Data;
using Fluxor;

namespace BlazorFluxorStateManagement.Store.FetchDataUseCase
{
    public class Effects
    {
        private readonly WeatherForecastService _weatherForecastService;

        public Effects(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [EffectMethod]
        public async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
        {
            try
            {
                var forecasts = await _weatherForecastService.GetForecastAsync();
                dispatcher.Dispatch(new FetchDataSuccessAction(forecasts));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new FetchDataErrorAction(ex.Message));
            }
        }
    }
}
