import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private _httpService: HttpClient) { }
  title = 'app';
  apiValues: any;

  ngOnInit() {
    this.getClientTypes();
  }

  getClientTypes() {
    this._httpService.get('http://localhost:51797/api/clienttypes')
      .subscribe(response => {
        this.apiValues = response;
      }, error => {
        console.log(error);
      });
  }
}
