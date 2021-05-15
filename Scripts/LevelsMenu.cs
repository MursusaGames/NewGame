using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsMenu : MonoBehaviour
{
    [SerializeField] Text level_1_result;
    // Start is called before the first frame update
    void Start()
    {
        level_1_result.text = PlayerPrefs.GetFloat("1_Level").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
