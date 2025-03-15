import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { loadOrders, deleteOrder } from '../store/Order/order.actions';
import { selectOrders, selectLoading, selectError } from '../store/Order/order.selectors';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-order-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss'],
})
export class OrderListComponent implements OnInit {
  orders$ = this.store.select(selectOrders);
  loading$ = this.store.select(selectLoading);
  error$ = this.store.select(selectError);

  constructor(private store: Store, private router: Router) {}

  ngOnInit() {
    this.store.dispatch(loadOrders());
  }

  viewOrder(id: number) {
    this.router.navigate(['/order', id]);
  }

  deleteOrder(id: number) {
    if (confirm('Are you sure you want to delete this order?')) {
      this.store.dispatch(deleteOrder({ id }));
    }
  }

  navigateToPlaceOrder() {
    this.router.navigate(['/place-order']);
  }
}