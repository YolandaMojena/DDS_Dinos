using UnityEngine;
//using UnityEngine.UI;
using System.Collections;

public class Wave : MonoBehaviour {

    const float RANGE = 0.35f;
    const float MIN_SPEED = 0.35f;
    float speed = 0;

    const float AMPLITUDE = 4.0f;
    const float FREQ = 1.0f;
    public float vdisp = 0;
    RectTransform rect;
    float yOffset = 0;

	// Use this for initialization
	void Start () {
        speed = MIN_SPEED + Random.value * RANGE;
        if (Random.value > 0.5f)
            speed = -speed;

        rect = GetComponent<RectTransform>();

        yOffset = rect.anchoredPosition.y;
        vdisp = yOffset/100.0f;
        //vdisp = Random.value * Mathf.PI;
	}
	
	void FixedUpdate () {
        //transform.position += new Vector3(speed,0,0);
        rect.anchoredPosition += new Vector2(speed, 0);
        rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, yOffset + AMPLITUDE * Mathf.Sin(vdisp + Time.time * FREQ));

        if (rect.anchoredPosition.x <= -rect.sizeDelta.x / 2.0f)
            rect.anchoredPosition = new Vector2(rect.sizeDelta.x / 2.0f, rect.anchoredPosition.y);
        else if (rect.anchoredPosition.x >= rect.sizeDelta.x / 2.0f)
            rect.anchoredPosition = new Vector2(-rect.sizeDelta.x / 2.0f, rect.anchoredPosition.y);
    }
}
