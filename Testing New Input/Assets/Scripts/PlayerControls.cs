// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""05d926ef-3b41-4c39-b262-ac8f382a11e8"",
            ""actions"": [
                {
                    ""name"": ""Dpad"",
                    ""type"": ""Button"",
                    ""id"": ""5cd05e36-5117-4660-9dcf-c00614292a7c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StickL"",
                    ""type"": ""Button"",
                    ""id"": ""a3b39bc4-7b7a-460f-b21b-efaf56337853"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""c6c4055a-5a6d-4831-93bd-30759429256e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""c4af524f-4d93-4bf5-9ecd-0c343f74d855"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""917327b6-1106-4fc3-9e01-d7c20f63200e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""debe565f-4561-4f66-bf3e-843c6bcc27e3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LShoulder"",
                    ""type"": ""Button"",
                    ""id"": ""cceabfb4-6d05-42ac-960c-8a017211cc82"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LTrigger"",
                    ""type"": ""Button"",
                    ""id"": ""c6061e72-66d5-4f8b-b05b-a868e2fe4f01"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RShoulder"",
                    ""type"": ""Button"",
                    ""id"": ""da5e6d30-2211-4b06-be7e-9db490895d0a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RTrigger"",
                    ""type"": ""Button"",
                    ""id"": ""9d7057cf-6d2d-4e8f-b1b2-b38a852ccca2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""d94242af-a39a-42fa-930d-4e8cb5420616"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""f8c583ed-9209-4627-9aea-78882e996197"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6cd6efa-2e23-476a-bcfd-5c9c34437f27"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.25,max=1)"",
                    ""groups"": """",
                    ""action"": ""StickL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c325fe7-d968-4491-96b9-eb4c4b3cc1ad"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a89a9e89-96c5-4e08-9c5f-37750e403152"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bb9983e-2894-45ec-a62c-cf0b4314ac8a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""883d3cd6-edb0-485e-acd8-02c37faa1572"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ebb9ca0-b3f5-4f35-bd8c-190322c4c113"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa7e4820-fa74-4188-90a6-3b9cb452b248"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51e6a8db-06b3-4b3b-b965-af03f4cc8304"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb77457a-cd15-4318-aef2-659dd2cff903"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4caadb66-99d8-440e-ad93-dccf63214541"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""891e5384-92ba-44d1-b595-07f140b31bda"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LShoulder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91e95947-4e64-4ce9-8639-5f3e5acdaa2a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RShoulder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Dpad = m_Gameplay.GetAction("Dpad");
        m_Gameplay_StickL = m_Gameplay.GetAction("StickL");
        m_Gameplay_A = m_Gameplay.GetAction("A");
        m_Gameplay_B = m_Gameplay.GetAction("B");
        m_Gameplay_X = m_Gameplay.GetAction("X");
        m_Gameplay_Y = m_Gameplay.GetAction("Y");
        m_Gameplay_LShoulder = m_Gameplay.GetAction("LShoulder");
        m_Gameplay_LTrigger = m_Gameplay.GetAction("LTrigger");
        m_Gameplay_RShoulder = m_Gameplay.GetAction("RShoulder");
        m_Gameplay_RTrigger = m_Gameplay.GetAction("RTrigger");
        m_Gameplay_Start = m_Gameplay.GetAction("Start");
        m_Gameplay_Select = m_Gameplay.GetAction("Select");
    }

    ~PlayerControls()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Dpad;
    private readonly InputAction m_Gameplay_StickL;
    private readonly InputAction m_Gameplay_A;
    private readonly InputAction m_Gameplay_B;
    private readonly InputAction m_Gameplay_X;
    private readonly InputAction m_Gameplay_Y;
    private readonly InputAction m_Gameplay_LShoulder;
    private readonly InputAction m_Gameplay_LTrigger;
    private readonly InputAction m_Gameplay_RShoulder;
    private readonly InputAction m_Gameplay_RTrigger;
    private readonly InputAction m_Gameplay_Start;
    private readonly InputAction m_Gameplay_Select;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Dpad => m_Wrapper.m_Gameplay_Dpad;
        public InputAction @StickL => m_Wrapper.m_Gameplay_StickL;
        public InputAction @A => m_Wrapper.m_Gameplay_A;
        public InputAction @B => m_Wrapper.m_Gameplay_B;
        public InputAction @X => m_Wrapper.m_Gameplay_X;
        public InputAction @Y => m_Wrapper.m_Gameplay_Y;
        public InputAction @LShoulder => m_Wrapper.m_Gameplay_LShoulder;
        public InputAction @LTrigger => m_Wrapper.m_Gameplay_LTrigger;
        public InputAction @RShoulder => m_Wrapper.m_Gameplay_RShoulder;
        public InputAction @RTrigger => m_Wrapper.m_Gameplay_RTrigger;
        public InputAction @Start => m_Wrapper.m_Gameplay_Start;
        public InputAction @Select => m_Wrapper.m_Gameplay_Select;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Dpad.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDpad;
                Dpad.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDpad;
                Dpad.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDpad;
                StickL.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickL;
                StickL.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickL;
                StickL.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickL;
                A.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                A.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                A.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                B.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                B.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                B.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                X.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                X.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                X.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                Y.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                Y.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                Y.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                LShoulder.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLShoulder;
                LShoulder.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLShoulder;
                LShoulder.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLShoulder;
                LTrigger.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLTrigger;
                LTrigger.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLTrigger;
                LTrigger.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLTrigger;
                RShoulder.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRShoulder;
                RShoulder.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRShoulder;
                RShoulder.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRShoulder;
                RTrigger.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRTrigger;
                RTrigger.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRTrigger;
                RTrigger.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRTrigger;
                Start.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                Start.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                Start.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                Select.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                Select.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                Select.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Dpad.started += instance.OnDpad;
                Dpad.performed += instance.OnDpad;
                Dpad.canceled += instance.OnDpad;
                StickL.started += instance.OnStickL;
                StickL.performed += instance.OnStickL;
                StickL.canceled += instance.OnStickL;
                A.started += instance.OnA;
                A.performed += instance.OnA;
                A.canceled += instance.OnA;
                B.started += instance.OnB;
                B.performed += instance.OnB;
                B.canceled += instance.OnB;
                X.started += instance.OnX;
                X.performed += instance.OnX;
                X.canceled += instance.OnX;
                Y.started += instance.OnY;
                Y.performed += instance.OnY;
                Y.canceled += instance.OnY;
                LShoulder.started += instance.OnLShoulder;
                LShoulder.performed += instance.OnLShoulder;
                LShoulder.canceled += instance.OnLShoulder;
                LTrigger.started += instance.OnLTrigger;
                LTrigger.performed += instance.OnLTrigger;
                LTrigger.canceled += instance.OnLTrigger;
                RShoulder.started += instance.OnRShoulder;
                RShoulder.performed += instance.OnRShoulder;
                RShoulder.canceled += instance.OnRShoulder;
                RTrigger.started += instance.OnRTrigger;
                RTrigger.performed += instance.OnRTrigger;
                RTrigger.canceled += instance.OnRTrigger;
                Start.started += instance.OnStart;
                Start.performed += instance.OnStart;
                Start.canceled += instance.OnStart;
                Select.started += instance.OnSelect;
                Select.performed += instance.OnSelect;
                Select.canceled += instance.OnSelect;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnDpad(InputAction.CallbackContext context);
        void OnStickL(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnLShoulder(InputAction.CallbackContext context);
        void OnLTrigger(InputAction.CallbackContext context);
        void OnRShoulder(InputAction.CallbackContext context);
        void OnRTrigger(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
