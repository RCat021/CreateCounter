using System.Collections;
using UnityEngine;
using System;

public class Counter : MonoBehaviour
{
    public int CurrentCount { get; private set; } = 0;

    public event Action OnCountChanged;

    public void IncreaseCount(int count)
    {
        CurrentCount += count;
        OnCountChanged?.Invoke();
    }
}
