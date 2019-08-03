using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class UIMotionScale : MonoBehaviour
{
    #region Private Singleton
    private static UIMotionScale instance;

    public void Awake()
    {
        instance = this;
    }
    #endregion

    [Tooltip("The curve that will be animated if not supplied any")]
    public AnimationCurve defaultCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    #region Static Methods

    #region Scale to one
    public static void ScaleToOne(RectTransform content)
    {
        instance.m_ScaleTo(content, Vector3.one);
    }

    public static void ScaleToOne(RectTransform content, AnimationCurve curve)
    {
        instance.m_ScaleTo(content, Vector3.one, curve);
    }

    public static void ScaleToOne(RectTransform content, UnityEvent OnScaleEnd)
    {
        instance.m_ScaleTo(content, Vector3.one, OnScaleEnd);
    }

    public static void ScaleToOne(RectTransform content, AnimationCurve curve, UnityEvent OnScaleEnd)
    {
        instance.m_ScaleTo(content, Vector3.one, curve, OnScaleEnd);
    }
    #endregion

    #region Scale to zero
    public static void ScaleToZero(RectTransform content)
    {
        instance.m_ScaleTo(content, Vector3.zero);
    }

    public static void ScaleToZero(RectTransform content, AnimationCurve curve)
    {
        instance.m_ScaleTo(content, Vector3.zero, curve);
    }

    public static void ScaleToZero(RectTransform content, UnityEvent OnScaleEnd)
    {
        instance.m_ScaleTo(content, Vector3.zero, OnScaleEnd);
    }

    public static void ScaleToZero(RectTransform content, AnimationCurve curve, UnityEvent OnScaleEnd)
    {
        instance.m_ScaleTo(content, Vector3.zero, curve, OnScaleEnd);
    }
    #endregion

    #region Scale by
    public static void ScaleBy(RectTransform content, float scaleFactor)
    {
        instance.m_ScaleBy(content, scaleFactor);
    }

    public static void ScaleBy(RectTransform content, float scaleFactor, AnimationCurve curve)
    {
        instance.m_ScaleBy(content, scaleFactor, curve);
    }

    public static void ScaleBy(RectTransform content, float scaleFactor, UnityEvent OnScaleEnd)
    {
        instance.m_ScaleBy(content, scaleFactor, OnScaleEnd);
    }

    public static void ScaleBy(RectTransform content, float scaleFactor, AnimationCurve curve, UnityEvent OnScaleEnd)
    {
        instance.m_ScaleBy(content, scaleFactor, curve, OnScaleEnd);
    }
    #endregion

    #endregion

    void m_ScaleTo(RectTransform content, Vector3 target)
    {
        StartCoroutine(AnimateScaleTo(content, target, defaultCurve));
    }

    void m_ScaleTo(RectTransform content, Vector3 target, AnimationCurve curve)
    {
        StartCoroutine(AnimateScaleTo(content, target, curve));
    }

    void m_ScaleTo(RectTransform content, Vector3 target, UnityEvent OnScaleEnd)
    {
        StartCoroutine(AnimateScaleToWithEvent(content, target, defaultCurve, OnScaleEnd));
    }

    void m_ScaleTo(RectTransform content, Vector3 target, AnimationCurve curve, UnityEvent OnScaleEnd)
    {
        StartCoroutine(AnimateScaleToWithEvent(content, target, curve, OnScaleEnd));
    }

    void m_ScaleBy(RectTransform content, float scaleFactor)
    {
        Vector2 target = ScaleTarget(content, scaleFactor);

        StartCoroutine(AnimateScaleBy(content, target, defaultCurve));
    }

    void m_ScaleBy(RectTransform content, float scaleFactor, AnimationCurve curve)
    {
        Vector2 target = ScaleTarget(content, scaleFactor);

        StartCoroutine(AnimateScaleBy(content, target, curve));
    }

    void m_ScaleBy(RectTransform content, float scaleFactor, UnityEvent OnScaleEnd)
    {
        Vector2 target = ScaleTarget(content, scaleFactor);

        StartCoroutine(AnimateScaleByWithEvent(content, target, defaultCurve, OnScaleEnd));
    }

    void m_ScaleBy(RectTransform content, float scaleFactor, AnimationCurve curve, UnityEvent OnScaleEnd)
    {
        Vector2 target = ScaleTarget(content, scaleFactor);

        StartCoroutine(AnimateScaleByWithEvent(content, target, curve, OnScaleEnd));
    }

    Vector2 ScaleTarget(RectTransform content, float scaleFactor)
    {
        return content.sizeDelta * scaleFactor;
    }

    IEnumerator AnimateScaleToWithEvent(RectTransform content, Vector3 target, AnimationCurve curve, UnityEvent OnScaleEnd)
    {
        yield return StartCoroutine(AnimateScaleTo(content, target, curve));
        OnScaleEnd.Invoke();
    }

    IEnumerator AnimateScaleTo(RectTransform content, Vector3 target, AnimationCurve curve)
    {
        if (curve.length == 0)
        {
            throw new System.Exception("Curve empty");
        }

        float startTime = curve.keys[0].time;
        float endTime = curve.keys[curve.length - 1].time;
        float timer = startTime;

        float magnitude = curve.keys[curve.length - 1].value - curve.keys[0].value;
        Vector3 scaledMagnitude = (target - content.localScale) / magnitude;

        float currentValue = curve.Evaluate(timer);

        while (timer < endTime)
        {
            float nextValue = curve.Evaluate(timer += Time.deltaTime);
            float deltaValue = nextValue - currentValue;

            content.localScale += scaledMagnitude * deltaValue;
            currentValue = nextValue;

            yield return null;
        }
        content.localScale = target;
    }

    IEnumerator AnimateScaleByWithEvent(RectTransform content, Vector2 target, AnimationCurve curve, UnityEvent OnScaleEnd)
    {
        yield return StartCoroutine(AnimateScaleBy(content, target, curve));
        OnScaleEnd.Invoke();
    }

    IEnumerator AnimateScaleBy(RectTransform content, Vector2 target, AnimationCurve curve)
    {
        if (curve.length == 0)
        {
            throw new System.Exception("Curve empty");
        }

        float startTime = curve.keys[0].time;
        float endTime = curve.keys[curve.length - 1].time;
        float timer = startTime;

        float magnitude = curve.keys[curve.length - 1].value - curve.keys[0].value;
        Vector2 scaledMagnitude = (target - content.sizeDelta) / magnitude;

        float currentValue = curve.Evaluate(timer);

        while (timer < endTime)
        {
            float nextValue = curve.Evaluate(timer += Time.deltaTime);
            float deltaValue = nextValue - currentValue;

            content.sizeDelta += scaledMagnitude * deltaValue;
            currentValue = nextValue;

            yield return null;
        }
        content.sizeDelta = target;
    }
}
