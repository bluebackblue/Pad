

/** Samples.Pad.Simple
*/
namespace Samples.Pad.Simple
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
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
			//Update用。
			this.pad = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Update,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine());

			//FixedUpdate用。
			this.pad_fixedupdate = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.FixedUpdate,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine());
		}

		/** Update
		*/
		private void Update()
		{
			if(this.pad.left.down == true){
				UnityEngine.Debug.Log("Update.Left.Down");
			}
		}

		/** FixedUpdate
		*/
		private void FixedUpdate()
		{
			if(this.pad_fixedupdate.left.down == true){
				UnityEngine.Debug.Log("FixedUpdate.Left.Down");
			}
		}
	}
}

