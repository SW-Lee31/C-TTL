using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarManager0827
{
    class XMLParser
    {
        public static void writeXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Customers></Customers>");

            for (int i = 0; i < 5; i++)
            {
                XmlElement newElem = doc.CreateElement("Customer");
                XmlAttribute newAttr = doc.CreateAttribute("Number");
                newAttr.Value = (i+1)+"";
                newElem.Attributes.Append(newAttr);

                newAttr = doc.CreateAttribute("Name");
                newAttr.Value = "홍길동"+i;
                newElem.Attributes.Append(newAttr);
                doc.DocumentElement.AppendChild(newElem);

                XmlElement subNode = doc.CreateElement("Info");
                XmlElement info = doc.CreateElement("전화");
                info.InnerText = "01012345678";
                subNode.AppendChild(info);

                info = doc.CreateElement("주소");
                info.InnerText = "대구시 동구 신천4동";
                subNode.AppendChild(info);

                info = doc.CreateElement("날짜");
                info.InnerText = "2021년8월12일";
                subNode.AppendChild(info);

                info = doc.CreateElement("생일");
                info.InnerText = "1980년6월24일";
                subNode.AppendChild(info);

                info = doc.CreateElement("성별");
                info.InnerText = "남";
                subNode.AppendChild(info);

                //////////////////////////////////////////
                info = doc.CreateElement("Hobby");
                XmlElement hb = doc.CreateElement("취미");
                hb.InnerText = "잠자기";
                info.AppendChild(hb);

                hb = doc.CreateElement("취미");
                hb.InnerText = "게임하기";
                info.AppendChild(hb);

                hb = doc.CreateElement("취미");
                hb.InnerText = "술마시기";
                info.AppendChild(hb);
                //////////////////////////////////////////

                subNode.AppendChild(info);
                newElem.AppendChild(subNode);
            }

            // xml 저장
            using (XmlTextWriter writer = 
                new XmlTextWriter("test.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
            }
        }

        public static void readXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("test.xml");
            XmlNodeList custNodes = doc.SelectNodes("Customers/Customer");

            foreach (XmlElement custNode in custNodes)
            {
                Console.WriteLine("번호: " + custNode.Attributes["Number"].Value);
                Console.WriteLine("고객명: " + custNode.Attributes["Name"].Value);

                //if (custNode.Attributes["Name"].Value == "홍길동0")
                //{
                //    XmlNode delNode = doc.SelectSingleNode("Customers/Customer");
                //    XmlNode parentNode = delNode.ParentNode;
                //    parentNode.RemoveChild(delNode);
                //}

                foreach (XmlElement inNode in custNode.ChildNodes)
                {
                    Console.WriteLine("전화: " + inNode["전화"].InnerText);
                    Console.WriteLine("주소: " + inNode["주소"].InnerText);
                    Console.WriteLine("날짜: " + inNode["날짜"].InnerText);
                    Console.WriteLine("생일: " + inNode["생일"].InnerText);
                    Console.WriteLine("성별: " + inNode["성별"].InnerText);

                    if (inNode["생일"].Name == "생일")
                    {
                        inNode.RemoveChild(inNode["생일"]);
                    }

                    if (inNode["성별"].Name == "성별")
                    {
                        inNode["성별"].InnerText = "여";
                    }

                    foreach (XmlElement hbList in inNode.LastChild)
                    {
                        Console.WriteLine("취미: " + hbList.InnerText);
                    }
                }

            }
            doc.Save("test.xml");
        }
    }
}
