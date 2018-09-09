import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};
  @Output() cancelRegister = new EventEmitter
  constructor(private userService: UserService) { }

  ngOnInit() {
  }

  register() {
    this.userService.register(this.model)
      .subscribe(success => {
        console.log(this.model)
      }, error => {
        console.log(error)
      });
  }

  cancel() {
    this.cancelRegister.emit(false);  
  }
}
