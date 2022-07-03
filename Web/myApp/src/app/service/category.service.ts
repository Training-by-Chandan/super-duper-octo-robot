import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from '../models/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  baseurl = 'https://localhost:7048/';
  constructor(private http: HttpClient) { }

  getAllCategories() {
    return this.http.get<Category[]>(this.baseurl + 'api/category/get-all');
     
  }
  createCategory(category: Category) {
    return this.http.post(this.baseurl + 'api/category/create', category);
  }
}
