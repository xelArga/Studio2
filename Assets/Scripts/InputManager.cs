using UnityEngine;
using System;
using UnityEngine.Events;
using Unity.VisualScripting;

public class InputManager : MonoBehaviour
{

    public UnityEvent OnSpacePressed = new UnityEvent();
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
    }
}
