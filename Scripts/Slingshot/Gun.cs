using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float power = 100f;
    [SerializeField] TraectoryRenderer traectoryRenderer;
    private Camera mainCamera;
   
    void Start()
    {
        mainCamera = Camera.main;
    }
    
    
    void Update()
    {
        float enter;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        new Plane(-Vector3.forward, transform.position).Raycast(ray, out enter);
        Vector3 mouseInWorld = ray.GetPoint(enter);

        Vector3 speed = (mouseInWorld - transform.position) * power;
        transform.rotation = Quaternion.LookRotation(speed);
        traectoryRenderer.ShowTraectory(transform.position, speed);

        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            bullet.AddForce(speed, ForceMode.VelocityChange);
        }
        
    }
}
