using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] Transform startPoint;
    ////[SerializeField] GameObject table;

    private void OnEnable()
    {
        transform.position = startPoint.position;
        //table.SetActive(true);
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
