using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Splines.Interpolators;

public class Cauldron : MonoBehaviour, IPointerClickHandler
{
    public string[] ingredients;
    HotbarController hotbarcontroller;
    public void OnPointerClick(PointerEventData eventData)
    {
        int i = 0; 
        Debug.Log("CauldronClciked");
        ingredients[0] = hotbarcontroller.itemhold;
        i++;
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hotbarcontroller = GetComponent<HotbarController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }


}
