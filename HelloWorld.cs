using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehavior {

    private TextMeshProUGUI textMeshPro;

    void Start() {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = "Hello, World";
    }

    void Update() {

    }
}
