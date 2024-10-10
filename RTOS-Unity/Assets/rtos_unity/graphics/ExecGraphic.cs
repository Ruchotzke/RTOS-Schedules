using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace rtos_unity.graphics{
/// <summary>
/// A scheduled task graphic.
/// </summary>
public class ExecGraphic : MonoBehaviour
{
    public SpriteRenderer Body;
    public TextMeshPro Label;

    /// <summary>
    /// Place this graphic at the given time period.
    /// </summary>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    public void PlaceGraphic(float startTime, float endTime)
    {
        /* Start position */
        transform.position = new Vector2(startTime, 0f);
        
        /* Length and adjustment of body */
        float delta = endTime - startTime;
        Body.size = new Vector2(delta, Body.size.y);
        Body.transform.position = new Vector3(delta / 2, 0.31f);
    }
}
}

