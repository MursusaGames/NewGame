using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloude : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject cloudSphere;
    public int numSphereMin = 6;
    public int numSphereMax = 10;
    public Vector3 spherOffsetScale = new Vector3(5, 2, 1);
    public Vector2 sphereRangeX = new Vector2(4, 8);
    public Vector2 sphereRangeY = new Vector2(3, 4);
    public Vector2 sphereRangeZ = new Vector2(2, 4);
    public float scaleYMin = 2.0f;

    private List<GameObject> spheres;

    // Start is called before the first frame update
    void Start()
    {
        spheres = new List<GameObject>();
        int num = Random.Range(numSphereMin, numSphereMax);
        for(int i =0; i < num; i++)
        {
            GameObject sp = Instantiate<GameObject>(cloudSphere);
            spheres.Add(sp);
            Transform spTrans = sp.transform;
            spTrans.SetParent(this.transform);
            Vector3 offset = Random.insideUnitSphere;
            offset.x *= spherOffsetScale.x;
            offset.y *= spherOffsetScale.y;
            offset.z *= spherOffsetScale.z;
            spTrans.localPosition = offset;

            Vector3 scale = Vector3.one;
            scale.x = Random.Range(sphereRangeX.x, sphereRangeX.y);
            scale.y = Random.Range(sphereRangeY.x, sphereRangeY.y);
            scale.z = Random.Range(sphereRangeZ.x, sphereRangeZ.y);

            scale.y *= 1 - (Mathf.Abs(offset.x) / spherOffsetScale.x);
            scale.y = Mathf.Max(scale.y, scaleYMin);

            spTrans.localScale = scale;

        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restart();
        }
    }

    void Restart()
    {
        foreach(GameObject sp in spheres)
        {
            Destroy(sp);
        }

        Start();
    }

    
}
