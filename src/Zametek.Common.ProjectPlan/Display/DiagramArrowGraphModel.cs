﻿using System;
using System.Collections.Generic;

namespace Zametek.Common.ProjectPlan
{
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Object is a DTO")]
    public class DiagramArrowGraphModel
    {
        public List<DiagramEdgeModel> Edges { get; set; }

        public List<DiagramNodeModel> Nodes { get; set; }
    }
}
