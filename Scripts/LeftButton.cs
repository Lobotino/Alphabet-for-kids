using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour, IPointerUpHandler
{
    public CharacterController CharacterController;

    public void OnPointerUp(PointerEventData eventData)
    {
        CharacterController.OnLeftClick();
    }
}
