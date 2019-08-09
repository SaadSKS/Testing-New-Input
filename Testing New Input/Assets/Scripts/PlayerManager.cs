using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
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

    //intermediate controller vars
    bool LBtn;
    bool RBtn;
    bool LTriggerBtn;
    bool RTriggerBtn;
    Vector2 DpadMove;
    Vector2 StickLeftMove;




    PlayerControls controls;

    private void Awake()
    {
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

        controls = new PlayerControls();

        controls.Gameplay.A.performed += ctx => PressA();
        controls.Gameplay.A.canceled += ctx => ReleaseA();
        controls.Gameplay.B.performed += ctx => PressB();
        controls.Gameplay.B.canceled += ctx => ReleaseB();
        controls.Gameplay.X.performed += ctx => PressX();
        controls.Gameplay.X.canceled += ctx => ReleaseX();
        controls.Gameplay.Y.performed += ctx => PressY();
        controls.Gameplay.Y.canceled += ctx => ReleaseY();
        controls.Gameplay.Start.performed += ctx => PressSTART();
        controls.Gameplay.Start.canceled += ctx => ReleaseSTART();
        controls.Gameplay.Select.performed += ctx => PressSELECT();
        controls.Gameplay.Select.canceled += ctx => ReleaseSELECT();
        
        //combine L shoulder and L Trigger actions to mimick their effect (same for R)
        controls.Gameplay.LTrigger.performed += ctx => LTriggerBtn=true;
        controls.Gameplay.LTrigger.canceled += ctx => LTriggerBtn = false;
        controls.Gameplay.RTrigger.performed += ctx => RTriggerBtn = true;
        controls.Gameplay.RTrigger.canceled += ctx => RTriggerBtn = false;
        controls.Gameplay.LShoulder.performed += ctx => LBtn = true;
        controls.Gameplay.LShoulder.canceled += ctx => LBtn = false;
        controls.Gameplay.RShoulder.performed += ctx => RBtn = true;
        controls.Gameplay.RShoulder.canceled += ctx => RBtn = false;

        //Combine LeftStick and Dpad actions
        controls.Gameplay.Dpad.performed += ctx => DpadMove = ctx.ReadValue<Vector2>();
        controls.Gameplay.Dpad.canceled += ctx => DpadMove = Vector2.zero;
        controls.Gameplay.StickL.performed += ctx => StickLeftMove = ctx.ReadValue<Vector2>();
        controls.Gameplay.StickL.canceled += ctx => StickLeftMove = Vector2.zero;


    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
        
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();

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

    void CheckL()
    {
        if (!LTriggerBtn && !LBtn)
        {
            L.SetActive(false);
        }
        else
        {
            L.SetActive(true);
        }
        
    }
    void CheckR()
    {
        if (!RTriggerBtn && !RBtn)
        {
            R.SetActive(false);
        }
        else
        {
            R.SetActive(true);
        }

    }
    void CheckMove()
    {
        if ((DpadMove.x > 0) || (StickLeftMove.x > DeadZone))
        {
            //right
            RIGHT.SetActive(true);
        }
        else
        {
            RIGHT.SetActive(false);
        }
        if ((DpadMove.x < 0) || (StickLeftMove.x < -DeadZone))
        {
            //left
            LEFT.SetActive(true);
        }
        else
        {
            LEFT.SetActive(false);
        }
        if ((DpadMove.y > 0) || (StickLeftMove.y > DeadZone))
        {
            //up
            UP.SetActive(true);
        }
        else
        {
            UP.SetActive(false);
        }
        if ((DpadMove.y < 0) || (StickLeftMove.y < -DeadZone))
        {
            //down
            DOWN.SetActive(true);
        }
        else
        {
            DOWN.SetActive(false);
        }

    }


    private void Update()
    {
        CheckL();
        CheckR();
        CheckMove();
    }


}
