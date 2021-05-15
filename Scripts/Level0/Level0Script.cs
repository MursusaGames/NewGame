using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level0Script : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<AudioSource>().Play();
        GameManager.instance.UpdateText();
    }
}
