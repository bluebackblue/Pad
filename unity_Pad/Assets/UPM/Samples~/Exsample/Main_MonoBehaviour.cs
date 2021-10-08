

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
		#endif
		
		#if(PAD_FIXEDUPDATE)
		private UnityEngine.UI.Text text_fixedupdate;
		private int value_fixedupdate;
		#endif

		#if(PAD_MANUAL)
		private UnityEngine.UI.Text text_manual;
		private int value_manual;
		#endif

		/** Start
		*/
		private void Start()
		{
			BlueBack.Pad.UIM.Param t_param = new BlueBack.Pad.UIM.Param(BlueBack.Pad.UIM.Param.ParamType.PS_ALL);

			//pad_update
			#if(PAD_UPDATE)
			this.pad_update = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Update,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine(t_param));
			this.text_update = UnityEngine.GameObject.Find("Text_Update").GetComponent<UnityEngine.UI.Text>();
			this.value_update = 0;
			#endif

			//pad_fixedupdate
			#if(PAD_FIXEDUPDATE)
			this.pad_fixedupdate = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.FixedUpdate,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine(t_param));
			this.text_fixedupdate = UnityEngine.GameObject.Find("Text_FixedUpdate").GetComponent<UnityEngine.UI.Text>();
			this.value_fixedupdate = 0;
			#endif

			//マニュアル呼び出し。
			#if(PAD_MANUAL)
			this.pad_manual = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Manual,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine(t_param));
			this.text_manual = UnityEngine.GameObject.Find("Text_Manual").GetComponent<UnityEngine.UI.Text>();
			this.value_manual = 0;
			#endif

			//表示。
			UnityEngine.Application.targetFrameRate = 10;
		}

		/** OnDestroy
		*/
		private void OnDestroy()
		{
			#if(PAD_UPDATE)
			if(this.pad_update != null){
				this.pad_update.Dispose();
				this.pad_update = null;
			}
			#endif

			#if(PAD_FIXEDUPDATE)
			if(this.pad_fixedupdate != null){
				this.pad_fixedupdate.Dispose();
				this.pad_fixedupdate = null;
			}
			#endif

			#if(PAD_MANUAL)
			if(this.pad_manual != null){
				this.pad_manual.Dispose();
				this.pad_manual = null;
			}
			#endif
		}

		/** Update
		*/
		private void Update()
		{
			#if(PAD_UPDATE)

			if(this.pad_update.dir_l.rapid == true){
				this.value_update++;
			}

			if(this.pad_update.button_r.down == true){
				this.value_update--;
			}

			if(this.pad_update.button_lt2.up == true){
				this.value_update = 0;
			}

			#endif
		}

		/** FixedUpdate
		*/
		private void FixedUpdate()
		{
			#if(PAD_FIXEDUPDATE)

			if(this.pad_fixedupdate.dir_l.rapid == true){
				this.value_fixedupdate++;
			}
			if(this.pad_fixedupdate.button_r.down == true){
				this.value_fixedupdate--;
			}
			if(this.pad_fixedupdate.button_lt2.up == true){
				this.value_fixedupdate = 0;
			}

			#endif
		}

		/** LateUpdate
		*/
		private void LateUpdate()
		{
			#if(PAD_MANUAL)

			//マニュアル呼び出し。
			this.pad_manual.StatusUpdate();

			if(this.pad_manual.dir_l.rapid == true){
				this.value_manual++;
			}
			if(this.pad_manual.button_r.down == true){
				this.value_manual--;
			}
			if(this.pad_manual.button_lt2.up == true){
				this.value_manual = 0;
			}

			#endif

			#if(PAD_UPDATE)
			this.text_update.text		= string.Format("Update      {0} {1:0.000} {2:0.000} {3:0.000} {4:0.000}",this.value_update,this.pad_update.stick_l.pos.x,this.pad_update.stick_l.pos.y,this.pad_update.stick_r.pos.x,this.pad_update.stick_r.pos.y);
			#endif

			#if(PAD_FIXEDUPDATE)
			this.text_fixedupdate.text	= string.Format("FixedUpdate {0} {1:0.000} {2:0.000} {3:0.000} {4:0.000}",this.value_fixedupdate,this.pad_fixedupdate.stick_l.pos.x,this.pad_fixedupdate.stick_l.pos.y,this.pad_fixedupdate.stick_r.pos.x,this.pad_fixedupdate.stick_r.pos.y);
			#endif

			#if(PAD_MANUAL)
			this.text_manual.text		= string.Format("Manual      {0} {1:0.000} {2:0.000} {3:0.000} {4:0.000}",this.value_manual,this.pad_manual.stick_l.pos.x,this.pad_manual.stick_l.pos.y,this.pad_manual.stick_r.pos.x,this.pad_manual.stick_r.pos.y);
			#endif
		}
	}
}

