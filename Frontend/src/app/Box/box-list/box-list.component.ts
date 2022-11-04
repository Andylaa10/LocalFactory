import { Component, OnInit } from '@angular/core';
import {BoxService} from "../../shared/service/box.service";
import {MatDialog} from "@angular/material/dialog";
import {BoxAddComponent} from "../box-add/box-add.component";
import {BoxDetailsComponent} from "../box-details/box-details.component";

@Component({
  selector: 'app-box-list',
  templateUrl: './box-list.component.html',
  styleUrls: ['./box-list.component.scss']
})
export class BoxListComponent implements OnInit {

  constructor(public boxService: BoxService, private popup: MatDialog) { }

  async ngOnInit(){
    await this.boxService.getBoxes();
  }


  async deleteBox(id: number){
    await this.boxService.deleteBox(id);
  }

  createBox() {
    const data = this.popup.open(BoxAddComponent);
    data.afterClosed().subscribe(box => {
      if (box != null) {
        this.boxService.boxes.push(box);
      }
      this.boxService.getBoxes();
    });
  }

  detailBox(b: any) {
    const data = this.popup.open(BoxDetailsComponent,{
      data : {
        box : b
      }
    });
    data.afterClosed().subscribe(()=>{
      this.boxService.getBoxes();
    });
  }
}
