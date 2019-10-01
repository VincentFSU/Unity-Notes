using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andrea
{
    public class ItemKey : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            if(Inventory.singleton.hasKeyCrystal)
            {
                Destroy(gameObject);
            }

        }

        void OnMouseDown()
        {
            Inventory.singleton.hasKeyCrystal = true;
            print("got em");
            Destroy(gameObject);
        }
    }
}