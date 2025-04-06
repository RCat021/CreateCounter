using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterToogle : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private int _step = 1;
    [SerializeField] private float _timerStep = 0.5f;

    private bool _isCounterActive = false;

    public void ToggleCounter()
    {
        _isCounterActive = !_isCounterActive;

        if (_isCounterActive)
            StartCoroutine(UpdateCounterRoutine());
        else
            StopCoroutine(UpdateCounterRoutine());
    }

    private IEnumerator UpdateCounterRoutine()
    {
        while (_isCounterActive)
        {
            _counter.IncreaseCount(_step);
            yield return new WaitForSeconds(_timerStep);
        }
    }
}
