export * from './person.service';
import { PersonService } from './person.service';
export * from './users.service';
import { UsersService } from './users.service';
export * from './weatherForecast.service';
import { WeatherForecastService } from './weatherForecast.service';
export const APIS = [PersonService, UsersService, WeatherForecastService];
