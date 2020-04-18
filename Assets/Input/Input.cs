// GENERATED AUTOMATICALLY FROM 'Assets/Input/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Pacman"",
            ""id"": ""16180a55-d612-4b82-b3d0-ec3564957ae9"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""a6affa8f-81db-467c-b88a-bde3e0040d9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""e78be9e2-89aa-4972-94ba-a84daead6149"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""163e2a1f-7998-4253-b07d-834cf505d876"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""2c70e285-87f2-406e-bf7d-5a79fdceef69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""03c68f7f-19bd-4b4c-ac96-4b33baccaadd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5121c97-598b-428f-825e-579021d960e6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48ef3d1f-7539-4a0f-b4c4-8cbbbcbb5ae1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebde3dfd-c837-4a81-8f07-1d73bbf34846"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11c05159-c656-4872-82cb-762eda74fe86"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b82aaf6b-6a37-47c3-b28a-7f9e6d3778a0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85a024af-237b-4dbb-8b1f-3927a5619303"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea9888e4-484e-4460-882d-1dcd32ed4925"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Pacman
        m_Pacman = asset.FindActionMap("Pacman", throwIfNotFound: true);
        m_Pacman_Up = m_Pacman.FindAction("Up", throwIfNotFound: true);
        m_Pacman_Down = m_Pacman.FindAction("Down", throwIfNotFound: true);
        m_Pacman_Left = m_Pacman.FindAction("Left", throwIfNotFound: true);
        m_Pacman_Right = m_Pacman.FindAction("Right", throwIfNotFound: true);
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

    // Pacman
    private readonly InputActionMap m_Pacman;
    private IPacmanActions m_PacmanActionsCallbackInterface;
    private readonly InputAction m_Pacman_Up;
    private readonly InputAction m_Pacman_Down;
    private readonly InputAction m_Pacman_Left;
    private readonly InputAction m_Pacman_Right;
    public struct PacmanActions
    {
        private @Input m_Wrapper;
        public PacmanActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Pacman_Up;
        public InputAction @Down => m_Wrapper.m_Pacman_Down;
        public InputAction @Left => m_Wrapper.m_Pacman_Left;
        public InputAction @Right => m_Wrapper.m_Pacman_Right;
        public InputActionMap Get() { return m_Wrapper.m_Pacman; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PacmanActions set) { return set.Get(); }
        public void SetCallbacks(IPacmanActions instance)
        {
            if (m_Wrapper.m_PacmanActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_PacmanActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PacmanActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PacmanActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_PacmanActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_PacmanActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_PacmanActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_PacmanActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PacmanActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PacmanActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PacmanActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PacmanActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PacmanActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_PacmanActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public PacmanActions @Pacman => new PacmanActions(this);
    public interface IPacmanActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
