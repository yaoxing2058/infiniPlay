using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject button;

    public bool randomLoop;

    private GameObject _object;

    // Start is called before the first frame update
    void Start()
    {

        _object = this.gameObject;

        randomLoop = false;

    }

    public void RandomColor() {

        Color randomColor = Random.ColorHSV();

        Material currentMaterial = _object.GetComponent<Renderer>().material;

        currentMaterial.SetColor("_Color", randomColor);

    }

    public void LoopRandomColor() {

        randomLoop = !randomLoop;

    }

    void Update() {

        if(randomLoop) {

            button.SetActive(false);

            RandomColor();

        }

        else
        {

            button.SetActive(true);

        }

    }

}
