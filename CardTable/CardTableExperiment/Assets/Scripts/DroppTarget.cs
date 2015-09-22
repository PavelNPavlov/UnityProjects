using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class DroppTarget : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public int type;

    public void OnDrop(PointerEventData eventData)
    {
       // Debug.Log("On Drop");

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        var targetType = eventData.pointerDrag.GetComponent<Draggable>().type;

        if(d!=null &&(this.type==0 || this.type==targetType) )
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
