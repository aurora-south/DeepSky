using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 使用柏林噪声的目的：就是获得一个更加符合真实世界中的一些随机现象，比如山脉、树木的纹理、火焰，随机但是有规律
public class TestPerlin : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public bool userPerlin;
    public float lacunarity = 0.001f; // 间隙，影响平滑度
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        // lineRenderer.SetPositions()
        Vector3[] positions = new Vector3[100];
        float seedX = Random.Range(1, 10000);
        float seedY = Random.Range(1, 10000);
        for (int i = 0; i < positions.Length; i++)
        {
            if (userPerlin)
            {
                positions[i] = new Vector3(0, Mathf.PerlinNoise(i * lacunarity + seedX, i * lacunarity+ seedY), i * 0.1f);  // 0-1
            }
            else
            {
                positions[i] = new Vector3(0, Random.value, i * 0.1f);  // 0-1
            }
           
        }
        lineRenderer.SetPositions(positions);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
