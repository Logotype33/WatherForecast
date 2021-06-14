import Vue from 'vue'
import Vuex from 'vuex'
import axios from "axios";

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    forecasts: []
  },
  mutations: {
    SET_FORECAST_TO_STATE:(state,forecast)=>{
      state.forecasts=forecast
    }
  },
  actions: {
    GET_FORECASTS_FROM_API({commit}){
      axios.get('http://weatherforecastwithvue.somee.com/WeatherForecast')
      // axios.get('https://localhost:44336/WeatherForecast')
          .then(response=>{
            commit('SET_FORECAST_TO_STATE',response.data)

          })
          .catch((error)=>{
            console.log(error)
          })
    }

  },
  getters:{
    FORECASTS(state){
      return state.forecasts
    }
  }
})
