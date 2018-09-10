import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { UserService } from '../_services/user.service';
import { Router } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(
    private userService: UserService,
    private router: Router,
    private alertify: AlertifyService) { }

  canActivate(): boolean {
    if (this.userService.loggedIn()) {
      return true;
    }

    this.alertify.error('Anuthorized access!');
    this.router.navigate(['/home']);
    return false;
  }
}
