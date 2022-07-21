using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace EasyUI.Dialogs
{
    public class OpenDiaryUI : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] GameObject canvas;

        public void OnPointerDown(PointerEventData eventData)
        {
            canvas.SetActive(true);
        }
    }
}

