namespace OrdemPedido.Entitis.Enum
{
    public enum OrderStatus : int
    {
        pendingPayment = 0,
        processing = 1,
        shipped = 2,
        delivered = 3
    }
}