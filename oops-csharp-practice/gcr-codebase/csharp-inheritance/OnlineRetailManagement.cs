using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class OnlineRetailManagement
    {
        static void Main(String[] args)
        {
            DeliveredOrder order = new DeliveredOrder(156, "01-01-2026", "TRK123", "18-01-2027");
            Console.WriteLine("Order ID       : " + order.OrderId);
            Console.WriteLine("Order Date     : " + order.OrderDate);
            Console.WriteLine("Tracking No    : " + order.TrackingNumber);
            Console.WriteLine("Delivery Date  : " + order.DeliveryDate);
            Console.WriteLine("Status         : " + order.GetOrderStatus());
        }
    }
    class Order
    {
        public int OrderId;
        public string OrderDate;

        public Order(int orderId, string orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }

    class ShippedOrder : Order
    {
        public string TrackingNumber;

        public ShippedOrder(int orderId, string orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        public string DeliveryDate;

        public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate) : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }
    }
}
