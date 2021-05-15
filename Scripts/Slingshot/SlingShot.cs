using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShot : MonoBehaviour
{
    static private SlingShot S;
    [Header("Set in Inspector")]
    public GameObject prefabProjectail;
    public float velosityMult = 8.0f;

    [Header("Set Dinamically")]
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectail;
    public bool isAimingMode;
    private Rigidbody projectileRb;
    [SerializeField] TraectoryRenderer traectoryRenderer;

    static public Vector3 LAUNCH_POS
    {
        get { if(S == null){return Vector3.zero;}
            return S.launchPos;
        }
    }

    private void Awake()
    {
        S = this;
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }
    public void OnMouseEnter()
    {
        launchPoint.SetActive(true);
    }

    public void OnMouseExit()
    {
        launchPoint.SetActive(false);
    }

    public void OnMouseDown()
    {
        isAimingMode = true;

        projectail = Instantiate(prefabProjectail) as GameObject;
        projectail.transform.position = launchPos;
        projectileRb = projectail.GetComponent<Rigidbody>();
        projectileRb.isKinematic = true;
       



    }

    private void Update()
    {
        if (!isAimingMode) return;
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.WorldToScreenPoint(mousePos2D);
        Vector3 mouseDelta = mousePos3D - launchPos;
        float maxMagnitude = this.GetComponent<SphereCollider>().radius;
        traectoryRenderer.ShowTraectory(launchPos, (mouseDelta - launchPos) * velosityMult);
        if (mouseDelta.magnitude > maxMagnitude)
        {
            mouseDelta.Normalize();
            mouseDelta *= maxMagnitude;
        }
        Vector3 projPos = launchPos + mouseDelta;
        projectail.transform.position = projPos;

        if (Input.GetMouseButtonUp(0))
        {
            isAimingMode = false;
            projectileRb.isKinematic = false;
            projectileRb.velocity = -mouseDelta * velosityMult;
            FollowCam.POI = projectail;
            projectail = null;
            //MissionDemolition.ShotFired(); подсчет выстрелов
            ProjectailLine.S.poi = projectail;
        }

    }
}
