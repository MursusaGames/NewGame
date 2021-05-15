using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtnScript : MonoBehaviour
{
    [SerializeField] ViewController view;



    
    public void ShowInGameMenu()
    {
        view.StartGame();
    }
}
