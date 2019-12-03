using System;

namespace com.idemia.sam.be.Contracts
{
    public class FunctionDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string nameAr { get; set; }
        public string route { get; set; }
        public Nullable<bool> status { get; set; }
    }
}
