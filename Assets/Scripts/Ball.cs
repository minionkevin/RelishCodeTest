using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Text numText;
    public void setID(int value)
    {
        numText.text = value.ToString();
    }
}
