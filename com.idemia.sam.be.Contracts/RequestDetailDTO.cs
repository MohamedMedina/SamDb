using System;

namespace com.idemia.sam.be.Contracts
{
    public class RequestDetailDTO
    {
        public int Id { get; set; }
        public int quantity { get; set; }
        public CardTypeDTO cardTypeDTO { get; set; }
    }
}
