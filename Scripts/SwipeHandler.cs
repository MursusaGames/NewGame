using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// События 4 сваипов Left, Right, Up, Down
/// </summary>
public class SwipeHandler : MonoBehaviour
{
    public event Action Left;
    public event Action Right;
    public event Action Up;
    public event Action Down;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0) Swipe();
    }

    void Swipe()
    {
        Vector2 delta = Input.GetTouch(0).deltaPosition; //фмксируем дельту тачеи

        if(Mathf.Abs(delta.x) > Mathf.Abs(delta.y)) //тач по горизонтали
        {
            if(delta.x > 0)  //свеип вправо
            {
                Right?.Invoke();
            }
            else //свеип влево
            {
                Left?.Invoke();
            }
        }
        else //тач по вертикали
        {
            if (delta.y > 0) //свеип вверх
            {
                Up?.Invoke();
            }
            else //свеип вниз
            {
                Down?.Invoke();
            }
        }
    }
}
