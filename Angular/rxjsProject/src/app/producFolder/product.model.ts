export interface Product {
    id: number;
    productName: string;
    productCode: string;
    description: string;
    price: number;
    categoryId: number;
    quantityInStock?: number;
    hasReviews?: boolean;
    reviews?: Review[];
    supplierIds?: number[]; // Optional field for supplier IDs
  }

  export interface Review{
    id: number;
  remark: string;
  }