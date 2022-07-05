import { Component, Input, OnInit } from '@angular/core';
import { PersonModel } from 'src/services';

@Component({
  selector: 'app-modal-detail',
  templateUrl: './modal-detail.component.html',
  styleUrls: ['./modal-detail.component.scss'],
})
export class ModalDetailComponent implements OnInit {
  @Input() public person: PersonModel;

  showPicker = false;
  disable = true;

  constructor() { }

  ngOnInit() {}

  dateChanged(value){
    console.log(value);
  }

  update(){
    this.disable = this.disable ? false : true;
  }
  save(){
    this.update();
  }
}
