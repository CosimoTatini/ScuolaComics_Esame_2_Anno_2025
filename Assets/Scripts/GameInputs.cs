using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Composites;

public class GameInputs : MonoBehaviour
{
    private MyInputSystem inputActions;

    private RaycastTarget currentTarget;

  [SerializeField] bool isMouseOverTarget = false;



    void Awake()
    {
        inputActions = new MyInputSystem(); 
    }

    void OnEnable()
    {
        inputActions.Gameplay.Enable();
        inputActions.Gameplay.SelectTurret.performed += OnSelectTurret;
    }

    private void OnDisable()
    {
        inputActions.Gameplay.SelectTurret.performed -= OnSelectTurret;
        inputActions.Gameplay.Disable();
    }

    private void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D hit = Physics2D.OverlapPoint(mousePosition);

        if (hit && hit.transform.TryGetComponent<RaycastTarget>(out var newTarget))
        {
            if (currentTarget != newTarget)
            {
                if (currentTarget != null)
                {
                    currentTarget.OnMouseExit();
                }
                newTarget.OnMouseEnter();
                currentTarget = newTarget;
            }
        }
        else if (currentTarget != null)
        {
            currentTarget.OnMouseExit();
            currentTarget = null;
        }
    }
    

    private void OnSelectTurret(InputAction.CallbackContext context)
    {
      if (isMouseOverTarget)
        {
            currentTarget?.OnMouseExit();
            currentTarget = null;
            isMouseOverTarget = false;
        }
    }
}
