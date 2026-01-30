using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Splines.Interpolators;

public class Cauldron : MonoBehaviour, Interactable
{
    public string[] ingredients;
    public GameObject brewingpanel;

    public void closepanel()
    {
        brewingpanel.SetActive(false);
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
    }

    public bool CanInteract()
    {
        return !brewingpanel.activeSelf;
    }
}
