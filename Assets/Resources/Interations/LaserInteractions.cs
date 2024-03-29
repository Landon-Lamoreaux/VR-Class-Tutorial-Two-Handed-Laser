//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Resources/Interations/LaserInteractions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @LaserInteractions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @LaserInteractions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""LaserInteractions"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""aac88d49-846e-4894-882e-66d104adf0f1"",
            ""actions"": [
                {
                    ""name"": ""GrabLeft"",
                    ""type"": ""Value"",
                    ""id"": ""db652fde-2373-4196-bba0-18d9f9f113c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GrabRight"",
                    ""type"": ""Value"",
                    ""id"": ""997b47dd-a455-4ba5-911e-c7ea8b52666a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""869ac14f-a334-4bcc-ac3c-a7223a119aff"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Scale"",
                    ""type"": ""Value"",
                    ""id"": ""177bbf9b-c54d-4cb4-a9d1-82e345c27f45"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ColorChange"",
                    ""type"": ""Button"",
                    ""id"": ""22032663-c00e-44e0-9a77-637dbc499a6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ReleaseLeft"",
                    ""type"": ""Button"",
                    ""id"": ""469014ee-0388-4c85-a486-997829338fb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ReleaseRight"",
                    ""type"": ""Button"",
                    ""id"": ""324fd281-1570-4507-8d5c-a2acc46b5c07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""41cf0b22-ac72-4fd2-b9fd-4739751fbf60"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""f66e45c1-bb10-46a6-b27c-614d2bb62058"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""dcf6efae-96f4-4d80-a1f9-cbcc17a251b8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0d474333-4993-4c49-bfbc-80eb815ce119"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2add478d-c10b-47f7-b6d7-d87f31d34b95"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fb6937dd-6124-4107-97c9-14c6597f877f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d2a187fc-6556-44b7-a6d3-f8d39caa3a99"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10cf6930-1740-4af1-81cf-ecfbb86fb724"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf5e0c98-cec4-45bc-a3df-f7184a7d1b44"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=3)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""482e4cea-c8cc-4865-ac4d-56b74a28cabb"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=4)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a734e4f6-22d5-4e73-8ee5-ddd7e76f9f67"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""ReleaseLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0b47a3a-1980-4646-8f65-18a9d1ad0245"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""ReleaseRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c051d1c8-1842-4319-bbb4-5b1549cf34dc"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""GrabRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0de6ff9b-5232-4324-a1e7-321f2850f97b"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""GrabLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""VR"",
            ""bindingGroup"": ""VR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_GrabLeft = m_Default.FindAction("GrabLeft", throwIfNotFound: true);
        m_Default_GrabRight = m_Default.FindAction("GrabRight", throwIfNotFound: true);
        m_Default_Move = m_Default.FindAction("Move", throwIfNotFound: true);
        m_Default_Scale = m_Default.FindAction("Scale", throwIfNotFound: true);
        m_Default_ColorChange = m_Default.FindAction("ColorChange", throwIfNotFound: true);
        m_Default_ReleaseLeft = m_Default.FindAction("ReleaseLeft", throwIfNotFound: true);
        m_Default_ReleaseRight = m_Default.FindAction("ReleaseRight", throwIfNotFound: true);
    }

    public void Dispose()
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_GrabLeft;
    private readonly InputAction m_Default_GrabRight;
    private readonly InputAction m_Default_Move;
    private readonly InputAction m_Default_Scale;
    private readonly InputAction m_Default_ColorChange;
    private readonly InputAction m_Default_ReleaseLeft;
    private readonly InputAction m_Default_ReleaseRight;
    public struct DefaultActions
    {
        private @LaserInteractions m_Wrapper;
        public DefaultActions(@LaserInteractions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GrabLeft => m_Wrapper.m_Default_GrabLeft;
        public InputAction @GrabRight => m_Wrapper.m_Default_GrabRight;
        public InputAction @Move => m_Wrapper.m_Default_Move;
        public InputAction @Scale => m_Wrapper.m_Default_Scale;
        public InputAction @ColorChange => m_Wrapper.m_Default_ColorChange;
        public InputAction @ReleaseLeft => m_Wrapper.m_Default_ReleaseLeft;
        public InputAction @ReleaseRight => m_Wrapper.m_Default_ReleaseRight;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @GrabLeft.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGrabLeft;
                @GrabLeft.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGrabLeft;
                @GrabLeft.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGrabLeft;
                @GrabRight.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGrabRight;
                @GrabRight.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGrabRight;
                @GrabRight.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGrabRight;
                @Move.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Scale.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnScale;
                @Scale.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnScale;
                @Scale.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnScale;
                @ColorChange.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnColorChange;
                @ColorChange.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnColorChange;
                @ColorChange.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnColorChange;
                @ReleaseLeft.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnReleaseLeft;
                @ReleaseLeft.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnReleaseLeft;
                @ReleaseLeft.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnReleaseLeft;
                @ReleaseRight.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnReleaseRight;
                @ReleaseRight.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnReleaseRight;
                @ReleaseRight.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnReleaseRight;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GrabLeft.started += instance.OnGrabLeft;
                @GrabLeft.performed += instance.OnGrabLeft;
                @GrabLeft.canceled += instance.OnGrabLeft;
                @GrabRight.started += instance.OnGrabRight;
                @GrabRight.performed += instance.OnGrabRight;
                @GrabRight.canceled += instance.OnGrabRight;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Scale.started += instance.OnScale;
                @Scale.performed += instance.OnScale;
                @Scale.canceled += instance.OnScale;
                @ColorChange.started += instance.OnColorChange;
                @ColorChange.performed += instance.OnColorChange;
                @ColorChange.canceled += instance.OnColorChange;
                @ReleaseLeft.started += instance.OnReleaseLeft;
                @ReleaseLeft.performed += instance.OnReleaseLeft;
                @ReleaseLeft.canceled += instance.OnReleaseLeft;
                @ReleaseRight.started += instance.OnReleaseRight;
                @ReleaseRight.performed += instance.OnReleaseRight;
                @ReleaseRight.canceled += instance.OnReleaseRight;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_VRSchemeIndex = -1;
    public InputControlScheme VRScheme
    {
        get
        {
            if (m_VRSchemeIndex == -1) m_VRSchemeIndex = asset.FindControlSchemeIndex("VR");
            return asset.controlSchemes[m_VRSchemeIndex];
        }
    }
    public interface IDefaultActions
    {
        void OnGrabLeft(InputAction.CallbackContext context);
        void OnGrabRight(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnScale(InputAction.CallbackContext context);
        void OnColorChange(InputAction.CallbackContext context);
        void OnReleaseLeft(InputAction.CallbackContext context);
        void OnReleaseRight(InputAction.CallbackContext context);
    }
}
