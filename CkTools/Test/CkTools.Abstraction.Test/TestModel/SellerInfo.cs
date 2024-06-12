namespace CkTools.Abstraction.Test.TestModel
{
    public class SellerInfo : UserInfo
    {
        public string? SellerID { get; set; }
        public string? SellerName { get; set; }

        public IDCard? IDCard { get; set; }
    }
}