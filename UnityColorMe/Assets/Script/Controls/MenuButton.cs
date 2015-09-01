public class MenuButton : Button
{
    public MenuButtonType ButtonType;

    void Start() { }

    void Update() { }

    public override void OnClick()
    {
        switch (ButtonType)
        {
            case MenuButtonType.RandomDraw:
                FindObjectOfType<MainController>().ShwoDrawScreen();
                break;
        }
    }

    public enum MenuButtonType
    {
        RandomDraw,
        OpenCatalog
    }
}
