using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LoopVerticalScrollRect))]
public class Test : MonoBehaviour
{
    public LoopVerticalScrollRect rect;
    public float upBorder;
    public float downBorder;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<LoopVerticalScrollRect>();
        upBorder = rect.transform.position.y + rect.GetComponent<RectTransform>().sizeDelta.y / 2 * rect.transform.localScale.y;
        downBorder = rect.transform.position.y - rect.GetComponent<RectTransform>().sizeDelta.y / 2 * rect.transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"upboard = {rect.transform.position.y + rect.GetComponent<RectTransform>().sizeDelta.y / 2 * rect.transform.localScale.y}");
        Debug.Log($"downBoard = {rect.transform.position.y - rect.GetComponent<RectTransform>().sizeDelta.y / 2 * rect.transform.localScale.y}");
        Debug.Log($"firstItem = {rect.GetFirstItem(out float offset)}");
    }
}
