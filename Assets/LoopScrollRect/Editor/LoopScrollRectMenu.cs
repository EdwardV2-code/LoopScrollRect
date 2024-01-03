using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace UnityEngine.UI
{
    public static class LoopScrollRectMenu
    {
        //regist menu item for hierarchy
        [MenuItem("GameObject/UI/Loop Vertical ScrollRect", false, 2000)]
        public static void AddLoopVerticalScrollRect()
        {
            GameObject obj = new GameObject("LoopVerticalScrollRect");
            obj.AddComponent<RectTransform>();
            obj.AddComponent<CanvasRenderer>();
            LoopVerticalScrollRect rect = obj.AddComponent<LoopVerticalScrollRect>();
            obj.AddComponent<RectMask2D>();
            obj.AddComponent<LoopScrollInitConfig>();
            obj.transform.SetParent(Selection.activeTransform, false);
            GameObject content = new GameObject("content");
            ContentSizeFitter fitter = content.AddComponent<ContentSizeFitter>();
            fitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            VerticalLayoutGroup layoutGroup = content.AddComponent<VerticalLayoutGroup>();
            layoutGroup.childAlignment = TextAnchor.MiddleCenter;
            layoutGroup.childControlHeight = true;
            layoutGroup.childControlWidth = true;
            rect.content = content.GetComponent<RectTransform>();
            content.transform.SetParent(obj.transform);
            Selection.activeGameObject = obj;
        }
        
    }
}

