#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PickerFlyout : global::Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.UIElement Content
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(ContentProperty);
			}
			set
			{
				this.SetValue(ContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ConfirmationButtonsVisible
		{
			get
			{
				return (bool)this.GetValue(ConfirmationButtonsVisibleProperty);
			}
			set
			{
				this.SetValue(ConfirmationButtonsVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ConfirmationButtonsVisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ConfirmationButtonsVisible), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.PickerFlyout), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ContentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Content), typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Windows.UI.Xaml.Controls.PickerFlyout), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.PickerFlyout.PickerFlyout()
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.PickerFlyout()
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.Content.get
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.Content.set
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.ConfirmationButtonsVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.ConfirmationButtonsVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.Confirmed.add
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.Confirmed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> ShowAtAsync( global::Windows.UI.Xaml.FrameworkElement target)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> PickerFlyout.ShowAtAsync(FrameworkElement target) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.ContentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.PickerFlyout.ConfirmationButtonsVisibleProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.PickerFlyout, global::Windows.UI.Xaml.Controls.PickerConfirmedEventArgs> Confirmed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.PickerFlyout", "event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> PickerFlyout.Confirmed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.PickerFlyout", "event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> PickerFlyout.Confirmed");
			}
		}
		#endif
	}
}
