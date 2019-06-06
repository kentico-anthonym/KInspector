﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace KenticoInspector.Reports.ContentTreeConsistencyAnalysis.Models
{
    public class CmsClassItem
    {
        public string ClassDisplayName { get; set; }
        public XmlDocument ClassFormDefinitionXml { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassTableName { get; set; }
    }
}
