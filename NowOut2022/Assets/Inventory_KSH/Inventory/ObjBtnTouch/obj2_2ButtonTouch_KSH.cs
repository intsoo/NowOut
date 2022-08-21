using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class obj2_2ButtonTouch_KSH : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public bool obj2_2BtnTouch = false;
    public GameObject obj2;
    public GameObject button;
    public Camera CanvasCamera;

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 uiElementPosition = CanvasCamera.WorldToScreenPoint(button.transform.position);
        Vector3 NewWorldPosition = Camera.main.ScreenToWorldPoint(uiElementPosition);
        obj2.transform.position = NewWorldPosition;
        obj2_2BtnTouch = true;
        obj2.SetActive(true);
        obj2.SetActive(false);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        obj2.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        obj2.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        obj2.SetActive(false);
        Invoke("boolTouch", 0.2f);
    }
    public void boolTouch()
    {
        obj2_2BtnTouch = false;
    }
}

