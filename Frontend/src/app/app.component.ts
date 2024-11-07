import { Component, OnInit } from '@angular/core';
import { AppService } from './app.component.service';
import { Furniture } from './models/furniture.model';
import { Customer } from './models/custumer.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  public furnitures: Furniture[] = [];
  public customers: Customer[] = [];

  public selectedCustomer: string;
  public selectedFurniture: string;
  public discountedPrice: number;

  constructor(private service: AppService) {}

  ngOnInit(): void {
    this.service.getAllFurnitures().subscribe((result) => {
      console.log(result); 
      this.furnitures = result;
    });

    this.service.getAllCustomers().subscribe((result) => {
      console.log(result); 
      this.customers = result;
    });
  }

  public onFurnitureSelect() {
    console.log('changes fur');
    let fur = document.getElementById('furnitureSelect') as HTMLSelectElement;
    console.log(fur.value);
    this.selectedFurniture = fur.value;
  }

  public onCustomerSelect() {
    console.log('changes cus');
    let cus = document.getElementById('customerSelect') as HTMLSelectElement;
    console.log(cus.value);
    this.selectedCustomer = cus.value;
  }

  public getPrice() {
    this.service.getDiscountedPriece(this.selectedCustomer, this.selectedFurniture)
    .subscribe((result) => {
      console.log(result);
      this.discountedPrice = result;
    });

  }
  
}
