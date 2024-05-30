using System.Collections.Generic;

namespace CkTools.Abstraction.Test.TestModel
{
    public static class ComparerTestData
    {
        public static List<SellerInfo> TestListA = new()
        {
            new SellerInfo(){UserID=1,UserName="1"},
            new SellerInfo(){UserID=1,UserName="1"},
            new SellerInfo(){UserID=2,UserName="2"}
        };

        public static List<SellerInfo> TestListB = new()
        {
                new SellerInfo(){UserID=1}
        };

        public static List<UserInfo> TestListC = new()
        {
                new UserInfo(){UserID=1}
        };

        public static List<UserInfo> TestListD = new()
        {
                new UserInfo(){UserID=2}
        };
    }
}