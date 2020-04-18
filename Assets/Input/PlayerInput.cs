// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""CatchFruit"",
            ""id"": ""b307149e-ffae-4196-a361-cca3bffb4cd6"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""946e0235-5e24-41ff-aac3-d9f8b1012d09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0542a36d-03d5-4ddb-bbd6-922f9b4b398d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5a6e8096-de8c-4c5f-8765-cecbfdc89c13"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ca0f61c-e799-42b9-984b-419f76e12a3e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
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
        m_CatchFruit_MousePosition = m_CatchFruit.FindAction("MousePosition", throwIfNotFound: true);
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
    private readonly InputAction m_CatchFruit_MousePosition;
    public struct CatchFruitActions
    {
        private @PlayerInput m_Wrapper;
        public CatchFruitActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_CatchFruit_Click;
        public InputAction @MousePosition => m_Wrapper.m_CatchFruit_MousePosition;
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
                @MousePosition.started -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_CatchFruitActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_CatchFruitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public CatchFruitActions @CatchFruit => new CatchFruitActions(this);
    public interface ICatchFruitActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
