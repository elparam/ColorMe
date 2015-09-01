using UnityEngine;

public class ColorButton : Button
{
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() { }

    public override void OnClick()
    {
        FindObjectOfType<WhiteList>().SetColor(_spriteRenderer.color);
    }
}
