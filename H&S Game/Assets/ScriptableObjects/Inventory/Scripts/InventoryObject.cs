using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventortySlot> Container = new List<InventortySlot>();
    public void AddItem(ItemObject _item, int _amount)
    {
        bool hasItem = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if(Container[i].item == _item)
            {

                Container[i].AddAmount(_amount);
                hasItem = true;
                break;
            }
        }
        if(!hasItem)
        {
            Container.Add(new InventortySlot(_item, _amount));
        }
    }
}

[System.Serializable]
public class InventortySlot
{
    public ItemObject item;
    public int amount;
    public InventortySlot(ItemObject _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }


}