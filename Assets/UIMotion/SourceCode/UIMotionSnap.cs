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

    private enum SnapDir { left, right, up, down }

    #region Snap Methods

    #region Left
    public static void SnapLeft(RectTransform content)
    {
        instance.Snap(content, SnapDir.left);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SnapDir.left, offsetRateOverScreenWidth);
    }

    public static void SnapLeft(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.left, curve);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.left, curve, offsetRateOverScreenWidth);
    }

    public static void SnapLeft(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.left, OnSnapEnd);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.left, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapLeft(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.left, curve, OnSnapEnd);
    }

    public static void SnapLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.left, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Right
    public static void SnapRight(RectTransform content)
    {
        instance.Snap(content, SnapDir.right);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SnapDir.right, offsetRateOverScreenWidth);
    }

    public static void SnapRight(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.right, curve);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.right, curve, offsetRateOverScreenWidth);
    }

    public static void SnapRight(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.right, OnSnapEnd);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.right, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapRight(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.right, curve, OnSnapEnd);
    }

    public static void SnapRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.right, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Up
    public static void SnapUp(RectTransform content)
    {
        instance.Snap(content, SnapDir.up);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SnapDir.up, offsetRateOverScreenWidth);
    }

    public static void SnapUp(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.up, curve);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.up, curve, offsetRateOverScreenWidth);
    }

    public static void SnapUp(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.up, OnSnapEnd);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.up, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapUp(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.up, curve, OnSnapEnd);
    }

    public static void SnapUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.up, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Down
    public static void SnapDown(RectTransform content)
    {
        instance.Snap(content, SnapDir.down);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.Snap(content, SnapDir.down, offsetRateOverScreenWidth);
    }

    public static void SnapDown(RectTransform content, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.down, curve);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Snap(content, SnapDir.down, curve, offsetRateOverScreenWidth);
    }

    public static void SnapDown(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.down, OnSnapEnd);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.down, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapDown(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.down, curve, OnSnapEnd);
    }

    public static void SnapDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.Snap(content, SnapDir.down, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #endregion

    #region Snapout Methods

    #region Left
    public static void SnapOutLeft(RectTransform content)
    {
        instance.SnapOut(content, SnapDir.left);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SnapDir.left, offsetRateOverScreenWidth);
    }

    public static void SnapOutLeft(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.left, curve);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.left, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutLeft(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.left, OnSnapEnd);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.left, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutLeft(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.left, curve, OnSnapEnd);
    }

    public static void SnapOutLeft(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.left, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Right
    public static void SnapOutRight(RectTransform content)
    {
        instance.SnapOut(content, SnapDir.right);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SnapDir.right, offsetRateOverScreenWidth);
    }

    public static void SnapOutRight(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.right, curve);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.right, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutRight(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.right, OnSnapEnd);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.right, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutRight(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.right, curve, OnSnapEnd);
    }

    public static void SnapOutRight(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.right, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Up
    public static void SnapOutUp(RectTransform content)
    {
        instance.SnapOut(content, SnapDir.up);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SnapDir.up, offsetRateOverScreenWidth);
    }

    public static void SnapOutUp(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.up, curve);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.up, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutUp(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.up, OnSnapEnd);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.up, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutUp(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.up, curve, OnSnapEnd);
    }

    public static void SnapOutUp(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.up, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #region Down
    public static void SnapOutDown(RectTransform content)
    {
        instance.SnapOut(content, SnapDir.down);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth)
    {
        instance.SnapOut(content, SnapDir.down, offsetRateOverScreenWidth);
    }

    public static void SnapOutDown(RectTransform content, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.down, curve);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve)
    {
        instance.SnapOut(content, SnapDir.down, curve, offsetRateOverScreenWidth);
    }

    public static void SnapOutDown(RectTransform content, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.down, OnSnapEnd);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.down, OnSnapEnd, offsetRateOverScreenWidth);
    }

    public static void SnapOutDown(RectTransform content, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.down, curve, OnSnapEnd);
    }

    public static void SnapOutDown(RectTransform content, float offsetRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSnapEnd)
    {
        instance.SnapOut(content, SnapDir.down, curve, OnSnapEnd, offsetRateOverScreenWidth);
    }
    #endregion

    #endregion

    void Snap(RectTransform content, SnapDir dir, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, defaultCurve));
    }

    void Snap(RectTransform content, SnapDir dir, AnimationCurve curve, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, curve));
    }

    void Snap(RectTransform content, SnapDir dir, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, defaultCurve, OnSnapEnd));
    }

    void Snap(RectTransform content, SnapDir dir, AnimationCurve curve, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, curve, OnSnapEnd));
    }

    void SnapOut(RectTransform content, SnapDir dir, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, defaultCurve));
    }

    void SnapOut(RectTransform content, SnapDir dir, AnimationCurve curve, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(Animate(content, target, curve));
    }

    void SnapOut(RectTransform content, SnapDir dir, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, defaultCurve, OnSnapEnd));
    }

    void SnapOut(RectTransform content, SnapDir dir, AnimationCurve curve, UnityEvent OnSnapEnd, float offsetRate = 0)
    {
        Vector2 target = SnapOutTarget(content, dir, offsetRate);

        StartCoroutine(AnimateWithEvent(content, target, curve, OnSnapEnd));
    }

    Vector2 SnapTarget(RectTransform content, SnapDir dir, float offsetRate)
    {
        if (dir == SnapDir.left)
        {
            return content.anchoredPosition + Vector2.left * (DistanceToLeft(content) - canvasWidth * offsetRate);
        }
        else if (dir == SnapDir.right)
        {
            return content.anchoredPosition + Vector2.right * (DistanceToRight(content) - canvasWidth * offsetRate);
        }
        else if (dir == SnapDir.up)
        {
            return content.anchoredPosition + Vector2.up * (DistanceToUp(content) - canvasHeight * offsetRate);
        }
        else if (dir == SnapDir.down)
        {
            return content.anchoredPosition + Vector2.down * (DistanceToDown(content) - canvasHeight * offsetRate);
        }
        else
        {
            throw new System.Exception("Invalid direction");
        }
    }

    Vector2 SnapOutTarget(RectTransform content, SnapDir dir, float offsetRate)
    {
        if (dir == SnapDir.left)
        {
            return content.anchoredPosition + Vector2.left * (DistanceToLeft(content) + content.rect.width + canvasWidth * offsetRate);
        }
        else if (dir == SnapDir.right)
        {
            return content.anchoredPosition + Vector2.right * (DistanceToRight(content) + content.rect.width + canvasWidth * offsetRate);
        }
        else if (dir == SnapDir.up)
        {
            return content.anchoredPosition + Vector2.up * (DistanceToUp(content) + content.rect.height + canvasHeight * offsetRate);
        }
        else if (dir == SnapDir.down)
        {
            return content.anchoredPosition + Vector2.down * (DistanceToDown(content) + content.rect.height + canvasHeight * offsetRate);
        }
        else
        {
            throw new System.Exception("Invalid direction");
        }
    }

    float DistanceToLeft(RectTransform content)
    {
        float measure = content.anchorMin.x * content.parent.GetComponent<RectTransform>().rect.width + content.offsetMin.x;

        if (content.parent != content.root)
            measure += DistanceToLeft(content.parent.GetComponent<RectTransform>());

        return measure;
    }

    float DistanceToRight(RectTransform content)
    {
        float measure = (1 - content.anchorMax.x) * content.parent.GetComponent<RectTransform>().rect.width - content.offsetMax.x;

        if (content.parent != content.root)
            measure += DistanceToRight(content.parent.GetComponent<RectTransform>());

        return measure;
    }

    float DistanceToUp(RectTransform content)
    {
        float measure = (1 - content.anchorMax.y) * content.parent.GetComponent<RectTransform>().rect.height - content.offsetMax.y;

        if (content.parent != content.root)
            measure += DistanceToUp(content.parent.GetComponent<RectTransform>());

        return measure;
    }

    float DistanceToDown(RectTransform content)
    {
        float measure = content.anchorMin.y * content.parent.GetComponent<RectTransform>().rect.height + content.offsetMin.y;

        if (content.parent != content.root)
            measure += DistanceToDown(content.parent.GetComponent<RectTransform>());

        return measure;
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
