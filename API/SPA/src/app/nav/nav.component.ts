import { Component, OnInit } from '@angular/core';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(
    public userService: UserService,
    private alertify: AlertifyService,
    private router: Router) { }

  ngOnInit() {
  }

  login() {
    this.userService.login(this.model)
      .subscribe(success => {
        this.alertify.success('logged in successfully');
      }, error => {
        this.alertify.error('login failed');
      }, () => {
        this.router.navigate(['/agents']);
      });
  }

  loggedIn() {
    return this.userService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    this.alertify.message('Logged out');
    this.router.navigate(['/home']);
  }
}
