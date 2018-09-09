import { Component, OnInit } from '@angular/core';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(public userService: UserService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  login() {
    this.userService.login(this.model)
      .subscribe(success => {
        this.alertify.success('logged in successfully');
      }, error => {
        this.alertify.error('login failed');
      });
  }

  loggedIn() {
    return this.userService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    this.alertify.message('Logged out');
  }
}
