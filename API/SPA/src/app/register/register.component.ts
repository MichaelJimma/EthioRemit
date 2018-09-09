import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};
  @Output() cancelRegister = new EventEmitter
  constructor(private userService: UserService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  register() {
    this.userService.register(this.model)
      .subscribe(success => {
        this.alertify.message('Registration successfull')
      }, error => {
        this.alertify.error(error)
      });
  }

  cancel() {
    this.cancelRegister.emit(false);  
  }
}
