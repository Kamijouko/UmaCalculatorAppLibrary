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

        private List<string> constSources = new List<string> { "Twitter@gamedukedeatho1.0", "Twitter@gamedukedeatho2.0", "NGA"/*, "Twitter@Lig_Rig"*/};

        public List<string> sources = new List<string> { "Twitter@gamedukedeatho1.0", "Twitter@gamedukedeatho2.0", "NGA"/*, "Twitter@Lig_Rig"*/ };

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
