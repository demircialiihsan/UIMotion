using UnityEngine;
using UnityEngine.Events;

public class MenuSlide : MonoBehaviour
{
    public RectTransform[] tabs;
    public AnimationCurve curve;
    public UnityEvent OnSlideEnd;

    private int currentTabNumber = 0;
    private int slideCount = 0;

    public void SlideToTab(int tabNumToSlide)
    {
        if (slideCount == 0)
        {
            if (tabNumToSlide > currentTabNumber)
            {
                slideCount += 2;

                UIMotionSlide.SlideLeft(tabs[currentTabNumber], curve, OnSlideEnd);
                UIMotionSlide.SlideLeft(tabs[tabNumToSlide], curve, OnSlideEnd);

                currentTabNumber = tabNumToSlide;
            }
            else if (currentTabNumber > tabNumToSlide)
            {
                slideCount += 2;

                UIMotionSlide.SlideRight(tabs[currentTabNumber], curve, OnSlideEnd);
                UIMotionSlide.SlideRight(tabs[tabNumToSlide], curve, OnSlideEnd);

                currentTabNumber = tabNumToSlide;
            }
        }
    }

    public void SlideEnd()
    {
        if (--slideCount == 0)
        {
            RearrangeTabs();
        }
    }

    void RearrangeTabs()
    {
        for (int i = 1; i < currentTabNumber; i++)
        {
            tabs[i].anchoredPosition = tabs[0].anchoredPosition;
        }
        for (int i = tabs.Length - 1; i > currentTabNumber; i--)
        {
            tabs[i].anchoredPosition = tabs[tabs.Length - 1].anchoredPosition;
        }
    }
}
