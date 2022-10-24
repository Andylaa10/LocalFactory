import { Component, OnInit } from '@angular/core';
import {Box} from "../../shared/models/box";
import {FormControl, FormGroup} from "@angular/forms";
import {BoxService} from "../../shared/service/box.service";
import {ActivatedRoute, Router} from "@angular/router";

@Component({
  selector: 'app-box-details',
  templateUrl: './box-details.component.html',
  styleUrls: ['./box-details.component.scss']
})
export class BoxDetailsComponent implements OnInit {
  box: Box = new Box();

  boxForm = new FormGroup({
    id: new FormControl(),
    boxName: new FormControl(),
    description: new FormControl(),
    price: new FormControl()
    //customers:
  })
  constructor(private boxService: BoxService, private route: ActivatedRoute, private router: Router) { }

  async ngOnInit(){
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.box = await this.boxService.getBoxById(id);
    this.boxForm.patchValue({
      id: this.box.id,
      boxName: this.box.boxName,
      description: this.box.description,
      price: this.box.price
    });
  }

  async save() {
    const box = this.boxForm.value;
    let dto ={
      id: box.id,
      boxName: box.boxName,
      description: box.description,
      price: box.price
    }
    await this.boxService.updateBox(dto, box.id)
    await this.router.navigateByUrl('/box-list');
  }

}
