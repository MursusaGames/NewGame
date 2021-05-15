using System;
using System.Collections.Generic;
using UnityEngine;

public class FirstBarier : MonoBehaviour
{
    public event Action Barier1;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Barier1?.Invoke();
        }
    }
}
