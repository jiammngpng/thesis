using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPositionButton : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform;

    // Update is called once per frame
    private void Update()
    {
        var screenPoint = Camera.main.WorldToScreenPoint(targetTransform.position);
        GetComponent<RectTransform>().position = screenPoint;

        var viewportPoint = Camera.main.WorldToViewportPoint(targetTransform.position);
        
    }
}
