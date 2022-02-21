

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Pad.UIM
*/
#if(UNITY_EDITOR)
namespace BlueBack.Pad.Editor.UIM
{
	/** MenuItem
	*/
	public static class MenuItem
	{
		/** Item
		*/
		public sealed class Item
		{
			/** Type
			*/
			public enum Type
			{
				KeyOrMouseButton = 0,
				MouseMovement = 1,
				JoyStickAxis = 2,
			};

			/** Axis
			*/
			public enum Axis
			{
				None = 0,
				XAxis = 0,
				YAxis = 1,
				Axis3 = 2,
				Axis4 = 3,
				Axis5 = 4,
				Axis6 = 5,
				Axis7 = 6,
				Axis8 = 7,
				Axis9 = 8,
				Axis10 = 9,
				Axis11 = 10,
				Axis12 = 11,
				Axis13 = 12,
				Axis14 = 13,
				Axis15 = 14,
				Axis16 = 15,
				Axis17 = 16,
				Axis18 = 17,
				Axis19 = 18,
				Axis20 = 19,
				Axis21 = 20,
				Axis22 = 21,
				Axis23 = 22,
				Axis24 = 23,
				Axis25 = 24,
				Axis26 = 25,
				Axis27 = 26,
				Axis28 = 27,
			};

			/** 名前。
			*/
			public string m_Name;

			/** ゲームランチャーに表示される Positive Button 関数の詳細な定義を入力します。
			*/
			public string descriptiveName;

			/** ゲームランチャーに表示される Negative Button 関数の詳細な定義を入力します。
			*/
			public string descriptiveNegativeName;

			/** 軸に負の値を送信するボタンの名前を入力します。
			*/
			public string negativeButton;

			/** 軸に正の値を送信するボタンの名前を入力します。
			*/
			public string positiveButton;

			/** 軸に負の値を送信する代替ボタンの名前を入力します。
			*/
			public string altNegativeButton;

			/** 軸に正の値を送信する代替ボタンの名前を入力します。
			*/
			public string altPositiveButton;

			/** 入力の再センタリングの速さを設定します。このプロパティーは、Type が Key or Mouse Button の場合にのみ適用されます。
			*/
			public float gravity;

			/** 指定した数値未満の正や負の値は 0 として認識されます。ジョイスティックに便利です。
			*/
			public float dead;

			/** キーボード入力の場合、この値を大きくすると、応答時間が速くなります。値が低いと、より滑らかになります。マウス移動の場合、この値によって実際のマウスの移動差分がスケールされます。
			*/
			public float sensitivity;

			/** 有効にすると、反対の入力を受け取った直後に、軸の値が 0 にリセットされます。このプロパティーは、Type が Key or Mouse Button の場合にのみ適用されます。
			*/
			public bool snap;

			/** これを有効にすると、正のボタンが負の値を軸に送信、また、その逆を行います。
			*/
			public bool invert;

			/** この軸がどんな種類の入力を取得するかを選択します。
			*/
			public Type type;

			/** デバイスからの入力軸 (ジョイスティック、マウス、ゲームパッドなど) を選択します。デフォルトは X 軸です。
			*/
			public Axis axis;

			/** 使用するジョイスティックを選択します。デフォルトでは、すべてのジョイスティックからの入力を受け付けます。
			*/
			public int joyNum;
		}

		/** CreateInputManagerAsset_P_ALL
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_P_ALL")]
		private static void MenuItem_CreateInputManagerAsset_P_ALL()
		{
			Inner_Create("p",0);
		}

		/** CreateInputManagerAsset_P_1
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_P_1")]
		private static void MenuItem_CreateInputManagerAsset_P_1()
		{
			Inner_Create("p",1);
		}

		/** CreateInputManagerAsset_P_2
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_P_2")]
		private static void MenuItem_CreateInputManagerAsset_P_2()
		{
			Inner_Create("p",2);
		}

		/** CreateInputManagerAsset_X_ALL
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_X_ALL")]
		private static void MenuItem_CreateInputManagerAsset_X_ALL()
		{
			Inner_Create("x",0);
		}

		/** CreateInputManagerAsset_X_1
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_X_1")]
		private static void MenuItem_CreateInputManagerAsset_X_1()
		{
			Inner_Create("x",1);
		}

		/** CreateInputManagerAsset_X_2
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_X_2")]
		private static void MenuItem_CreateInputManagerAsset_X_2()
		{
			Inner_Create("x",2);
		}

		/** CreateInputManagerAsset_A_ALL
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_A_ALL")]
		private static void MenuItem_CreateInputManagerAsset_A_ALL()
		{
			Inner_Create("a",0);
		}

		/** CreateInputManagerAsset_A_1
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_A_1")]
		private static void MenuItem_CreateInputManagerAsset_A_1()
		{
			Inner_Create("a",1);
		}

		/** CreateInputManagerAsset_A_2
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/CreateInputManagerAsset_A_2")]
		private static void MenuItem_CreateInputManagerAsset_A_2()
		{
			Inner_Create("a",2);
		}

		/** All
		*/
		[UnityEditor.MenuItem("BlueBack/Pad/UIM/All")]
		private static void MenuItem_All()
		{
			Inner_Create("p",0);
			Inner_Create("p",1);
			Inner_Create("p",2);
			Inner_Create("x",0);
			Inner_Create("x",1);
			Inner_Create("x",2);
			Inner_Create("a",0);
			Inner_Create("a",1);
			Inner_Create("a",2);
		}

		/** Inner_Create
		*/
		public static void Inner_Create(string a_controller_type,int a_controller_index)
		{
			System.Collections.Generic.List<Item> t_list = new System.Collections.Generic.List<Item>();
			UnityEngine.Object t_asset = UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>("ProjectSettings/InputManager.asset");
			UnityEditor.SerializedObject t_serialized_root = new UnityEditor.SerializedObject(t_asset);
			UnityEditor.SerializedProperty t_serialized_list = t_serialized_root.FindProperty("m_Axes");

			//ロード。
			{
				for(int ii=0;ii<t_serialized_list.arraySize;ii++){
					Item t_item = new Item();
					{
						UnityEditor.SerializedProperty t_serialized_it = t_serialized_list.GetArrayElementAtIndex(ii);
						t_serialized_it.Next(true);
						do{
							if(t_serialized_it.name == "m_Name"){
								t_item.m_Name = t_serialized_it.stringValue;
							}
							if(t_serialized_it.name == "descriptiveName"){
								t_item.descriptiveName = t_serialized_it.stringValue;
							}
							if(t_serialized_it.name == "descriptiveNegativeName"){
								t_item.descriptiveNegativeName = t_serialized_it.stringValue;
							}
							if(t_serialized_it.name == "negativeButton"){
								t_item.negativeButton = t_serialized_it.stringValue;
							}
							if(t_serialized_it.name == "positiveButton"){
								t_item.positiveButton = t_serialized_it.stringValue;
							}
							if(t_serialized_it.name == "altNegativeButton"){
								t_item.altNegativeButton = t_serialized_it.stringValue;
							}
							if(t_serialized_it.name == "altPositiveButton"){
								t_item.altPositiveButton = t_serialized_it.stringValue;
							}
							if(t_serialized_it.name == "gravity"){
								t_item.gravity = t_serialized_it.floatValue;
							}
							if(t_serialized_it.name == "dead"){
								t_item.dead = t_serialized_it.floatValue;
							}
							if(t_serialized_it.name == "sensitivity"){
								t_item.sensitivity = t_serialized_it.floatValue;
							}
							if(t_serialized_it.name == "snap"){
								t_item.snap = t_serialized_it.boolValue;
							}
							if(t_serialized_it.name == "invert"){
								t_item.invert = t_serialized_it.boolValue;
							}
							if(t_serialized_it.name == "type"){
								t_item.type = (Item.Type)t_serialized_it.intValue;
							}
							if(t_serialized_it.name == "axis"){
								t_item.axis = (Item.Axis)t_serialized_it.intValue;
							}
							if(t_serialized_it.name == "joyNum"){
								t_item.joyNum = t_serialized_it.intValue;
							}
						}while(t_serialized_it.Next(false));
					}
					t_list.Add(t_item);
				}
			}

			//名前リスト。
			string[] t_namelist = new string[]{
				//アナログスティック。
				"stick_lx",
				"stick_ly",
				"stick_rx",
				"stick_ry",

				//十字。
				"dir_x",
				"dir_y",

				//ボタン。
				"button_r",
				"button_d",
				"button_l",
				"button_u",

				//トリガー。
				"trigger_l1",
				"trigger_l2",
				"trigger_l3",
				"trigger_r1",
				"trigger_r2",
				"trigger_r3",

				//メニュー。
				"menu_l",
				"menu_r",
			};

			//設定。
			for(int ii=0;ii<t_namelist.Length;ii++){
				string t_name = a_controller_type + a_controller_index.ToString() + "_" + t_namelist[ii];


				Item t_item = t_list.Find((Item a_a_item)=>{return a_a_item.m_Name == t_name;});
				if(t_item == null){
					t_item = new Item();
					t_list.Add(t_item);
				}
				Inner_ApplyItem(a_controller_type,a_controller_index,t_namelist[ii],t_item);
			}

			//セーブ。
			{
				//リストを空にする。
				t_serialized_list.ClearArray();

				for(int ii=0;ii<t_list.Count;ii++){
					t_serialized_list.arraySize++;
					Item t_item = t_list[ii];
					UnityEditor.SerializedProperty t_serialized_it = t_serialized_list.GetArrayElementAtIndex(t_serialized_list.arraySize - 1);
					t_serialized_it.Next(true);
					do{
						if(t_serialized_it.name == "m_Name"){
							t_serialized_it.stringValue = t_item.m_Name;
						}
						if(t_serialized_it.name == "descriptiveName"){
							t_serialized_it.stringValue = t_item.descriptiveName;
						}
						if(t_serialized_it.name == "descriptiveNegativeName"){
							t_serialized_it.stringValue = t_item.descriptiveNegativeName;
						}
						if(t_serialized_it.name == "negativeButton"){
							t_serialized_it.stringValue = t_item.negativeButton;
						}
						if(t_serialized_it.name == "positiveButton"){
							t_serialized_it.stringValue = t_item.positiveButton;
						}
						if(t_serialized_it.name == "altNegativeButton"){
							t_serialized_it.stringValue = t_item.altNegativeButton;
						}
						if(t_serialized_it.name == "altPositiveButton"){
							t_serialized_it.stringValue = t_item.altPositiveButton;
						}
						if(t_serialized_it.name == "gravity"){
							t_serialized_it.floatValue = t_item.gravity;
						}
						if(t_serialized_it.name == "dead"){
							t_serialized_it.floatValue = t_item.dead;
						}
						if(t_serialized_it.name == "sensitivity"){
							t_serialized_it.floatValue = t_item.sensitivity;
						}
						if(t_serialized_it.name == "snap"){
							t_serialized_it.boolValue = t_item.snap;
						}
						if(t_serialized_it.name == "invert"){
							t_serialized_it.boolValue = t_item.invert;
						}
						if(t_serialized_it.name == "type"){
							t_serialized_it.intValue = (int)t_item.type;
						}
						if(t_serialized_it.name == "axis"){
							t_serialized_it.intValue = (int)t_item.axis;
						}
						if(t_serialized_it.name == "joyNum"){
							t_serialized_it.intValue = t_item.joyNum;
						}
					}while(t_serialized_it.Next(false));
				}

				t_serialized_root.ApplyModifiedProperties();
			}
		}

		/** Inner_ApplyItem
		*/
		private static void Inner_ApplyItem(string a_cotroller_type,int a_controller_index,string a_name,Item a_item)
		{
			a_item.m_Name = a_cotroller_type + a_controller_index.ToString() + "_" + a_name;

			a_item.descriptiveName = "";
			a_item.descriptiveNegativeName = "";
			a_item.negativeButton = "";
			a_item.positiveButton = "";
			a_item.altNegativeButton = "";
			a_item.altPositiveButton = "";
			a_item.gravity = 0.0f;
			a_item.dead = 0.000f;
			a_item.sensitivity = 1.0f;
			a_item.snap = false;
			a_item.invert = false;
			a_item.type = Item.Type.KeyOrMouseButton;
			a_item.axis = Item.Axis.None;
			a_item.joyNum = 0;

			switch(a_cotroller_type + "_" + a_name){
			case "p_stick_lx":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.XAxis;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_stick_ly":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.YAxis;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_stick_rx":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis3;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_stick_ry":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.invert = true;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis6;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_dir_x":
				{
					//十字。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis7;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_dir_y":
				{
					//十字。

					a_item.invert = true;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis8;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_button_r":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 2";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_button_d":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 1";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_button_l":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 0";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_button_u":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 3";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_trigger_l1":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 4";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_trigger_l2":
				{
					//トリガー。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis4;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_trigger_l3":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 10";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_trigger_r1":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 5";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_trigger_r2":
				{
					//トリガー。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis5;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_trigger_r3":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 11";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_menu_l":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 8";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "p_menu_r":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 9";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = 0;
				}break;
			case "x_stick_lx":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.XAxis;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_stick_ly":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.YAxis;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_stick_rx":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis4;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_stick_ry":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis5;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_dir_x":
				{
					//十字。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis7;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_dir_y":
				{
					//十字。

					a_item.invert = true;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis8;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_button_r":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 1";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_button_d":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 0";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_button_l":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 2";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_button_u":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 3";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_trigger_l1":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 4";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_trigger_l2":
				{
					//トリガー。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis9;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_trigger_l3":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 8";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_trigger_r1":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 5";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_trigger_r2":
				{
					//トリガー。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis10;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_trigger_r3":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 9";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_menu_l":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 6";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "x_menu_r":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 7";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = 0;
				}break;
			case "a_stick_lx":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.XAxis;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_stick_ly":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.YAxis;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_stick_rx":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis3;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_stick_ry":
				{
					//アナログスティック。

					a_item.dead = 0.1f;
					a_item.invert = true;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis4;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_dir_x":
				{
					//十字。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis5;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_dir_y":
				{
					//十字。

					a_item.invert = true;
					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis6;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_button_r":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 1";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_button_d":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 0";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_button_l":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 2";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_button_u":
				{
					//ボタン。

					a_item.positiveButton = "joystick button 3";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_trigger_l1":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 4";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_trigger_l2":
				{
					//トリガー。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis14;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_trigger_l3":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 8";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_trigger_r1":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 5";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_trigger_r2":
				{
					//トリガー。

					a_item.type = Item.Type.JoyStickAxis;
					a_item.axis = Item.Axis.Axis15;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_trigger_r3":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 11";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_menu_l":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 9";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = a_controller_index;
				}break;
			case "a_menu_r":
				{
					//トリガー。

					a_item.positiveButton = "joystick button 10";
					a_item.type = Item.Type.KeyOrMouseButton;
					a_item.axis = Item.Axis.None;
					a_item.joyNum = 0;
				}break;
			}
		}
	}
}
#endif

