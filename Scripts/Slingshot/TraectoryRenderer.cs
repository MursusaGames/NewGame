using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraectoryRenderer : MonoBehaviour
{
    private LineRenderer lineRendererComponent;
   
    void Start()
    {
        lineRendererComponent = GetComponent<LineRenderer>();
    }

    public void ShowTraectory(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[100];
        lineRendererComponent.positionCount = points.Length;
        for(int i =0; i < points.Length; i++)
        {
            float time = i * 0.1f;
            points[i] = origin + speed * time + Physics.gravity * time * time / 2f; //формула траектории начальное положение + расстояние (скорость * время) + 
        }

        lineRendererComponent.SetPositions(points);
    }
    
}
