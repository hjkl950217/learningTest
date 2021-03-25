﻿using System.Collections.Generic;

namespace CKTools.BaseExtensions.Test.Extensions.TestModel
{
    public static class ComparerTestData
    {
        public static List<SellerInfo> TestListA = new List<SellerInfo>()
        {
            new SellerInfo(){UserID=1,UserName="1"},
            new SellerInfo(){UserID=1,UserName="1"},
            new SellerInfo(){UserID=2,UserName="2"}
        };

        public static List<SellerInfo> TestListB = new List<SellerInfo>()
        {
                new SellerInfo(){UserID=1}
        };

        public static List<UserInfo> TestListC = new List<UserInfo>()
        {
                new UserInfo(){UserID=1}
        };

        public static List<UserInfo> TestListD = new List<UserInfo>()
        {
                new UserInfo(){UserID=2}
        };
    }
}