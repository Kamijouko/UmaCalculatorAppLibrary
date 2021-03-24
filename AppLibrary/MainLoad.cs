using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppLibrary
{
    public class MainLoad 
    {
        public List<Source> sourceList = new List<Source>(); 

        private List<string> constSources = new List<string> { "1Twitter@gamedukedeatho1.0", "2Twitter@gamedukedeatho2.0", "NGA"/*, "Twitter@Lig_Rig"*/};

        //添加新项只需将新数据的名称加入此列表即可，请勿加在开头。
        public List<string> sources = new List<string> { "1Twitter@gamedukedeatho1.0", "2Twitter@gamedukedeatho2.0", "NGA"/*, "Twitter@Lig_Rig"*/ };

        //在上表添加完名称后将静态数据原加进下表即可。名称需与上表新加入的一致。之后数据将自动读取。
        public List<Source> newSources = new List<Source>();

        public MainLoad()
        {
            foreach (string st in sources)
            {
                if (constSources.Contains(st))
                {
                    Source source = new Source(st, constSources.IndexOf(st) + 1);
                    sourceList.Add(source);
                }
                else
                {
                    if (newSources.Exists(delegate(Source s) { return s.Source_name == st; }))
                    {
                        sourceList.Add(newSources.Find(delegate (Source sc) { return sc.Source_name == st; }));
                    }
                    else
                    {
                        Source source = new Source(st);
                        sourceList.Add(source);
                    }
                }
            }
            
        }
    }
}
