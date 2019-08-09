using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputControlCenter : MonoBehaviour
{
    public GameObject PlayerCube;
    Transform pTransform;
    ControlActions controls;

    Vector2 movement;
    Vector2 movement1;
    Vector2 movement2;


    private void Awake()
    {
        pTransform = PlayerCube.GetComponent<Transform>();
        controls = new ControlActions();

        controls.Player.Move.performed += ctx => movement = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => movement = Vector2.zero;
        
        controls.Player.Move1.performed += ctx => movement1 = ctx.ReadValue<Vector2>();
        controls.Player.Move1.canceled += ctx => movement1 = Vector2.zero;

        controls.Player.Move2.performed += ctx => movement2 = ctx.ReadValue<Vector2>();
        controls.Player.Move2.canceled += ctx => movement2 = Vector2.zero;
        
    }

    private void Update()
    {
        Vector2 m = new Vector2(movement.x, movement.y) * Time.deltaTime;
        Vector2 m1 = new Vector2(movement1.x, movement1.y) * Time.deltaTime;
        Vector2 m2 = new Vector2(movement2.x, movement2.y) * Time.deltaTime;
        pTransform.transform.Translate(m, Space.World);
        pTransform.transform.Translate(m1, Space.World);
        pTransform.transform.Translate(m2, Space.World);

    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

}
