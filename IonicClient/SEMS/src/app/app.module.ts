import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';

import { IonicModule, IonicRouteStrategy } from '@ionic/angular';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { HomePageRoutingModule } from './home/home-routing.module';
import { MainDashboardComponent } from './home/pages/main-dashboard/main-dashboard.component';
import { HomePage } from './home/home.page';
import { ApiModule, BASE_PATH, PersonService, UsersService, WeatherForecastService } from 'src/services';
import { environment } from 'src/environments/environment';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { TokenInterceptorService } from 'src/services/JWT/token-interceptor.service';
import { ModalDetailComponent } from 'src/app/home/pages/main-dashboard/modal-detail/modal-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomePage,
    MainDashboardComponent,
    ModalDetailComponent
    ],
  imports:
  [
    BrowserModule,
    IonicModule.forRoot(),
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ApiModule
  ],
  providers: [
    { provide: RouteReuseStrategy, useClass: IonicRouteStrategy },
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptorService, multi: true },
    PersonService,
    UsersService,
    WeatherForecastService,
    {provide: BASE_PATH, useValue: environment.apiBase}
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
