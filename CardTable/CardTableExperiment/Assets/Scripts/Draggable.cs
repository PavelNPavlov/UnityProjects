using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform gotToParrent=null;
    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = this.GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        gotToParrent = this.transform.parent;
        this.transform.SetParent(gotToParrent.parent);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(gotToParrent);
        canvasGroup.blocksRaycasts = true;

    }
}
