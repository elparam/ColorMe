using UnityEngine;

public class WhiteList : MonoBehaviour
{
    public GameObject Line;
    public GameObject Point;
    private LineRenderer _lineRenderer;
    private float _drawlayer = -0.3f;
    private bool _paint;

    private Vector3 _end = Vector3.zero;

    void Start()
    {
        SetColor(Color.red);
        _lineRenderer = Line.GetComponent<LineRenderer>();
    }

    private void StartPaint()
    {
        _paint = true;
    }

    private void Update()
    {
        if (_paint)
        {
            if (Vector3.Distance(_end, GetMousePosition()) > 0.01f)
            {
                if (_lineRenderer != null)
                {
                    _lineRenderer.SetPosition(0, _end);
                    _lineRenderer.SetPosition(1, GetMousePosition());
                }

                Instantiate(Point, _end, Quaternion.identity);
                Instantiate(Line, transform.position, Quaternion.identity);
                _end = GetMousePosition();
            }
        }
    }

    void OnMouseDown()
    {
        _end = GetMousePosition();
        _paint = true;
    }

    void OnMouseUp()
    {
        _paint = false;
        _end = Vector3.zero;
        _drawlayer = _drawlayer - 0.01f;
    }

    private Vector3 GetMousePosition()
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = _drawlayer;
        return pos;
    }

    public void SetColor(Color color)
    {
        Line.GetComponent<LineRenderer>().SetColors(color, color);
        Point.GetComponent<SpriteRenderer>().color = color;
    }

    void DisableButtons()
    {
        
    }
}
