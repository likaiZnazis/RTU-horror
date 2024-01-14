using UnityEngine;

public class Item : IInventoryItem
{
    public string Name => _Name; // Implementing the Name property
    public Sprite Image => _Image; // Implementing the Image property

    private string _Name; // Private field to store the name
    private Sprite _Image; // Private field to store the image

    public Item(Sprite image, string name)
    {
        _Image = image;
        _Name = name;
    }

    public void OnPickUp()
    {
        // Implement the logic for what happens when the item is picked up
        UnityEngine.Debug.Log("Item picked up: " + _Name);
    }
}
