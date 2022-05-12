namespace DirectN.MinimalD3D11
{
    // this code is ported from https://gist.github.com/d7samurai/261c69490cce0620d0bfc93003cd1052
    public static class Data
    {
        public static float[] VertexData = // float3 position, float3 normal, float2 texcoord, float4 color
        {
            -1f,  1f, 0.0f, 0.0f, 0.0f,
             1f,  1f, 0.0f, 1.0f, 0.0f,
            -1f, -1f, 0.0f, 0.0f, 1.0f,
             1f, -1f, 0.0f, 1.0f, 1.0f
        };

        public static uint[] IndexData =
        {
            0,   1,   2,
            2,   1,   3,

        };
    }
}
