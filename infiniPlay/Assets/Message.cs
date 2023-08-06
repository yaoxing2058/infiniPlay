using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Message : MonoBehaviour
{

    private TextMeshProUGUI textPro;

    public GameObject textField;

    private TMP_InputField inputText;

    // Start is called before the first frame update
    void Start()
    {
        
        textPro = GetComponent<TextMeshProUGUI>();

        inputText = textField.GetComponent<TMP_InputField>();
   
    }

    // Update is called once per frame
    void Update()
    {

        textPro.SetText(inputText.text);

    }
}
