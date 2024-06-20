export interface Product {
    id: number;
    productName: string;
    productCode: string;
    description: string;
    price: number;
    categoryId: number;
    quantityInStock: number;
    supplierIds?: number[]; // Optional field for supplier IDs
  }