using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBtn : MonoBehaviour
{
    [SerializeField] ViewController view;



    public void ShowLevelsMenu()
    {
        view.ShowLevelsMenu();
    }

    public void ShowMainMenu()
    {
        view.ShowMainMenu();
    }
}
