using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class DroppTarget : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

        if(d!=null)
        {
            d.gotToParrent = this.transform;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       // Debug.Log("Exit");
    }
}
