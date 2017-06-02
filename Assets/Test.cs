using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;
	private int  mp = 53;
	private int power = 25;
	
	public void Attack() {
				Debug.Log( this.power + "のダメージを与えた" );
	}
	public void Magic( int takemp ) {
		if ( takemp < mp){
				this.mp -= takemp;
				Debug.Log( "魔法攻撃をした。残りMPは"+mp + "。" );
		} else {
				Debug.Log( "MPが足りないため魔法が使えない。" );
		}
	}
	
	public void Defence(int damage) {
				Debug.Log(  damage + "のダメージを与えた" );
				this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
			// 課題配列を宣言してみましょう
			int [] hoge  = {12,34,123,414,242,42};
			for ( int i = 0 ;  i  < hoge.Length ;  i++) {
					Debug.Log(hoge[i]);
			}
			for ( int i = hoge.Length - 1 ;  i  >= 0 ;  i--) {
					Debug.Log(hoge[i]);
			}
			
			// 発展改題 Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出し
			Boss lastboss = new Boss ();
			//lastboss.Attack();
			//lastboss.Defence(3);
			
			for (int usemagic = 1 ; usemagic <= 11 ; usemagic++){
				Debug.Log("Tern"+ usemagic);
				lastboss.Magic(5);
			}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
