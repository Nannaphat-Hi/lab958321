using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Nannaphat.GameDev3.Chapter1;
using UnityEngine;

namespace Nannaphat.GameDev3.Chapter4
{ 
    public class PlayerTriggerWithITC : MonoBehaviour
    { 
        private void OnTriggerEnter(Collider other) 
        { 
            //Get components from item object
            //Get the ItemTypeComponent component from the triggered object
            ItemTypeComponent itc = other.GetComponent <ItemTypeComponent>();
            
            //Get components from the player
            //Inventory
            var inventory = GetComponent <Inventory >();
            
            //SimpleHealthPointComponent
            var simpleHP = GetComponent <SimpleHealthPointComponent>();
            
            if (itc !=null) 
            { 
                switch (itc.Type) 
                { 
                    case ItemType.COIN: 
                        inventory.AddItem("COIN",1); 
                        break; 
                    case ItemType.BIGCOIN: 
                        inventory.AddItem("BIGCOIN",1);
                        break;
                    case ItemType.POWERUP: 
                        if(simpleHP != null) 
                            simpleHP.HealthPoint = simpleHP.HealthPoint + 10; 
                        break; 
                    case ItemType.POWERDOWN: 
                        if(simpleHP != null)
                            simpleHP.HealthPoint = simpleHP.HealthPoint - 10; 
                        break; 
                    case ItemType.LITTLECOIN:
                        inventory.AddItem("LITTLECOIN",1); 
                        break;
                    case ItemType.VERTICALLYLONGCOIN:
                        inventory.AddItem("VERTICALLYLONGCOIN",1); 
                        break; 
                        
                } 
            }
            
            Destroy(other.gameObject ,0); 
        } 
    } 
}