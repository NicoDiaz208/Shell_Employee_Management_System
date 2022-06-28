import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { PersonModel, PersonService, UsersService, WeatherForecastService } from 'src/services';
import { ModalDetailComponent } from './modal-detail/modal-detail.component';

@Component({
  selector: 'app-main-dashboard',
  templateUrl: './main-dashboard.component.html',
  styleUrls: ['./main-dashboard.component.scss'],
})
export class MainDashboardComponent implements OnInit {

  public persons: PersonModel[] = [];

  constructor(private weatherService: WeatherForecastService,
    private personService: PersonService,
    private modalController: ModalController) { }

  async ngOnInit() {
    this.persons = await this.personService.apiPersonGet().toPromise();
  }

  async presentModal(person: PersonModel) {
    const modal = await this.modalController.create({
      component: ModalDetailComponent,
      cssClass: 'small-modal',
      componentProps: {
        person
      }
    });

    return await modal.present();
  }


}
