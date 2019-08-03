using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class UIMotionSlide : CanvasIdentifier
{
    #region Private Singleton
    private static UIMotionSlide instance;

    public override void Awake()
    {
        instance = this;
    }
    #endregion

    [Tooltip("The curve that will be animated if not supplied any")]
    public AnimationCurve defaultCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    private enum SlideDir { left, right, up, down }

    #region Static Methods

    #region Left
    public static void SlideLeft(RectTransform content)
    {
        instance.Slide(content, SlideDir.left);
    }

    public static void SlideLeft(RectTransform content, float slideRateOverScreenWidth)
    {
        instance.Slide(content, SlideDir.left, slideRateOverScreenWidth);
    }

    public static void SlideLeft(RectTransform content, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.left, curve);
    }

    public static void SlideLeft(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.left, curve, slideRateOverScreenWidth);
    }

    public static void SlideLeft(RectTransform content, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.left, OnSlideEnd);
    }

    public static void SlideLeft(RectTransform content, float slideRateOverScreenWidth, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.left, OnSlideEnd, slideRateOverScreenWidth);
    }

    public static void SlideLeft(RectTransform content, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.left, curve, OnSlideEnd);
    }

    public static void SlideLeft(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.left, curve, OnSlideEnd, slideRateOverScreenWidth);
    }
    #endregion

    #region Right
    public static void SlideRight(RectTransform content)
    {
        instance.Slide(content, SlideDir.right);
    }

    public static void SlideRight(RectTransform content, float slideRateOverScreenWidth)
    {
        instance.Slide(content, SlideDir.right, slideRateOverScreenWidth);
    }

    public static void SlideRight(RectTransform content, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.right, curve);
    }

    public static void SlideRight(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.right, curve, slideRateOverScreenWidth);
    }

    public static void SlideRight(RectTransform content, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.right, OnSlideEnd);
    }

    public static void SlideRight(RectTransform content, float slideRateOverScreenWidth, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.right, OnSlideEnd, slideRateOverScreenWidth);
    }

    public static void SlideRight(RectTransform content, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.right, curve, OnSlideEnd);
    }

    public static void SlideRight(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.right, curve, OnSlideEnd, slideRateOverScreenWidth);
    }
    #endregion

    #region Up
    public static void SlideUp(RectTransform content)
    {
        instance.Slide(content, SlideDir.up);
    }

    public static void SlideUp(RectTransform content, float slideRateOverScreenWidth)
    {
        instance.Slide(content, SlideDir.up, slideRateOverScreenWidth);
    }

    public static void SlideUp(RectTransform content, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.up, curve);
    }

    public static void SlideUp(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.up, curve, slideRateOverScreenWidth);
    }

    public static void SlideUp(RectTransform content, float slideRateOverScreenWidth, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.up, OnSlideEnd, slideRateOverScreenWidth);
    }

    public static void SlideUp(RectTransform content, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.up, OnSlideEnd);
    }

    public static void SlideUp(RectTransform content, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.up, curve, OnSlideEnd);
    }

    public static void SlideUp(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.up, curve, OnSlideEnd, slideRateOverScreenWidth);
    }
    #endregion

    #region Down
    public static void SlideDown(RectTransform content)
    {
        instance.Slide(content, SlideDir.down);
    }

    public static void SlideDown(RectTransform content, float slideRateOverScreenWidth)
    {
        instance.Slide(content, SlideDir.down, slideRateOverScreenWidth);
    }

    public static void SlideDown(RectTransform content, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.down, curve);
    }

    public static void SlideDown(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve)
    {
        instance.Slide(content, SlideDir.down, curve, slideRateOverScreenWidth);
    }

    public static void SlideDown(RectTransform content, float slideRateOverScreenWidth, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.down, OnSlideEnd, slideRateOverScreenWidth);
    }

    public static void SlideDown(RectTransform content, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.down, OnSlideEnd);
    }

    public static void SlideDown(RectTransform content, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.down, curve, OnSlideEnd);
    }

    public static void SlideDown(RectTransform content, float slideRateOverScreenWidth, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        instance.Slide(content, SlideDir.down, curve, OnSlideEnd, slideRateOverScreenWidth);
    }
    #endregion

    #endregion

    void Slide(RectTransform content, SlideDir dir, float slideRate = 1)
    {
        Vector2 target = Target(content, dir, slideRate);

        StartCoroutine(Animate(content, target, defaultCurve));
    }

    void Slide(RectTransform content, SlideDir dir, AnimationCurve curve, float slideRate = 1)
    {
        Vector2 target = Target(content, dir, slideRate);

        StartCoroutine(Animate(content, target, curve));
    }

    void Slide(RectTransform content, SlideDir dir, UnityEvent OnSlideEnd, float slideRate = 1)
    {
        Vector2 target = Target(content, dir, slideRate);

        StartCoroutine(AnimateWithEvent(content, target, defaultCurve, OnSlideEnd));
    }

    void Slide(RectTransform content, SlideDir dir, AnimationCurve curve, UnityEvent OnSlideEnd, float slideRate = 1)
    {
        Vector2 target = Target(content, dir, slideRate);

        StartCoroutine(AnimateWithEvent(content, target, curve, OnSlideEnd));
    }

    Vector2 Target(RectTransform content, SlideDir dir, float slideRate)
    {
        if (dir == SlideDir.left)
        {
            return content.anchoredPosition + (Vector2.left * canvasWidth * slideRate);
        }
        else if (dir == SlideDir.right)
        {
            return content.anchoredPosition + (Vector2.right * canvasWidth * slideRate);
        }
        else if (dir == SlideDir.up)
        {
            return content.anchoredPosition + (Vector2.up * canvasHeight * slideRate);
        }
        else if (dir == SlideDir.down)
        {
            return content.anchoredPosition + (Vector2.down * canvasHeight * slideRate);
        }
        else
        {
            throw new System.Exception("Invalid direction");
        }
    }

    IEnumerator AnimateWithEvent(RectTransform content, Vector2 target, AnimationCurve curve, UnityEvent OnSlideEnd)
    {
        yield return StartCoroutine(Animate(content, target, curve));
        OnSlideEnd.Invoke();
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
