using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //配列を初期化する
        int[] array = { 2, 4, 6, 8, 10 };
        for (int i = 0; i < array.Length; i++ )
        {
            Debug.Log(array[i]);

        }
        for(int k = array.Length - 1; k >= 0; k--)
        {
            Debug.Log(array[k]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
