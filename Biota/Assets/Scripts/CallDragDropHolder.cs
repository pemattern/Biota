using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CallDragDropHolder : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Canvas canvas;

    public GameObject dragDropHolder;
    private RectTransform rectTransform;

    void Awake()
    {
        rectTransform = dragDropHolder.GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = eventData.delta / canvas.scaleFactor;
    }


}
