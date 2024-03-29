namespace Orion.Models.Common
{
    public interface IOrder
    {
        int OrderPrice { get; set; }
        int OrderQuantity { get; set; }
        DateTime OrderDate { get; set; }
        int OrderAmount { get; set; }
        string OrderComments { get; set; }
    }
}
