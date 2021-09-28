using System;
using _22_enum.Entities.Enums;

namespace _22_enum.Entities {
    class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public override string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
