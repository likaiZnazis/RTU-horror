using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Inventory Inventory;

    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        Inventory.ItemRemoved += InventoryScript_RemoveItem; // Fix the event name
    }

    public void InventoryScript_ItemAdded(object sender, InventoryEventArgs eventArgs)
    {
        Transform inventoryPanel = transform.Find("Inventory");
        foreach (Transform slot in inventoryPanel)
        {
            UnityEngine.UI.Image image = slot.GetChild(0).GetChild(0).GetComponent<UnityEngine.UI.Image>(); // Fully qualify the type

            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = eventArgs.Item.Image;
                break;
            }
        }
    }

    public void InventoryScript_RemoveItem(object sender, InventoryEventArgs eventArgs)
    {
        Transform inventoryPanel = transform.Find("Inventory");

        // Assuming each slot in the inventory has an Image component
        foreach (Transform slot in inventoryPanel)
        {
            UnityEngine.UI.Image image = slot.GetChild(0).GetChild(0).GetComponent<UnityEngine.UI.Image>(); // Fully qualify the type

            // Check if the slot has the same item that was removed
            if (image.sprite == eventArgs.Item.Image)
            {
                // Clear the slot by disabling the image and resetting the sprite
                image.enabled = false;
                image.sprite = null;
                break;
            }
        }
    }
}
