import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from '../models/product.model';
import { ProductService } from '../product-service.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-product',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.scss'],
})
export class AddProductComponent {
  product: Product = {
    id: 0,
    name: '',
    description: '',
    category: '',
    price: 0,
  };

  constructor(private productService: ProductService, private router: Router) {}

  addProduct() {
    this.productService.addProduct(this.product).subscribe(() => {
      this.router.navigate(['/']);
    });
  }
}