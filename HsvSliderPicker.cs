﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class HsvSliderPicker : MonoBehaviour, IDragHandler, IPointerDownHandler
{

    public HSVPicker picker;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlacePointer(PointerEventData eventData)
    {

        var pos = new Vector2(eventData.position.x - picker.hsvSlider.rectTransform.position.x, picker.hsvSlider.rectTransform.position.y - eventData.position.y);

        pos.y /= picker.hsvSlider.rectTransform.rect.height;
        pos.y = Mathf.Clamp(pos.y, 0, 1f);

        picker.MovePointer(pos.y);
    }


    public void OnDrag(PointerEventData eventData)
    {
        PlacePointer(eventData);

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        PlacePointer(eventData);
    }
}