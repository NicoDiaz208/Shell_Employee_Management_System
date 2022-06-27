import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {

  hide = true;
  hideLoginButton = true;

  public username = '';
  public password = '';

  title = "Hello, sir";

  constructor() { }

  ngOnInit() {}

  checkFilled(){
    if(this.username.length > 0 && this.password.length > 0){
      this.hideLoginButton = false;
      return;
    }
    this.hideLoginButton = true;
  }

}
