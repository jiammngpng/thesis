using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowON : MonoBehaviour
{
    public GameObject square;

    public void whenButtonClicked()
    {
        if(square.activeInHierarchy == true){
            square.SetActive(false);
        }
        else{
            square.SetActive(true);
        }
    }
}
