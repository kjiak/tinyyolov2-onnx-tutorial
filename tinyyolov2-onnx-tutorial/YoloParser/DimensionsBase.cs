﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tinyyolov2_onnx_tutorial.YoloParser
{
    public class DimensionsBase
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
    }
}
