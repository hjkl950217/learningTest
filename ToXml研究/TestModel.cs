using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ToXml研究
{
    /// <summary>
    /// 测试模式
    /// </summary>
    [XmlRoot(ElementName = "TestModelA")]
    public class TestModel
    {
        [XmlElement(ElementName = "NumA")]
        public int Num { get; set; }

        public string Name { get; set; }

        public List<string> NameList { get; set; }

        [XmlIgnore]
        public Dictionary<string, string> DictList { get; set; }

        //public string ToXml()
        //{
        //    XElement root = new XElement("TestModelA");
        //    root.Add(new XElement("NumA", this.Num));
        //    root.Add(new XElement("Name", this.Name));

        //    XElement xNameLiist = new XElement("NameList");
        //    foreach(var item in this.NameList)
        //    {
        //        xNameLiist.Add(new XElement("SellerID", item));
        //    }
        //    root.Add(xNameLiist);

        //    return root.ToString ();
        //}
    }

    public static class TT
    {
        public static string ToXml(this TestModel testModel)
        {
            //参数设置
            string xRootName = "TestModelA";
            string xNum = "NumA";
            string xName = "Name";
            string xNameList = "NameList";

            XElement root = new XElement(xRootName);
            root.Add(new XElement(xNum, testModel.Num));
            root.Add(new XElement(xName, testModel.Name));


            XElement xNameLiistXml = new XElement(xNameList);
            foreach(var item in testModel.NameList)
            {
                xNameLiistXml.Add(new XElement("String", item));
            }
            root.Add(xNameLiistXml);

            return root.ToString();
        }
    }
}