using System;
using System.Collections.Generic;
using UnityEngine;

public class Barrier4 : MonoBehaviour
{
    public event Action Barier4;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Barier4?.Invoke();
        }
    }
}
