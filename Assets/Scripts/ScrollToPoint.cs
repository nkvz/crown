using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollToPoint : MonoBehaviour
{
    public ScrollRect scrollRect;
    public Transform target;

    public void Update2()
    {
        scrollRect.content.anchoredPosition =
            scrollRect.viewport.rect.size / 2
            + (Vector2)scrollRect.transform.InverseTransformPoint(scrollRect.content.position)
            - (Vector2)scrollRect.transform.InverseTransformPoint(target.position);

    }
}
