using System;
using System.Collections.Generic;
using System.Text;

namespace 动态添加Attribute2
{
    public interface TestInterface2
    {
        //[Test(Name = "添加姓名")]
        void AddName(string name);

        void AddInt(int num);
    }
}
