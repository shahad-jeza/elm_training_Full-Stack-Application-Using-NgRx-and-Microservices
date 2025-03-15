import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable, of, switchMap } from 'rxjs';
import { Order } from '../models/order.model';
import { selectOrderById } from '../store/Order/order.selectors';
import { CommonModule } from '@angular/common';
import { ProductService } from '../product-service.service';
import { Product } from '../models/product.model';

@Component({
  selector: 'app-order-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-details.component.html',
  styleUrls: ['./order-details.component.scss'],
})
export class OrderDetailsComponent implements OnInit {
  order$: Observable<Order | undefined>;
  products$: Observable<Product[]> | undefined;

  constructor(
    private route: ActivatedRoute,
    private store: Store,
    private productService: ProductService
  ) {
    const orderId = +this.route.snapshot.params['id'];
    this.order$ = this.store.select(selectOrderById(orderId));

    // Fetch product details for each order item
    this.products$ = this.order$.pipe(
      switchMap((order) => {
        if (order && order.orderItems.length > 0) {
          const productIds = order.orderItems.map((item) => item.productId);
          return this.productService.getProductsByIds(productIds);
        }
        return of([]);
      })
    );
  }

  ngOnInit() {}
}