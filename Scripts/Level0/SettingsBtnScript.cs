using UnityEngine;

public class SettingsBtnScript : MonoBehaviour
{
    [SerializeField] ViewController view;
   

   
    public void ShowSettingsMenu()
    {
        view.ShowSettingsMenu();
    }

    public void ShowMainMenu()
    {
        view.ShowMainMenu();
    }
}
