using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatCastle : MonoBehaviour
{
    [SerializeField] Transform parent;
    [SerializeField] Transform hausPoint;
    [SerializeField] private float width = 0;
    [SerializeField] private float height;
    [SerializeField] private float length;
    [SerializeField] private float window;
    [SerializeField] Color color;
    [SerializeField] Material alfa0;
    

    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(1f,0.5f,0.5f);
        cube.GetComponent<Renderer>().material.color = color;
        cube.transform.position = new Vector3(0, -10, 0);
        cube.transform.SetParent(parent);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<Rigidbody>();
        
       
        
        for(int i = 0; i < width; i++)
        {
            
            
            for(float j = 0; j < height; j+=0.5f)
            {
                Instantiate(cube, hausPoint.position + new Vector3(i, j, 0), Quaternion.identity, parent);
                
                
            }
        }
        if(window >= 1)
        {
            
            transform.GetChild(16).gameObject.GetComponent<Renderer>().material = alfa0;
            transform.GetChild(17).gameObject.GetComponent<Renderer>().material = alfa0;
            if(window >= 2)
            {
                transform.GetChild(85).gameObject.GetComponent<Renderer>().material = alfa0;
                transform.GetChild(86).gameObject.GetComponent<Renderer>().material = alfa0;
            }
            if(window >= 3)
            {
                transform.GetChild(19).gameObject.GetComponent<Renderer>().material = alfa0;
                transform.GetChild(20).gameObject.GetComponent<Renderer>().material = alfa0;
            }
            if (window >= 4)
            {
                transform.GetChild(48).gameObject.GetComponent<Renderer>().material = alfa0;
                transform.GetChild(49).gameObject.GetComponent<Renderer>().material = alfa0;
            }
            if (window >= 5)
            {
                transform.GetChild(15).gameObject.GetComponent<Renderer>().material = alfa0;
                transform.GetChild(16).gameObject.GetComponent<Renderer>().material = alfa0;
            }
            if (window >= 6)
            {
                transform.GetChild(81).gameObject.GetComponent<Renderer>().material = alfa0;
                transform.GetChild(82).gameObject.GetComponent<Renderer>().material = alfa0;
            }





        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
