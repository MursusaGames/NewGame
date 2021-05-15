using System;
using System.Collections.Generic;
using UnityEngine;

public class Barrier3 : MonoBehaviour
{
    public event Action Barier3;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Barier3?.Invoke();
        }
    }
}
