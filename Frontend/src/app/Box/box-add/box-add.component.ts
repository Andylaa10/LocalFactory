import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup} from "@angular/forms";
import {BoxService} from "../../shared/service/box.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-box-add',
  templateUrl: './box-add.component.html',
  styleUrls: ['./box-add.component.scss']
})
export class BoxAddComponent implements OnInit {

  boxForm = new FormGroup({
    boxName: new FormControl(),
    description: new FormControl(),
    price: new FormControl()
  })
  constructor(private boxService: BoxService, private router: Router) { }

  ngOnInit(): void {
  }

  async save() {
    const box = this.boxForm.value;
    let dto ={
      boxName: box.boxName,
      description: box.description,
      price: box.price
    }
    await this.boxService.addBox(dto)
    await this.router.navigateByUrl('/box-list');
  }

}
