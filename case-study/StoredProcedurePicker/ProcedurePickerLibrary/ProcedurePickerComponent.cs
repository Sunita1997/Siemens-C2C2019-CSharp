using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProcedurePickerLibrary
{
    public class ParameterInfo
    {
        public string ParameterName { get; set; }
        public string ParameterType { get; set; }
    }
    public class ProcedureInfo
    {
        public string Name { get; set; }
        public List<ParameterInfo> Parameters { get; set; }
    }
    public class ProcedurePickerComponent
    {
        public List<ProcedureInfo> GetProcedures()
        {
            string filePath = @"E:\Siemens\C2C-2019\CSharp\Siemens-C2C2019-CSharp\Siemens-C2C2019-CSharp\case-study\procedure_details.xml";

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            var nodes = xmlDocument.DocumentElement.ChildNodes;
            List<ProcedureInfo> procedures = new List<ProcedureInfo>();
            foreach (XmlNode item in nodes)
            {
                if (item.Name == "procedure")
                {
                    ProcedureInfo procedureInfo = new ProcedureInfo();
                    var procedureChildren = item.ChildNodes;
                    foreach (XmlNode child in procedureChildren)
                    {

                        switch (child.Name)
                        {
                            case "name":
                                procedureInfo.Name = child.InnerText;
                                break;

                            case "parameters":

                                var parameterChildren = child.ChildNodes;

                                if (parameterChildren != null && parameterChildren.Count > 0)
                                {
                                    List<ParameterInfo> parameters = new List<ParameterInfo>();
                                    foreach (XmlNode parameter in parameterChildren)
                                    {
                                        ParameterInfo parameterInfo = new ParameterInfo();
                                        foreach (XmlNode paramChild in parameter)
                                        {
                                            switch (paramChild.Name)
                                            {
                                                case "parametername":
                                                    parameterInfo.ParameterName = paramChild.InnerText.Trim(' ');
                                                    break;

                                                case "parametertype":
                                                    parameterInfo.ParameterType = paramChild.InnerText.Trim(' ');
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        parameters.Add(parameterInfo);
                                    }
                                    procedureInfo.Parameters = parameters;
                                }
                                break;

                            default:
                                break;
                        }
                    }
                    procedures.Add(procedureInfo);
                }
            }
            return procedures;
        }
    }
}
