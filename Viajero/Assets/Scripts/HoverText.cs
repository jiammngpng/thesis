using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverText : MonoBehaviour
{
    public GameObject logotText;
    // Start is called before the first frame update
    public void Start()
    {
        logotText.SetActive(false);
    }

    public void OnMouseOver()
    {
        logotText.SetActive(true);
    }

    public void OnMouseExit()
    {
        logotText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
