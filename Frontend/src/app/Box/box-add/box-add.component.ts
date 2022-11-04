import {Component, Inject, OnInit} from '@angular/core';
import {FormControl, FormGroup} from "@angular/forms";
import {BoxService} from "../../shared/service/box.service";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";

@Component({
  selector: 'app-box-add',
  templateUrl: './box-add.component.html',
  styleUrls: ['./box-add.component.scss']
})
export class BoxAddComponent implements OnInit {

  boxForm = new FormGroup({
    photo: new FormControl(),
    boxName: new FormControl(),
    description: new FormControl(),
    price: new FormControl()
  })

  constructor(private boxService: BoxService, public dialogRef: MatDialogRef<BoxAddComponent>) {

  }

  ngOnInit(): void {
  }

  async save() {
    const box = this.boxForm.value;
    let dto ={
      photo: box.photo,
      boxName: box.boxName,
      description: box.description,
      price: box.price
    }
    await this.boxService.addBox(dto);
    await this.dialogRef.close();
  }

}
