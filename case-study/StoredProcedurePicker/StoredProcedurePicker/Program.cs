using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StoredProcedurePicker
{
    class ParameterInfo
    {
        public string ParameterName { get; set; }
        public string ParameterType { get; set; }
    }
    class ProcedureInfo
    {
        public string Name { get; set; }
        public List<ParameterInfo> Parameters { get; set; }
    }
    class Program
    {
        static void Main()
        {
            string filePath = @"E:\Siemens\C2C-2019\CSharp\Siemens-C2C2019-CSharp\Siemens-C2C2019-CSharp\case-study\procedure_details.xml";

            XmlReader reader = XmlReader.Create(filePath);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "procedure")
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType != XmlNodeType.EndElement && reader.NodeType == XmlNodeType.Element && reader.NodeType != XmlNodeType.Text)
                        {
                            switch (reader.Name)
                            {
                                case "name":
                                    Console.WriteLine($"name={reader.Read()}");
                                    break;

                                case "parameters":

                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            reader.Close();

        }
    }
}
