﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypes : MonoBehaviour {
	public byte redColor;
	public short temperature;
	public char letter = 'x';
    public string s = "xcvbn?";

	void Start () {
		Debug.Log(redColor);
		Debug.Log(temperature);
		Debug.Log(letter);
	}
}