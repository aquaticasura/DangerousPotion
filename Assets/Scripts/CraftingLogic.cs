using UnityEngine;

public class CraftingLogic : MonoBehaviour
{

    public Slot slot;
    public int brewingitem;
    public int brewingamount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


         if (slot.currentItem != null)
        {
            Item slotItem = slot.currentItem.GetComponent<Item>();



            if (slotItem.ID != brewingitem)
            {
                if (slotItem.quantity > 1)
                {
                    //subract one from quantity on craft
                }
                brewingitem = slotItem.ID;
                brewingamount = slotItem.quantity;
                Debug.Log(brewingitem);


            }
        }
        else
        {
            brewingitem = 0;
            return;
        }
    }
}
