using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class HotbarController : MonoBehaviour
{

    public GameObject hotbarPanel;
    public GameObject slotPrefab;
    public int slotCount = 5;
    public string itemhold;


    private string replace = "(Clone)";



    private Key[] hotbarKeys;
    private void Start()
    {

    }
    private void Awake()
    {

        hotbarKeys = new Key[slotCount];
        for (int i = 0; i < slotCount; i++)
        {
            hotbarKeys[i] = i < 5 ? (Key)((int)Key.Digit1 + i) : Key.Digit0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < slotCount; i++)
        {
            if (Keyboard.current[hotbarKeys[i]].wasPressedThisFrame)
            {
                UseItemInSlot(i);
            }
        }
    }

    void UseItemInSlot(int index)
    {
        Slot slot = hotbarPanel.transform.GetChild(index).GetComponent<Slot>();
        if (slot.currentItem != null)
        {
            Item item = slot.currentItem.GetComponent<Item>();
            item.UseItem();
            if (slot.currentItem != null)
            {
                itemhold = item.name;
                string result = itemhold.Replace(replace, "");
                Debug.Log(result);
            }
    


        }
    }

}
