using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nannaphat.GameDev3.Chapter3
{
    public class CollisionHandler : MonoBehaviour 
    {
        [SerializeField] protected List<GameObject> m_TriggeredGameObjects = new
        (); 
        [SerializeField] protected List<GameObject> m_CollidedGameObjects = new
        ();
    
        private void OnTriggerEnter(Collider other) 
        { 
            m_TriggeredGameObjects.Add(other.gameObject); 
        }
    
        private void OnTriggerStay(Collider other) 
        {
        
        }
        private void OnTriggerExit(Collider other)
        {
        m_TriggeredGameObjects.Remove(other.gameObject);
        }
    
        private void OnCollisionEnter(Collision other)
        {
            m_CollidedGameObjects.Add(other.gameObject);
        }
    
        private void OnCollisionStay(Collision other) 
        {
        
        }
    
        private void OnCollisionExit(Collision other) 
        { 
            m_CollidedGameObjects.Remove(other.gameObject);
        }
    }
}
