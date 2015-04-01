﻿using UnityEngine;
using System.Collections;

public class UICoinViewer : MonoBehaviour {
	public GameObject coin;
	public GameObject coin_01;
	public GameObject coin_02;
	public GameObject coin_03;
	public GameObject coin_04;
	public GameObject coin_05;

	public void CoinViewerChange(int i){
		if (i == 1)
			coin = coin_01;
		if (i == 2)
			coin = coin_02;
		if (i == 3)
			coin = coin_03;
		if (i == 4)
			coin = coin_04;
		if (i == 5)
			coin = coin_05;

		GameObject Child = Instantiate(coin,this.transform.position,Quaternion.Euler(0,0,0)) as GameObject;
		Rigidbody tmp = Child.GetComponent<Rigidbody>();
		Child.transform.parent = this.transform;
		Destroy(tmp);
		Child.transform.localScale -= new Vector3(0.15f,0.15f,0.15f);
	}

	public void CoinViewerDelete(int i){
		print("Coin_0" + i.ToString());
		GameObject tmpParentCoin = transform.FindChild("Coin_0" + i.ToString() + "(Clone)").gameObject;
		Destroy(tmpParentCoin);
	}
}