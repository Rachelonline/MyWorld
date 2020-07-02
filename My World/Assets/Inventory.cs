using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }
    #endregion

    public delegate void onItemChanged();
    public onItemChanged onItemChangedCallback;

    public int space = 12;
    public List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log ("NOT ENOUGH ROOM");
        }
        items.Add(item);
        if (onItemChangedCallback != null)
        {
        onItemChangedCallback.Invoke();
        }
    }

    public void Remove (Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
        {
        onItemChangedCallback.Invoke();
        } 
    }
}
