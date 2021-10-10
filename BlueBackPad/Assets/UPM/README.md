# BlueBack.Pad
パッド操作
* パッドのボタン取得
* FixedUpdateでのダウン、アップ、連射の取得

## ライセンス
MIT License
* https://github.com/bluebackblue/UpmPad/blob/main/LICENSE

## 依存 / 使用ライセンス等
### ランタイム
### エディター
* https://github.com/bluebackblue/UpmPad
### サンプル
* https://github.com/bluebackblue/UpmPad
* https://docs.unity3d.com/ja/2019.4/Manual/com.unity.inputsystem.html

## 動作確認
Unity 2021.1.11f1

## UPM
### 最新
* https://github.com/bluebackblue/UpmPad.git?path=BlueBackPad/Assets/UPM#0.0.9
### 開発
* https://github.com/bluebackblue/UpmPad.git?path=BlueBackPad/Assets/UPM

## Unityへの追加方法
* Unity起動
* メニュー選択：「Window->Package Manager」
* ボタン選択：「左上の＋ボタン」
* リスト選択：「Add package from git URL...」
* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」
### 注
Gitクライアントがインストールされている必要がある。
* https://docs.unity3d.com/ja/current/Manual/upm-git.html
* https://git-scm.com/

## 例
```
/** Update用。
*/
private BlueBack.Pad.Pad pad;

/** FixedUpdate用。
*/
private BlueBack.Pad.Pad pad_fixedupdate;

/** Start
*/
private void Start()
{
	//Param
	BlueBack.Pad.UIM.InitParam t_param = new BlueBack.Pad.UIM.InitParam(BlueBack.Pad.UIM.InitParam.ParamType.PS_ALL);

	//Update用。
	this.pad = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Update,BlueBack.Pad.InitParam.CreateDefault(),new BlueBack.Pad.UIM.Engine(t_param));

	//FixedUpdate用。
	this.pad_fixedupdate = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.FixedUpdate,BlueBack.Pad.InitParam.CreateDefault(),new BlueBack.Pad.UIM.Engine(t_param));
}

/** Update
*/
private void Update()
{
	if(this.pad.dir_r.down == true){
		UnityEngine.Debug.Log("Update : Right");
	}
	if(this.pad.dir_d.down == true){
		UnityEngine.Debug.Log("Update : Down");
	}
	if(this.pad.dir_l.down == true){
		UnityEngine.Debug.Log("Update : Left");
	}
	if(this.pad.dir_u.down == true){
		UnityEngine.Debug.Log("Update : Up");
	}
}

/** FixedUpdate
*/
private void FixedUpdate()
{
	if(this.pad_fixedupdate.dir_r.down == true){
		UnityEngine.Debug.Log("Update : Right");
	}
	if(this.pad_fixedupdate.dir_d.down == true){
		UnityEngine.Debug.Log("Update : Down");
	}
	if(this.pad_fixedupdate.dir_l.down == true){
		UnityEngine.Debug.Log("Update : Left");
	}
	if(this.pad_fixedupdate.dir_u.down == true){
		UnityEngine.Debug.Log("Update : Up");
	}
}
```
### InputManagerAssetへの追加方向
![Sample00](/sample00.png)

