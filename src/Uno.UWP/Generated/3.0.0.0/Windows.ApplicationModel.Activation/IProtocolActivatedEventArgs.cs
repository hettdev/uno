#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if false || false || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IProtocolActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
		#if false || false || NET461 || __WASM__ || __MACOS__
		global::System.Uri Uri
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs.Uri.get
	}
}
