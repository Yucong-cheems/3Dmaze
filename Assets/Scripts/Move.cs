using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public Transform bolltransForm;
    private Vector3 offset;
    public bool cursorInputForLook = true;
    public Vector2 look;
    public void LookInput(Vector2 newLookDirection)
    {
        look = newLookDirection;
    }
    void Start()
    {
        offset = transform.position - bolltransForm.position;
    }
    void Update()
    {
        transform.position = offset + bolltransForm.position;
    }
    public void OnLook(InputValue value)
    {
        if (cursorInputForLook)

        {
            if (Input.GetMouseButton(0))
            {
                LookInput(value.Get<Vector2>() * 4);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                LookInput(value.Get<Vector2>() * 0);
            }
        }
    }
}
