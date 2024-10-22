﻿using Fluxor;

namespace BlazorFluxorStateManagement.Store.FetchDataUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static FetchDataState ReduceFetchDataAction(FetchDataState state, FetchDataAction action) =>
            new(true, null, null);

        [ReducerMethod]
        public static FetchDataState ReduceFetchDataSuccessAction(FetchDataState state, FetchDataSuccessAction action) =>
            new(false, action.Forecasts, null);

        [ReducerMethod]
        public static FetchDataState ReduceFetchDataErrorAction(FetchDataState state, FetchDataErrorAction action) =>
            new(false, null, action.Error);
    }
}
