import { HttpBackend, HttpClient, HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { BASE_PATH, UsersService } from 'src/services';
import { JWTToken } from 'src/services/JWT/JWTToken';

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

  title = "Welcome";

  private httpClient: HttpClient;

  constructor(
    private userService: UsersService,
    private router: Router,
    private handler: HttpBackend
    )
     {
      this.httpClient = new HttpClient(handler);
     }

  ngOnInit() {}

  checkFilled(){
    if(this.username.length > 0 && this.password.length > 0){
      this.hideLoginButton = false;
      return;
    }
    this.hideLoginButton = true;
  }

  async login(){
    let token: JWTToken = await this.userService.apiUsersAuthenticatePost(this.username, this.password).toPromise();
    if(token){
      window.localStorage.setItem('Token', token.token);
      this.router.navigate(['home/main-dashboard']);
    }
  }

}
