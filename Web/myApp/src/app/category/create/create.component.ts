import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/service/category.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  list:Category[];
  form=new FormGroup({
    name:new FormControl(''),
    description:new FormControl(''),
    categoryId:new FormControl(''),
  })
  constructor(private category:CategoryService) { }

  ngOnInit(): void {
    this.getAllCategories();
  }

  getAllCategories() {
    this.category.getAllCategories().subscribe(d=>{
      this.list=d;
    })

  }

  createCategory(){
    let category=new Category();
    category.name=this.form.value.name;
    category.description=this.form.value.description;
    category.categoryId=this.form.value.categoryId;
    this.category.createCategory(category).subscribe(d=>{
      this.getAllCategories();
      location.reload();
    })
  }
}
