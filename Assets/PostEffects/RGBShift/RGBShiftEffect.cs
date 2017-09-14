﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBShiftEffect : MonoBehaviour {


	public bool on = false;

	[Range(0f, 0.1f)]
	public float amount = 0.005f;

	public Material material;



	void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		if(on)
		{
			Graphics.Blit(src, dest, material);
		}
		else
		{
			Graphics.Blit(src, dest);
		}
	}


	void Update()
	{
		if(on)
		{
			material.SetFloat("_Amount", amount);
		}
	}
}
