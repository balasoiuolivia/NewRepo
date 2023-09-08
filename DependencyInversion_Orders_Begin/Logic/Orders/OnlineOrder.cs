﻿using DependencyInversion_Orders_Begin.Logic.Carts;
using DependencyInversion_Orders_Begin.Logic.Implementations;

namespace DependencyInversion_Orders_Begin.Logic.Orders
{
    public class OnlineOrder : Order
    {
        private readonly CreditCard paymentDetails;
        private readonly NotificationService notificationService;
        private readonly PaymentProcessor paymentProcessor;
        private readonly ReservationService reservationService;

        public OnlineOrder(Cart cart, Customer customer, CreditCard paymentDetails)
            : base(cart, customer)
        {
            this.paymentDetails = paymentDetails;
            this.notificationService = new NotificationService();
            this.reservationService = new ReservationService();
            this.paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            paymentProcessor.ProcessCreditCard(paymentDetails, cart);
            reservationService.ReserveInventory(cart);
            notificationService.NotifyCustomer(cart, customer);
        }
    }
}
