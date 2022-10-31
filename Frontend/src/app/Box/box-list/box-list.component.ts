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
  boxes: any[] = []
  constructor(private boxService: BoxService, private popup: MatDialog) { }

  async ngOnInit(){
    await this.getBoxes();
  }

  async getBoxes(){
    const boxes = await this.boxService.getBoxes();
    this.boxes = boxes;
  }

  async deleteBox(id: number){
    const box = await this.boxService.deleteBox(id);
    this.boxes = this.boxes.filter(b => b.id != box.id);
  }

  createBox() {
    const data = this.popup.open(BoxAddComponent);
    data.afterClosed().subscribe(box => {
      if (box != null) {
        this.boxes.push(box);
      }
    });
  }

  detailBox(b: any) {
    const data = this.popup.open(BoxDetailsComponent,{
      data : {
        box : b
      }
    });
    data.afterClosed().subscribe();
  }
}
