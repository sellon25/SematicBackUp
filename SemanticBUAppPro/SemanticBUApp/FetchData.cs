using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SemanticBUApp
{
    internal class FetchData
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string DirectoryPath { get; set; }
        public string DateCreated { get; set; }
        public string LastUpdated { get; set; }

        public bool backupFile { get; set; }

        public string urls { get; set; }

    }
}
