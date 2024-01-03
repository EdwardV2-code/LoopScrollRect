using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface LoopCell : IEventSystemHandler
{
    void ScrollCellIndex(int idx);
}
