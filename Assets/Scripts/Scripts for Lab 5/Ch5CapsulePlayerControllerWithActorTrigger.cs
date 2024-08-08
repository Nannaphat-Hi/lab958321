using GameDev3Library.InteractionSystem;
using Nannaphat.GameDev3.Chapter5.InteractionSystem;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Nannaphat.GameDev3.Chapter5.PlayerController
{
    public class Ch5CapsulePlayerControllerWithActorTrigger :
    Ch5CapsulePlayerControllerWithPreset 
    { 
        [SerializeField] protected ActorTriggerHandler m_ActorTriggerHandler;
        
        protected override void Update() 
        { 
            base.Update();
            
            Keyboard keyboard = Keyboard.current;
            
            if (keyboard[m_Preset.InteractionKey].wasPressedThisFrame) 
            { 
                PerformInteraction(); 
            } 
        }
        
        protected virtual void PerformInteraction() 
        { 
            var interactable = m_ActorTriggerHandler.GetInteractable();
            
            if (interactable != null) 
            { 
                interactable.Interact(gameObject); 
            } 
        } 
    }
}