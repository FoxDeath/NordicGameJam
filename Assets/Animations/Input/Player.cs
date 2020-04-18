// GENERATED AUTOMATICALLY FROM 'Assets/Animations/Input/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""CatchFruit"",
            ""id"": ""24e588d1-f2ff-4976-8530-e49b897a7ae8"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""edcd1adb-9225-4e45-9b62-2d24dcefdbc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePossition"",
                    ""type"": ""Value"",
                    ""id"": ""add79f62-73df-4cc1-9f7a-9d25aee81651"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2c1ed903-a881-4519-9dd1-1c1fcf1dc8db"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a468017b-bb17-45a8-b8dc-6d8a1a1613cf"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePossition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CrossRoad"",
            ""id"": ""bd4ee27e-3e2d-434a-830b-d7d14746a4fc"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""ae704f53-345c-443d-b9d3-e94ac7e0e2ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""99c6ea21-1e90-4c69-bf39-6ccaf6041727"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""6b6ee4a8-9d06-4552-b00c-ecfce7721f04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""100314c0-85db-4d51-8d82-087524dae4d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9796b0e7-abca-4836-a2e3-a96a70946a36"",
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
                    ""id"": ""c05e82a2-e796-437e-be07-dbce40d4287f"",
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
                    ""id"": ""bc187145-7235-4afe-8748-d75944b49f5e"",
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
                    ""id"": ""8076353f-6d30-407a-bf63-c80ef8a01e52"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4713f9d-4b46-41d5-8c77-61c1522239d1"",
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
                    ""id"": ""7df1833c-ba91-4b7d-99ae-562c3a0c3609"",
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
                    ""id"": ""543dde07-0ded-4b09-b336-6573fb8b79cd"",
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
                    ""id"": ""37b37c78-36ea-4b6d-a57f-f949d58ce856"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CatchFruit
        m_CatchFruit = asset.FindActionMap("CatchFruit", throwIfNotFound: true);
        m_CatchFruit_Click = m_CatchFruit.FindAction("Click", throwIfNotFound: true);
        m_CatchFruit_MousePossition = m_CatchFruit.FindAction("MousePossition", throwIfNotFound: true);
        // CrossRoad
        m_CrossRoad = asset.FindActionMap("CrossRoad", throwIfNotFound: true);
        m_CrossRoad_Left = m_CrossRoad.FindAction("Left", throwIfNotFound: true);
        m_CrossRoad_Right = m_CrossRoad.FindAction("Right", throwIfNotFound: true);
        m_CrossRoad_Up = m_CrossRoad.FindAction("Up", throwIfNotFound: true);
        m_CrossRoad_Down = m_CrossRoad.FindAction("Down", throwIfNotFound: true);
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

    // CatchFruit
    private readonly InputActionMap m_CatchFruit;
    private ICatchFruitActions m_CatchFruitActionsCallbackInterface;
    private readonly InputAction m_CatchFruit_Click;
    private readonly InputAction m_CatchFruit_MousePossition;
    public struct CatchFruitActions
    {
        private @Player m_Wrapper;
        public CatchFruitActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_CatchFruit_Click;
        public InputAction @MousePossition => m_Wrapper.m_CatchFruit_MousePossition;
        public InputActionMap Get() { return m_Wrapper.m_CatchFruit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CatchFruitActions set) { return set.Get(); }
        public void SetCallbacks(ICatchFruitActions instance)
        {
            if (m_Wrapper.m_CatchFruitActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnClick;
                @MousePossition.started -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnMousePossition;
                @MousePossition.performed -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnMousePossition;
                @MousePossition.canceled -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnMousePossition;
            }
            m_Wrapper.m_CatchFruitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @MousePossition.started += instance.OnMousePossition;
                @MousePossition.performed += instance.OnMousePossition;
                @MousePossition.canceled += instance.OnMousePossition;
            }
        }
    }
    public CatchFruitActions @CatchFruit => new CatchFruitActions(this);

    // CrossRoad
    private readonly InputActionMap m_CrossRoad;
    private ICrossRoadActions m_CrossRoadActionsCallbackInterface;
    private readonly InputAction m_CrossRoad_Left;
    private readonly InputAction m_CrossRoad_Right;
    private readonly InputAction m_CrossRoad_Up;
    private readonly InputAction m_CrossRoad_Down;
    public struct CrossRoadActions
    {
        private @Player m_Wrapper;
        public CrossRoadActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_CrossRoad_Left;
        public InputAction @Right => m_Wrapper.m_CrossRoad_Right;
        public InputAction @Up => m_Wrapper.m_CrossRoad_Up;
        public InputAction @Down => m_Wrapper.m_CrossRoad_Down;
        public InputActionMap Get() { return m_Wrapper.m_CrossRoad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CrossRoadActions set) { return set.Get(); }
        public void SetCallbacks(ICrossRoadActions instance)
        {
            if (m_Wrapper.m_CrossRoadActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnRight;
                @Up.started -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_CrossRoadActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_CrossRoadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
            }
        }
    }
    public CrossRoadActions @CrossRoad => new CrossRoadActions(this);
    public interface ICatchFruitActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnMousePossition(InputAction.CallbackContext context);
    }
    public interface ICrossRoadActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
}
