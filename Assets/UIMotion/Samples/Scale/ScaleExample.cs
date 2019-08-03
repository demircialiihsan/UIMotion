using UnityEngine;
using UnityEngine.Events;

public class ScaleExample : MonoBehaviour
{
    public AnimationCurve curve;
    public UnityEvent OnScaleEnd;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void ScaleToZero()
    {
        UIMotionScale.ScaleToZero(rectTransform, curve, OnScaleEnd);
    }

    public void ScaleToOne()
    {
        UIMotionScale.ScaleToOne(rectTransform, curve, OnScaleEnd);
    }

    public void ScaleBy(float scaleFactor)
    {
        UIMotionScale.ScaleBy(rectTransform, scaleFactor, curve, OnScaleEnd);
    }

    public void ScaleEnd()
    {
        Debug.Log("SCALING ENDED!");
    }
}
