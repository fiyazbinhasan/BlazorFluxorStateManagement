using Fluxor;

namespace BlazorFluxorStateManagement.Store.CounterUseCase
{
    public class Reducers
    {
        [ReducerMethod(typeof(IncrementCounterAction))]
        public static CounterState ReduceIncrementCounterAction(CounterState state) =>
               state with { Count = state.Count + 1 };
    }
}
