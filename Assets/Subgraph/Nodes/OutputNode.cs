
using System;
using UnityEngine;
using BlueGraph;

namespace BlueGraphSamples
{
    [Node("Output", Path = "Subgraph/IO")]
    [Tags("Subgraph IO")]
    public class OutputNode : Node
    {
        // Input port is dynamically generated by the editor.

        /// <summary>
        /// Not directly called for this node type
        /// </summary>
        public override object OnRequestValue(Port port) => null;
        
        public OutputNode()
        {
            AddPort(new Port
            {
                Direction = PortDirection.Input,
                Type = typeof(float)
            });
        }
    }
}