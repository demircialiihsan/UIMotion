using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class UIMotionSnap : CanvasIdentifier
{
    #region Private Singleton
    private static UIMotionSnap instance;

    public override void Awake()
    {
        instance = this;
    }
    #endregion

    [Tooltip("The curve that will be animated if not supplied any")]
    public AnimationCurve defaultCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    private enum SlideDir { left, right, up, down }

    #region Snap Methods

    #region Left
    public static void SnapLeft(RectTransform content)
    {
        instance.Snap(content, SlideDir.left);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SlideDir.left, offsetRateOverScreenWidth);
    }

    public static void SnapLeft(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.left, curve);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.left, curve, offsetRateOverScreenWidth);
    }

    public static void SnapLeft(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.left, OnSnapEnd);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.left, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapLeft(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.left, curve, OnSnapEnd);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.left, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Right
    public static void SnapRight(RectTransform content)
    {
        instance.Snap(content, SlideDir.right);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SlideDir.right, offsetRateOverScreenWidth);
    }

    public static void SnapRight(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.right, curve);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.right, curve, offsetRateOverScreenWidth);
    }

    public static void SnapRight(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.right, OnSnapEnd);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.right, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapRight(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.right, curve, OnSnapEnd);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.right, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Up
    public static void SnapUp(RectTransform content)
    {
        instance.Snap(content, SlideDir.up);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SlideDir.up, offsetRateOverScreenWidth);
    }

    public static void SnapUp(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.up, curve);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.up, curve, offsetRateOverScreenWidth);
    }

    public static void SnapUp(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.up, OnSnapEnd);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.up, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapUp(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.up, curve, OnSnapEnd);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.up, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Down
    public static void SnapDown(RectTransform content)
    {
        instance.Snap(content, SlideDir.down);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SlideDir.down, offsetRateOverScreenWidth);
    }

    public static void SnapDown(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.down, curve);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SlideDir.down, curve, offsetRateOverScreenWidth);
    }

    public static void SnapDown(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.down, OnSnapEnd);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.down, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapDown(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.down, curve, OnSnapEnd);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SlideDir.down, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #endregion

    #region Snapout Methods

    #region Left
    public static void SnapOutLeft(RectTransform content)
    {
        instance.SnapOut(content, SlideDir.left);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SlideDir.left, offsetRateOverScreenWidth);
    }

    public static void SnapOutLeft(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.left, curve);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.left, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutLeft(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.left, OnSnapEnd);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.left, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutLeft(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.left, curve, OnSnapEnd);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.left, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Right
    public static void SnapOutRight(RectTransform content)
    {
        instance.SnapOut(content, SlideDir.right);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SlideDir.right, offsetRateOverScreenWidth);
    }

    public static void SnapOutRight(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.right, curve);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.right, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutRight(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.right, OnSnapEnd);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.right, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutRight(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.right, curve, OnSnapEnd);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.right, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Up
    public static void SnapOutUp(RectTransform content)
    {
        instance.SnapOut(content, SlideDir.up);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SlideDir.up, offsetRateOverScreenWidth);
    }

    public static void SnapOutUp(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.up, curve);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.up, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutUp(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.up, OnSnapEnd);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.up, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutUp(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.up, curve, OnSnapEnd);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.up, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Down
    public static void SnapOutDown(RectTransform content)
    {
        instance.SnapOut(content, SlideDir.down);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SlideDir.down, offsetRateOverScreenWidth);
    }

    public static void SnapOutDown(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.down, curve);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SlideDir.down, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutDown(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.down, OnSnapEnd);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.down, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutDown(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.down, curve, OnSnapEnd);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SlideDir.down, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #endregion

    void Snap(RectTransform content, SlideDir dir, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, defaultCurve));
    }

    void Snap(RectTransform content, SlideDir dir, AnimationCurve curve, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, curve));
    }

    void Snap(RectTransform content, SlideDir dir, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, defaultCurve, OnSnapEnd));
    }

    void Snap(RectTransform content, SlideDir dir, AnimationCurve curve, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, curve, OnSnapEnd));
    }

    void SnapOut(RectTransform content, SlideDir dir, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, defaultCurve));
    }

    void SnapOut(RectTransform content, SlideDir dir, AnimationCurve curve, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, curve));
    }

    void SnapOut(RectTransform content, SlideDir dir, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, defaultCurve, OnSnapEnd));
    }

    void SnapOut(RectTransform content, SlideDir dir, AnimationCurve curve, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, curve, OnSnapEnd));
    }

    Vector2 SnapTarget(RectTransform content, SlideDir dir, float offsetRate)
    {
        if (dir == SlideDir.left)
        {
            return content.anchoredPosition + Vector2.left * (content.anchorMin.x * canvasWidth + content.offsetMin.x - canvasWidth * offsetRate);
        }
        else if (dir == SlideDir.right)
        {
            return content.anchoredPosition + Vector2.right * ((1 - content.anchorMax.x) * canvasWidth - content.offsetMax.x - canvasWidth * offsetRate);
        }
        else if (dir == SlideDir.up)
        {
            return content.anchoredPosition + Vector2.up * ((1 - content.anchorMax.y) * canvasHeight - content.offsetMax.y - canvasHeight * offsetRate);
        }
        else if (dir == SlideDir.down)
        {
            return content.anchoredPosition + Vector2.down * (content.anchorMin.y * canvasHeight + content.offsetMin.y - canvasHeight * offsetRate);
        }
        else
        {
            throw new System.Exception("Invalid direction");
        }
    }

    Vector2 SnapOutTarget(RectTransform content, SlideDir dir, float offsetRate)
    {
        if (dir == SlideDir.left)
        {
            return content.anchoredPosition + Vector2.left * (content.anchorMin.x * canvasWidth + content.offsetMin.x + content.rect.width + canvasWidth * offsetRate);
        }
        else if (dir == SlideDir.right)
        {
            return content.anchoredPosition + Vector2.right * ((1 - content.anchorMax.x) * canvasWidth - content.offsetMax.x + content.rect.width + canvasWidth * offsetRate);
        }
        else if (dir == SlideDir.up)
        {
            return content.anchoredPosition + Vector2.up * ((1 - content.anchorMax.y) * canvasHeight - content.offsetMax.y + content.rect.height + canvasHeight * offsetRate);
        }
        else if (dir == SlideDir.down)
        {
            return content.anchoredPosition + Vector2.down * (content.anchorMin.y * canvasHeight + content.offsetMin.y + content.rect.height + canvasHeight * offsetRate);
        }
        else
        {
            throw new System.Exception("Invalid direction");
        }
    }


    IEnumerator AnimateWithEvent(RectTransform content, Vector2 target, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        yield return StartCoroutine(Animate(content, target, curve));
        OnSnapEnd.Invoke();
    }

    IEnumerator Animate(RectTransform content, Vector2 target, AnimationCurve curve)
    {
        if (curve.length == 0)
        {
            throw new System.Exception("Curve empty");
        }

        float startTime = curve.keys[0].time;
        float endTime = curve.keys[curve.length - 1].time;
        float timer = startTime;

        float magnitude = curve.keys[curve.length - 1].value - curve.keys[0].value;
        Vector2 scaledMagnitude = (target - content.anchoredPosition) / magnitude;

        float currentValue = curve.Evaluate(timer);

        while (timer < endTime)
        {
            float nextValue = curve.Evaluate(timer += Time.deltaTime);
            float deltaValue = nextValue - currentValue;

            content.anchoredPosition += scaledMagnitude * deltaValue;
            currentValue = nextValue;

            yield return null;
        }
        content.anchoredPosition = target;
    }
}
