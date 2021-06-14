<template>
  <div class="WeatherForecast container">
    <div class="title d-flex mt-5">
      <h1 class="ml-auto">Weather Forecast</h1>
      <v-btn class="green mr-0 ml-auto" @click="RefreshForecasts">Refresh</v-btn>
    </div>
    <v-data-table
    class="mt-4"
    :headers="headers"
    :items="FORECASTS"
    ></v-data-table>
  </div>
</template>

<script>
import {mapGetters,mapActions} from 'vuex'
export default {
  name: "WeatherForecast",
  components:{
  },
  data(){
    return{
      headers:[
        {text:'Date',value:'day'},
        {text:'Min temperature',value: 'minTemperature'},
        {text:'Max temperature',value: 'maxTemperature'},
        {text:'Pressure',value:'pressure'},
        {text:'Humidity',value:'humidity'},
        {text:'WInd Power',value:'windPower'},
        {text:'Wind Direction',value:'windDirection'},
        {text:'Precipitation',value:'precipitation'},
      ],
      forecasts:[

      ]
    }
  },
  methods:{
    ...mapActions([
        'GET_FORECASTS_FROM_API'
    ]),
    RefreshForecasts(){
      this.GET_FORECASTS_FROM_API();
    }
  },
  computed:{
    ...mapGetters([
        'FORECASTS'
    ]),

  },
  mounted() {
    this.GET_FORECASTS_FROM_API();
    // this.setHumidity();
  }
}
</script>

<style scoped>
</style>