import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Furniture } from './models/furniture.model';
import { Customer } from './models/custumer.model';

@Injectable()
export class AppService {
  private baseUrl = "https://localhost:7204/FurnitureImporter"
  private furnituresUrl = "https://localhost:7204/FurnitureImporter/GetAllFurnitures";
  private customersUrl = "https://localhost:7204/FurnitureImporter/GetAllCustumers";

  constructor(private httpService: HttpClient) {}

  public getAllFurnitures() {
    return this.httpService.get<Furniture[]>(this.furnituresUrl);
  }

  public getAllCustomers() {
    return this.httpService.get<Customer[]>(this.customersUrl);
  }

  public getDiscountedPriece(custumerId: string, furnitureId: string) {
    return this.httpService.get<number>(`${this.baseUrl}/${custumerId}/GetDiscountedPriece/${furnitureId}`);
  }

}
