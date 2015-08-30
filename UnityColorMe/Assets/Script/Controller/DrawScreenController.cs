using UnityEngine;

public class DrawScreenController : MonoBehaviour
{
    public GameObject DrawScreen;

    public void SetActiveDrawScreen(bool active)
    {
         DrawScreen.SetActive(active);
    }
}