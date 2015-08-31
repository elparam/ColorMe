using UnityEngine;

public class MainController : MonoBehaviour
{
    public SpriteRenderer Background;
    public MenuController MenuController;
    public DrawScreenController DrawScreenController;

    void Start()
    {
    }

    void Update()
    {
    }

    public void ShwoDrawScreen()
    {
        MenuController.SetActiveMainMenu(false);
        DrawScreenController.SetActiveDrawScreen(true);
    }

    public void ShowMainMenu()
    {
        MenuController.SetActiveMainMenu(true);
        DrawScreenController.SetActiveDrawScreen(false);
    }
}