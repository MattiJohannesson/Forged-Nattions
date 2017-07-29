using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backgroundchooser : MonoBehaviour {
    public int Rand;
    public Sprite[] BackgroundImg;
    public Object Background;

	// Use this for initialization
	void Start () {
        Rand = Random.RandomRange(1, 8);

        this.GetComponent<Image>().sprite = BackgroundImg[Rand];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
