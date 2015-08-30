using UnityEngine;

public abstract class Button : MonoBehaviour
{
    private const float MaxDragDistance = 1f;
    private bool _isPressed;
    private Vector3 _pressPosition;

    private void OnMouseDown()
    {
        _isPressed = true;
        _pressPosition = Input.mousePosition;
    }

    void OnMouseUp()
    {
        if (_isPressed && Vector3.Distance(Input.mousePosition, _pressPosition) < MaxDragDistance)
        {
            OnClick();
        }
        _isPressed = false;
    }

    public abstract void OnClick();
}

