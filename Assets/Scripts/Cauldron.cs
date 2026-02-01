using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Splines.Interpolators;

public class Cauldron : MonoBehaviour, Interactable
{
    public string[] ingredients;
    public GameObject brewingpanel;
    public MenuController menu;
    public TabController tab;

    public void closepanel()
    {
        tab.ActivateTab(0);
        brewingpanel.SetActive(false);
        menu.menuCanvas.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Interact()
    {
        brewingpanel.SetActive(true);
        menu.menuCanvas.SetActive(true);
        tab.ActivateTab(2);
    }

    public bool CanInteract()
    {
        return !brewingpanel.activeSelf;
    }
}
