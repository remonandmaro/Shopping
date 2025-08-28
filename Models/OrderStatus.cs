using System.Runtime.Serialization;

namespace ERPSystem.Models
{
    public enum OrderStatus
    {
        [EnumMember(Value ="Pending")]
        Pending,

        [EnumMember(Value = "Confirmed")]
        Confirmed,

        [EnumMember(Value = "Shipped")]
        Shipped,

        [EnumMember(Value = "Delivered")]
        Delivered,

        [EnumMember(Value = "Cancelled")]
        Cancelled

    }
}