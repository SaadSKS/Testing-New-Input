using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ControlCenter : MonoBehaviour
{
    public float DeadZone = 0.25f;
    public GameObject ControllerChecker;
    GameObject A;
    GameObject B;
    GameObject X;
    GameObject Y;
    GameObject L;
    GameObject R;
    GameObject LEFT;
    GameObject RIGHT;
    GameObject UP;
    GameObject DOWN;
    GameObject START;
    GameObject SELECT;
    Vector2 StickLeftMove;

    CompleteControls CC;

    private void Awake()
    {
        //Map Gameobjects of Controller Btn/stick Sprites
        A = ControllerChecker.transform.Find("ControllerA").gameObject;
        B = ControllerChecker.transform.Find("ControllerB").gameObject;
        X = ControllerChecker.transform.Find("ControllerX").gameObject;
        Y = ControllerChecker.transform.Find("ControllerY").gameObject;
        L = ControllerChecker.transform.Find("ControllerL").gameObject;
        R = ControllerChecker.transform.Find("ControllerR").gameObject;
        LEFT = ControllerChecker.transform.Find("ControllerLEFT").gameObject;
        RIGHT = ControllerChecker.transform.Find("ControllerRIGHT").gameObject;
        DOWN = ControllerChecker.transform.Find("ControllerDOWN").gameObject;
        UP = ControllerChecker.transform.Find("ControllerUP").gameObject;
        START = ControllerChecker.transform.Find("ControllerStart").gameObject;
        SELECT = ControllerChecker.transform.Find("ControllerSelect").gameObject;

        CC = new CompleteControls();
        CC.Player.A.performed += ctx => PressA();
        CC.Player.A.canceled += ctx => ReleaseA();
        CC.Player.B.performed += ctx => PressB();
        CC.Player.B.canceled += ctx => ReleaseB();
        CC.Player.X.performed += ctx => PressX();
        CC.Player.X.canceled += ctx => ReleaseX();
        CC.Player.Y.performed += ctx => PressY();
        CC.Player.Y.canceled += ctx => ReleaseY();
        CC.Player.Start.performed += ctx => PressSTART();
        CC.Player.Start.canceled += ctx => ReleaseSTART();
        CC.Player.Select.performed += ctx => PressSELECT();
        CC.Player.Select.canceled += ctx => ReleaseSELECT();
        CC.Player.L.performed += ctx => PressL();
        CC.Player.L.canceled += ctx => ReleaseL();
        CC.Player.R.performed += ctx => PressR();
        CC.Player.R.canceled += ctx => ReleaseR();
        CC.Player.StickL.performed += ctx => StickLeftMove = ctx.ReadValue<Vector2>();
        CC.Player.StickL.canceled += ctx => StickLeftMove = Vector2.zero;




    }


    void Start()
    {
        
    }



    void Update()
    {
        CheckMove();
    }

    private void OnEnable()
    {
        CC.Player.Enable();
    }

    private void OnDisable()
    {
        CC.Player.Disable();
    }

    public void PressA()
    {
        A.SetActive(true);
    }
    public void ReleaseA()
    {
        A.SetActive(false);
    }
    public void PressB()
    {
        B.SetActive(true);
    }
    public void ReleaseB()
    {
        B.SetActive(false);
    }
    public void PressX()
    {
        X.SetActive(true);
    }
    public void ReleaseX()
    {
        X.SetActive(false);
    }
    public void PressY()
    {
        Y.SetActive(true);
    }
    public void ReleaseY()
    {
        Y.SetActive(false);
    }
    public void PressSTART()
    {
        START.SetActive(true);
    }
    public void ReleaseSTART()
    {
        START.SetActive(false);
    }
    public void PressSELECT()
    {
        SELECT.SetActive(true);
    }
    public void ReleaseSELECT()
    {
        SELECT.SetActive(false);
    }
    public void PressL()
    {
        L.SetActive(true);
    }
    public void ReleaseL()
    {
        L.SetActive(false);
    }
    public void PressR()
    {
        R.SetActive(true);
    }
    public void ReleaseR()
    {
        R.SetActive(false);
    }

    void CheckMove()
    {
        if (StickLeftMove.x > DeadZone)
        {
            //right
            RIGHT.SetActive(true);
        }
        else
        {
            RIGHT.SetActive(false);
        }
        if (StickLeftMove.x < -DeadZone)
        {
            //left
            LEFT.SetActive(true);
        }
        else
        {
            LEFT.SetActive(false);
        }
        if (StickLeftMove.y > DeadZone)
        {
            //up
            UP.SetActive(true);
        }
        else
        {
            UP.SetActive(false);
        }
        if (StickLeftMove.y < -DeadZone)
        {
            //down
            DOWN.SetActive(true);
        }
        else
        {
            DOWN.SetActive(false);
        }

    }



}
