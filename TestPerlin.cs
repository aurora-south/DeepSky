using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ʹ�ð���������Ŀ�ģ����ǻ��һ�����ӷ�����ʵ�����е�һЩ������󣬱���ɽ������ľ���������棬��������й���
public class TestPerlin : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public bool userPerlin;
    public float lacunarity = 0.001f; // ��϶��Ӱ��ƽ����
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
