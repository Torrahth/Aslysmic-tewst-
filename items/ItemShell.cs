using System.Collections;
/*using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Terraria.ModLoader;
using Defaulter.Engine;
using System
    public class ItemShell : ModItem
    {
        public IEnumerable<GameObject> loadedObjects;

        void Start()
        {
            loadedObjects = Resources.LoadAll("Items", typeof(ModItem)).Cast<ModItem>();

            foreach (var Item in loadedObjects)
            {
                //
            }
        }

        public GameObject selectItem()
        {
            return loadedObjects[Math.Random(1, loadedObjects.count)];
        }

        void Update()
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1))
            {
                Instantiate(selectItem(), transform.position);
            }
        }
    }*/
