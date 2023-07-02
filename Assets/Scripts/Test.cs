using System.Collections;
using System.Collections.Generic;
using LcLSoftRender;
using Unity.Mathematics;
using UnityEngine;
using static Unity.Mathematics.math;

[ExecuteAlways]
public class Test : MonoBehaviour
{
    private void OnEnable()
    {
        Camera.main.clearFlags = CameraClearFlags.Skybox;
        // GeometryUtility.CalculateFrustumPlanes(m_Camera);
        for (int i = 0; i < 4; i++)
        {
            var offset = GetSampleOffset2(i, 4);
            Debug.Log(offset);
        }
    }
    private float2 GetSampleOffset2(int index, int sampleCount)
    {
        // 根据采样点的数量和索引计算采样点的偏移量
        switch (sampleCount)
        {
            case 2:
                return new float2(index % 2, index / 2) / 2;
            case 4:
                return new float2(index % 2, index / 2) / 2 + new float2(0.25f, 0.25f);
            case 8:
                return new float2(index % 4, index / 4) / 4 + new float2(0.125f, 0.125f);
            default:
                return 0;
        }
    }
    void Update()
    {

    }
}
