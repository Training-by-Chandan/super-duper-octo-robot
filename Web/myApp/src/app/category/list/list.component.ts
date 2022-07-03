import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/service/category.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  list: Category[];

  constructor(private category:CategoryService) { }

  ngOnInit(): void {
    this.getAllCategories();
  }

  getAllCategories() {
   this.category.getAllCategories().subscribe(d=>{
      this.list=d;
    }) ;
  }
}
