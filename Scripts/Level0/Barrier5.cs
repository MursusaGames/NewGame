using System;
using System.Collections.Generic;
using UnityEngine;

public class Barrier5 : MonoBehaviour
{
    public event Action Barier5;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Barier5?.Invoke();
        }
    }
}
