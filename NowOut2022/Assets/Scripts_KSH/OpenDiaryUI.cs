using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

namespace EasyUI.Dialogs
{
    public class OpenDiaryUI : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] GameObject canvas;
        [SerializeField] GameObject openButtonCanvas;

        public void OnPointerDown(PointerEventData eventData)
        {
            canvas.SetActive(true);
            openButtonCanvas.SetActive(false);
        }

        void Awake()
        {
            if (DataController.Instance.gameData.Ep1_Clear == 2)
            {
                canvas.SetActive(true);
                openButtonCanvas.SetActive(false);
            }

        }
    }
}

