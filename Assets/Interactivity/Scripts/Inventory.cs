using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int SLOTS = 9;

    private List<IInventoryItem> mItems = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> ItemAdded;

    public void AddItem(IInventoryItem item)
    {
        if (mItems.Count < SLOTS)
        {
            mItems.Add(item);
            if (ItemAdded != null)
            {
                ItemAdded(this, new InventoryEventArgs(item));
            }
        }
    }
}