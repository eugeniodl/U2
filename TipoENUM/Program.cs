var order = new Order
{
    OrderId = 123,
    Status = OrderStatus.Pending
};

Console.WriteLine(order);

order.UpdateStatus(OrderStatus.Processing);
Console.WriteLine(order);

public enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Canceled
}

public class Order
{
    public int OrderId { get; set; }
    public OrderStatus Status { get; set; }

    public void UpdateStatus(OrderStatus newStatus)
    {
        // Ejemplo de lógica para actualizar el estado
        if(Status == OrderStatus.Canceled || Status == OrderStatus.Delivered)
        {
            throw new InvalidOperationException("Cannot change status from current state.");
        }

        Status = newStatus;
    }

    public override string ToString()
    {
        return $"Order {OrderId}: {Status}";
    }
}