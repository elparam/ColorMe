using UnityEngine;

public abstract class Button : MonoBehaviour
{
    private bool _isPressed;

    private void OnMouseDown()
    {
        _isPressed = true;
    }

    void OnMouseUp()
    {
        if (_isPressed)
        {
            OnClick();
        }
        _isPressed = false;
    }

    public abstract void OnClick();
}

