using UnityEngine;
using UnityEngine.Events;

public class SnapExample : MonoBehaviour
{
    public AnimationCurve curve;
    public UnityEvent OnSnapEnd;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SnapUp()
    {
        UIMotionSnap.SnapUp(rectTransform, curve, OnSnapEnd);
    }

    public void SnapDown()
    {
        UIMotionSnap.SnapDown(rectTransform, curve, OnSnapEnd);
    }

    public void SnapLeft()
    {
        UIMotionSnap.SnapLeft(rectTransform, curve, OnSnapEnd);
    }

    public void SnapRight()
    {
        UIMotionSnap.SnapRight(rectTransform, curve, OnSnapEnd);
    }

    public void SnapOutUp()
    {
        UIMotionSnap.SnapOutUp(rectTransform, curve, OnSnapEnd);
    }

    public void SnapOutDown()
    {
        UIMotionSnap.SnapOutDown(rectTransform, curve, OnSnapEnd);
    }

    public void SnapOutLeft()
    {
        UIMotionSnap.SnapOutLeft(rectTransform, curve, OnSnapEnd);
    }

    public void SnapOutRight()
    {
        UIMotionSnap.SnapOutRight(rectTransform, curve, OnSnapEnd);
    }

    public void SnapEnd()
    {
        Debug.Log("SNAPPING ENDED!");
    }
}
