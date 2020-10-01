using Microsoft.ML.Data;

namespace tinyyolov2_onnx_tutorial.DataStructures
{
    public class ImageNetPrediction
    {
        [ColumnName("grid")]
        public float[] PredictedLabels;
    }
}
