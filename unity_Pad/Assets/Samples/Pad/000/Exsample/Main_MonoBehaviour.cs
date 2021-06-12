

#define PAD_UPDATE
#define PAD_FIXEDUPDATE
#define PAD_MANUAL


/** Samples.Pad.Exsample
*/
namespace Samples.Pad.Exsample
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** pad_update
		*/
		#if(PAD_UPDATE)
		private BlueBack.Pad.Pad pad_update;
		#endif

		/** pad_fixedupdate
		*/
		#if(PAD_FIXEDUPDATE)
		private BlueBack.Pad.Pad pad_fixedupdate;
		#endif

		/** マニュアル呼び出し。
		*/
		#if(PAD_MANUAL)
		private BlueBack.Pad.Pad pad_manual;
		#endif

		/** 表示。
		*/
		#if(PAD_UPDATE)
		private UnityEngine.UI.Text text_update;
		private int value_update;
		private UnityEngine.Vector2 value_wheel_update;
		#endif
		
		#if(PAD_FIXEDUPDATE)
		private UnityEngine.UI.Text text_fixedupdate;
		private int value_fixedupdate;
		private UnityEngine.Vector2 value_wheel_fixedupdate;
		#endif

		#if(PAD_MANUAL)
		private UnityEngine.UI.Text text_manual;
		private int value_manual;
		private UnityEngine.Vector2 value_wheel_manual;
		#endif

		/** Start
		*/
		private void Start()
		{
			//pad_update
			#if(PAD_UPDATE)
			this.pad_update = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Update,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine());
			this.text_update = UnityEngine.GameObject.Find("Text_Update").GetComponent<UnityEngine.UI.Text>();
			this.value_update = 0;
			this.value_wheel_update = new UnityEngine.Vector2(0.0f,0.0f);
			#endif

			//pad_fixedupdate
			#if(PAD_FIXEDUPDATE)
			this.pad_fixedupdate = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.FixedUpdate,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine());
			this.text_fixedupdate = UnityEngine.GameObject.Find("Text_FixedUpdate").GetComponent<UnityEngine.UI.Text>();
			this.value_fixedupdate = 0;
			this.value_wheel_fixedupdate = new UnityEngine.Vector2(0.0f,0.0f);
			#endif

			//マニュアル呼び出し。
			#if(PAD_MANUAL)
			this.pad_manual = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Manual,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine());
			this.text_manual = UnityEngine.GameObject.Find("Text_Manual").GetComponent<UnityEngine.UI.Text>();
			this.value_manual = 0;
			this.value_wheel_manual = new UnityEngine.Vector2(0.0f,0.0f);
			#endif

			//表示。
			UnityEngine.Application.targetFrameRate = 10;
		}

		/** Update
		*/
		private void Update()
		{
			#if(PAD_UPDATE)

			if(this.pad_update.left.rapid == true){
				this.value_update++;
			}

			if(this.pad_update.right.down == true){
				this.value_update--;
			}

			if(this.pad_update.center.up == true){
				this.value_update = 0;
			}

			this.value_wheel_update += this.pad_update.wheel.pos;

			#endif
		}

		/** FixedUpdate
		*/
		private void FixedUpdate()
		{
			#if(PAD_FIXEDUPDATE)

			if(this.pad_fixedupdate.left.rapid == true){
				this.value_fixedupdate++;
			}
			if(this.pad_fixedupdate.right.down == true){
				this.value_fixedupdate--;
			}
			if(this.pad_fixedupdate.center.up == true){
				this.value_fixedupdate = 0;
			}

			this.value_wheel_fixedupdate += this.pad_fixedupdate.wheel.pos;

			#endif
		}

		/** LateUpdate
		*/
		private void LateUpdate()
		{
			#if(PAD_MANUAL)

			//マニュアル呼び出し。
			this.pad_manual.StatusUpdate();

			if(this.pad_manual.left.rapid == true){
				this.value_manual++;
			}
			if(this.pad_manual.right.down == true){
				this.value_manual--;
			}
			if(this.pad_manual.center.up == true){
				this.value_manual = 0;
			}

			this.value_wheel_manual += this.pad_manual.wheel.pos;

			#endif

			#if(PAD_UPDATE)
			this.text_update.text		= string.Format("Update      {0} {1} {2} {3:0.000} {4:0.000}",this.value_update,this.value_wheel_update.x,this.value_wheel_update.y,this.pad_update.cursor.pos.x,this.pad_update.cursor.pos.y);
			#endif

			#if(PAD_FIXEDUPDATE)
			this.text_fixedupdate.text	= string.Format("FixedUpdate {0} {1} {2} {3:0.000} {4:0.000}",this.value_fixedupdate,this.value_wheel_fixedupdate.x,this.value_wheel_fixedupdate.y,this.pad_fixedupdate.cursor.pos.x,this.pad_fixedupdate.cursor.pos.y);
			#endif

			#if(PAD_MANUAL)
			this.text_manual.text		= string.Format("Manual      {0} {1} {2} {3:0.000} {4:0.000}",this.value_manual,this.value_wheel_manual.x,this.value_wheel_manual.y,this.pad_manual.cursor.pos.x,this.pad_manual.cursor.pos.y);
			#endif
		}
	}
}

