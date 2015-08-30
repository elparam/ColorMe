using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject MainMenu;

    public void SetActiveMainMenu(bool active)
    {
        MainMenu.SetActive(active);
    }
}