using System.Threading.Tasks;
using System.Threading;

namespace ZXing.Mobile
{
	public class MobileBarcodeScanner : MobileBarcodeScannerBase
	{
		//ZxingCameraViewController viewController;
		ManualResetEvent scanResultResetEvent = new ManualResetEvent(false);

		public MobileBarcodeScanner ()
		{
		}

		public Task<Result> Scan (bool useAVCaptureEngine)
		{
			return Scan (new MobileBarcodeScanningOptions (), useAVCaptureEngine);
		}


		public override Task<Result> Scan (MobileBarcodeScanningOptions options)
		{
			return Scan (options, false);
		}

		public Task<Result> Scan (MobileBarcodeScanningOptions options, bool useAVCaptureEngine)
		{
		    return Task.Factory.StartNew(() => default(Result));
		}

		public override void Cancel ()
		{
		}

		public override void Torch (bool on)
		{
		}

		public override void ToggleTorch ()
		{
		}

		public override void AutoFocus ()
		{
			//Does nothing on iOS
		}

		public override bool IsTorchOn {
			get {
				return false;
			}
		}
	}
}

