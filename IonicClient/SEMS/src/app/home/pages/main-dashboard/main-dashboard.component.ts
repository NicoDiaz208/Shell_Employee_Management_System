import { Component, OnInit } from '@angular/core';
import { WeatherForecastService } from 'src/services';

@Component({
  selector: 'app-main-dashboard',
  templateUrl: './main-dashboard.component.html',
  styleUrls: ['./main-dashboard.component.scss'],
})
export class MainDashboardComponent implements OnInit {

  constructor(private weatherService: WeatherForecastService) { }

  ngOnInit() {}

  async call(){
    let i = await this.weatherService.getWeatherForecast().toPromise();
    i.forEach(element => {
      console.log(element.date + '    ' + element.summary + '   ' + element.temperatureC);
    });
  }
}
