export interface Payment {
  paymentId: number;
  cardOwnerName: string;
  cardNumber: string;
  expirationDate: Date;
  securityCode: string;
}
