using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;　　//mp

    //魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りＭＰは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }
}

public class hattennkadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();

        //魔法攻撃用の関数を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            boss.Magic();
        }
        //魔法攻撃用の関数をもう一度呼び出す
        boss.Magic();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
