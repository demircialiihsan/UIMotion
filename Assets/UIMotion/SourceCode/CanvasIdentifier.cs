using UnityEngine;

public abstract class CanvasIdentifier : MonoBehaviour
{
    public virtual void Awake() { }

    [SerializeField] RectTransform canvas;

    protected float canvasWidth, canvasHeight;

    void Start()
    {
        canvasWidth = canvas.rect.width;
        canvasHeight = canvas.rect.height;
    }
}
