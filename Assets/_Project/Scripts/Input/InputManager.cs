using System;
using JonasLindinger.Singletons;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Input
{
    public class InputManager: MonoBehaviourSingleton<InputManager>
    {
        public event EventHandler OnInteractAction; 
        
        private PlayerControlls playerInputActions;

        private void Start()
        {
            playerInputActions = new PlayerControlls();
            playerInputActions.Player.Enable();
            
            playerInputActions.Player.Interact.performed += InteractOnPerformed;
        }

        private void InteractOnPerformed(InputAction.CallbackContext ctx)
        {
            OnInteractAction?.Invoke(this, EventArgs.Empty);
        }

        private void OnDestroy()
        {
            playerInputActions.Player.Interact.performed -= InteractOnPerformed;
            
            playerInputActions.Dispose();
        }
        
        public Vector2 GetNormalizedMovementVector()
        {
            Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

            inputVector = inputVector.normalized;
            
            return inputVector;
        }
    }
}