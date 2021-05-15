using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotweenDemo : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    void Start()
    {
        DOTween.Init();
        //var position = bullet.transform.position.x;
        //var targetPosition = position + 2;
        
        //var animationSecuence = DOTween.Sequence();
        //animationSecuence.Append(bullet.transform.DOMoveX(targetPosition, 1f));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            DOTween.To(() => bullet.transform.position, x => bullet.transform.position = x, bullet.transform.position + new Vector3(3, 0, 0), 1f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DOTween.To(() => bullet.transform.position, x => bullet.transform.position = x, bullet.transform.position + new Vector3(-3, 0, 0), 1f);
        }
    }
}
