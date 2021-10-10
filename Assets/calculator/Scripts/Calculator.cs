using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{

    public TextMeshProUGUI InputText;
    private float _result;
    private float _input;
    private float _input2;
    private string _operation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickNumber(int val)
    {
        Debug.Log( message: $" check val : {val}");
        InputText.text = $"{val}";
        if(_input == 0)
        {
            _input = val;
        }
        else
        {
            _input2 = val;
        }
    }

    public void ClickOperation(string val)
    {
        Debug.Log(message: $" check val : {val}");
        _operation = val;
    }

    public void ClickEqual(string val)
    {
        Debug.Log(message: $" check val : {val}");
        if(_input != 0 && _input2 != 0 && !string.IsNullOrEmpty(_operation))
        {
            switch (_operation)
            {
                case "+":
                    _result = _input + _input2;
                    break;
                case "-":
                    _result = _input - _input2;
                    break;
                case "*":
                    _result = _input * _input2;
                    break;
                case "/":
                    _result = _input / _input2;
                    break;
            }

            InputText.SetText(_result.ToString());
            ClearInput();
        }
    }

    private void ClearInput()
    {
        _input = 0;
        _input2 = 0;
    }

}
