import { Component, OnInit } from '@angular/core';
import {BoxService} from "../../shared/service/box.service";

@Component({
  selector: 'app-box-list',
  templateUrl: './box-list.component.html',
  styleUrls: ['./box-list.component.scss']
})
export class BoxListComponent implements OnInit {
  boxes: any[] = []
  constructor(private boxService: BoxService) { }

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
}
