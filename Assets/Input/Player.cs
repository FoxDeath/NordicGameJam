// GENERATED AUTOMATICALLY FROM 'Assets/Input/Player.inputactions'

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
                    ""id"": ""d149f235-9c90-4fec-b1f8-0127dff24bb9"",
                    ""path"": ""<Mouse>/position/x"",
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
<<<<<<< master
            ""name"": ""CrossRoad"",
            ""id"": ""bd4ee27e-3e2d-434a-830b-d7d14746a4fc"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""ae704f53-345c-443d-b9d3-e94ac7e0e2ad"",
=======
            ""name"": ""Pacman"",
            ""id"": ""c0c71ec7-78d9-4f08-86d7-c6e7930866f4"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""9485f19d-327f-4bed-bd4b-4fcec29002af"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
<<<<<<< master
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""99c6ea21-1e90-4c69-bf39-6ccaf6041727"",
=======
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""aee134c9-a313-4fd3-88d2-6cf4d91a95cb"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
<<<<<<< master
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""6b6ee4a8-9d06-4552-b00c-ecfce7721f04"",
=======
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""861a1751-5fb1-4752-a245-4e1ac9b37102"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
<<<<<<< master
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""100314c0-85db-4d51-8d82-087524dae4d3"",
=======
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""5420a637-b0df-46d6-b4e2-25c06e869d61"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""9796b0e7-abca-4836-a2e3-a96a70946a36"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
=======
                    ""id"": ""a805c580-b9c0-4736-a5d5-38a8878b7fc4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""c05e82a2-e796-437e-be07-dbce40d4287f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
=======
                    ""id"": ""8c360b83-04be-4b04-8332-95d353564827"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""bc187145-7235-4afe-8748-d75944b49f5e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
=======
                    ""id"": ""81980351-7a11-4b68-8261-8c38ced0f2ff"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""8076353f-6d30-407a-bf63-c80ef8a01e52"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
=======
                    ""id"": ""c4a177e0-568e-4875-b347-a4b57caa11b6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""d4713f9d-4b46-41d5-8c77-61c1522239d1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
=======
                    ""id"": ""4e3cd34d-2c88-4d3a-823f-026368a88d7e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""7df1833c-ba91-4b7d-99ae-562c3a0c3609"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
=======
                    ""id"": ""f5471de4-ce01-4184-9c86-948e57618467"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""543dde07-0ded-4b09-b336-6573fb8b79cd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
=======
                    ""id"": ""0d6c2fde-8b52-4324-b79e-3921e244ab5d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< master
                    ""id"": ""37b37c78-36ea-4b6d-a57f-f949d58ce856"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
=======
                    ""id"": ""56f6272e-b43e-4837-be01-c249486e2c91"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
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
<<<<<<< master
        // CrossRoad
        m_CrossRoad = asset.FindActionMap("CrossRoad", throwIfNotFound: true);
        m_CrossRoad_Left = m_CrossRoad.FindAction("Left", throwIfNotFound: true);
        m_CrossRoad_Right = m_CrossRoad.FindAction("Right", throwIfNotFound: true);
        m_CrossRoad_Up = m_CrossRoad.FindAction("Up", throwIfNotFound: true);
        m_CrossRoad_Down = m_CrossRoad.FindAction("Down", throwIfNotFound: true);
=======
        // Pacman
        m_Pacman = asset.FindActionMap("Pacman", throwIfNotFound: true);
        m_Pacman_Up = m_Pacman.FindAction("Up", throwIfNotFound: true);
        m_Pacman_Down = m_Pacman.FindAction("Down", throwIfNotFound: true);
        m_Pacman_Left = m_Pacman.FindAction("Left", throwIfNotFound: true);
        m_Pacman_Right = m_Pacman.FindAction("Right", throwIfNotFound: true);
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
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

<<<<<<< master
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
=======
    // Pacman
    private readonly InputActionMap m_Pacman;
    private IPacmanActions m_PacmanActionsCallbackInterface;
    private readonly InputAction m_Pacman_Up;
    private readonly InputAction m_Pacman_Down;
    private readonly InputAction m_Pacman_Left;
    private readonly InputAction m_Pacman_Right;
    public struct PacmanActions
    {
        private @Player m_Wrapper;
        public PacmanActions(@Player wrapper) { m_Wrapper = wrapper; }
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
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
<<<<<<< master
            }
        }
    }
    public CrossRoadActions @CrossRoad => new CrossRoadActions(this);
=======
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
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
    public interface ICatchFruitActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnMousePossition(InputAction.CallbackContext context);
    }
<<<<<<< master
    public interface ICrossRoadActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
=======
    public interface IPacmanActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
>>>>>>> Added Point system, movement doesnt work as intended :^( but it can move
    }
}
