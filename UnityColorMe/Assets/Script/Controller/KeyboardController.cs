using UnityEngine;

class KeyboardController : MonoBehaviour
{
    void Start() { }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            FindObjectOfType<MainController>().ShowMainMenu();
        }
    }

}