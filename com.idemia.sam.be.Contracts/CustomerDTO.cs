using System;

namespace com.idemia.sam.be.Contracts
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string nameAr { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public WorkFieldDTO workFieldDTO { get; set; }
    }
}
