import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';
import { loadProducts, deleteProduct } from '../store/product/product.actions';
import { selectProducts, selectLoading, selectError } from '../store/product/product.selectors';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss'],
})
export class ProductListComponent implements OnInit {
  products$: Observable<Product[]> = this.store.select(selectProducts);
  loading$: Observable<boolean>;
  error$: Observable<string | null>;

  constructor(private store: Store, private router: Router) {
    this.products$ = this.store.select(selectProducts);
    this.loading$ = this.store.select(selectLoading);
    this.error$ = this.store.select(selectError);
  }

  ngOnInit() {
    this.store.dispatch(loadProducts());
  }

  // Navigate to Add Product Page
  navigateToAddProduct() {
    this.router.navigate(['/add-product']);
  }

  // Navigate to Product Details Page
  viewProduct(id: number) {
    this.router.navigate(['/product', id]);
  }

  // Delete Product
  deleteProduct(id: number) {
    if (confirm('Are you sure you want to delete this product?')) {
      this.store.dispatch(deleteProduct({ id }));
    }
  }
}