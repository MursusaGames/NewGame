using System;
using System.Collections.Generic;
using UnityEngine;

public class SecondBarier : MonoBehaviour
{
    public event Action Barier2;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Barier2?.Invoke();
        }
    }
}
