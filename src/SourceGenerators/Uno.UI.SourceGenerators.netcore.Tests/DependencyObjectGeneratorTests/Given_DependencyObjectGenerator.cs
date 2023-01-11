﻿using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Testing.Verifiers;
using Microsoft.CodeAnalysis.Text;
using Uno.UI.SourceGenerators.DependencyObject;
using Uno.UI.SourceGenerators.Tests.Verifiers;

namespace Uno.UI.SourceGenerators.Tests.DependencyObjectGeneratorTests;

using Verify = CSharpSourceGeneratorVerifier<DependencyObjectGenerator>;

[TestClass]
public class Given_DependencyObjectGenerator
{
	private static readonly ImmutableArray<PackageIdentity> _unoPackage = ImmutableArray.Create(new PackageIdentity("Uno.UI", "4.6.19"));
	private static readonly ReferenceAssemblies _Net60AndroidWithUno = ReferenceAssemblies.Net.Net60Android.AddPackages(_unoPackage);
	private static readonly ReferenceAssemblies _Net60WithUno = ReferenceAssemblies.Net.Net60.AddPackages(_unoPackage);

	[TestInitialize]
	public void Initialize()
	{
		DependencyObjectGenerator.IsUnitTest = true;
	}

	[TestCleanup]
	public void Cleanup()
	{
		DependencyObjectGenerator.IsUnitTest = false;
	}

	private async Task TestAndroid(string testCode, params DiagnosticResult[] expectedDiagnostics)
	{
		var test = new Verify.Test
		{
			TestState =
			{
				Sources = { testCode },
			},
			ReferenceAssemblies = _Net60AndroidWithUno,
		};
		test.ExpectedDiagnostics.AddRange(expectedDiagnostics);
		await test.RunAsync();
	}

	[TestMethod]
	public async Task TestAndroidViewImplementingDependencyObject()
	{
		await TestAndroid("""
			using Android.Content;
			using Windows.UI.Core;
			using Microsoft.UI.Xaml;

			public class C : Android.Views.View, DependencyObject
			{
				public C(Context context) : base(context)
				{
				}

				public CoreDispatcher Dispatcher { get; }
				public object GetValue(DependencyProperty dp) => null;
				public void SetValue(DependencyProperty dp, object value) { }
				public void ClearValue(DependencyProperty dp) { }
				public object ReadLocalValue(DependencyProperty dp) => null;
				public object GetAnimationBaseValue(DependencyProperty dp) => null;
				public long RegisterPropertyChangedCallback(DependencyProperty dp, DependencyPropertyChangedCallback callback) => 0;
				public void UnregisterPropertyChangedCallback(DependencyProperty dp, long token) { }
			}
			""",
		// /0/Test0.cs(5,14): error Uno0003: 'Android.Views.View' shouldn't implement 'DependencyObject'. Inherit 'FrameworkElement' instead.
		DiagnosticResult.CompilerError("Uno0003").WithSpan(5, 14, 5, 15).WithArguments("Android.Views.View"));
	}

	[TestMethod]
	public async Task TestNested()
	{
		var test = """
			using Windows.UI.Core;
			using Microsoft.UI.Xaml;

			internal partial class OuterClass
			{
				internal partial class Inner : DependencyObject
				{
				}
			}
			""";

		await new CSharpSourceGeneratorTest<DependencyObjectGenerator, MSTestVerifier>()
		{
			TestState =
			{
				Sources = { test },
				GeneratedSources =
				{
					{ (@"Uno.UI.SourceGenerators\Uno.UI.SourceGenerators.DependencyObject.DependencyObjectGenerator\OuterClass.Inner_d21c9c80c794838c736d3a5351b7c79f.cs", SourceText.From("""
	 // <auto-generated>
	 // ******************************************************************
	 // This file has been generated by Uno.UI (DependencyObjectGenerator)
	 // ******************************************************************
	 // </auto-generated>

	 #pragma warning disable 1591 // Ignore missing XML comment warnings
	 using System;
	 using System.Linq;
	 using System.Collections.Generic;
	 using System.Collections;
	 using System.Diagnostics.CodeAnalysis;
	 using Uno.Disposables;
	 using System.Runtime.CompilerServices;
	 using Uno.UI;
	 using Uno.UI.Controls;
	 using Uno.UI.DataBinding;
	 using Microsoft.UI.Xaml;
	 using Microsoft.UI.Xaml.Data;
	 using Uno.Diagnostics.Eventing;
	 #if __MACOS__
	 using AppKit;
	 #endif
	 partial class OuterClass
	 {
	 	[global::Microsoft.UI.Xaml.Data.Bindable]
	 	partial class Inner : IDependencyObjectStoreProvider, IWeakReferenceProvider
	 	{
	 		private DependencyObjectStore __storeBackingField;
	 		public Windows.UI.Core.CoreDispatcher Dispatcher => Windows.ApplicationModel.Core.CoreApplication.MainView.Dispatcher;
	 		private DependencyObjectStore __Store
	 		{
	 			get
	 			{
	 				if(__storeBackingField == null)
	 				{
	 					__storeBackingField = new DependencyObjectStore(this, DataContextProperty, TemplatedParentProperty);
	 					__InitializeBinder();
	 				}
	 				return __storeBackingField;
	 			}
	 		}
	 		public bool IsStoreInitialized => __storeBackingField != null;
	 		DependencyObjectStore IDependencyObjectStoreProvider.Store => __Store;
	 		public object GetValue(DependencyProperty dp) => __Store.GetValue(dp);
	 		public void SetValue(DependencyProperty dp, object value) => __Store.SetValue(dp, value);
	 		public void ClearValue(DependencyProperty dp) => __Store.ClearValue(dp);
	 		public object ReadLocalValue(DependencyProperty dp) => __Store.ReadLocalValue(dp);
	 		public object GetAnimationBaseValue(DependencyProperty dp) => __Store.GetAnimationBaseValue(dp);
	 		public long RegisterPropertyChangedCallback(DependencyProperty dp, DependencyPropertyChangedCallback callback) => __Store.RegisterPropertyChangedCallback(dp, callback);
	 		public void UnregisterPropertyChangedCallback(DependencyProperty dp, long token) => __Store.UnregisterPropertyChangedCallback(dp, token);
	 		
	 		private readonly static IEventProvider _binderTrace = Tracing.Get(DependencyObjectStore.TraceProvider.Id);
	 		private BinderReferenceHolder _refHolder;
	 		
	 		public event Windows.Foundation.TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> DataContextChanged;
	 		
	 		partial void InitializeBinder();
	 		
	 		private void __InitializeBinder()
	 		{
	 			if(BinderReferenceHolder.IsEnabled)
	 			{
	 				_refHolder = new BinderReferenceHolder(this.GetType(), this);
	 		
	 				UpdateBinderDetails();
	 			}
	 		}
	 		
	 		
	 		partial void UpdateBinderDetails();
	 		
	 		/// <summary>
	 		/// Obsolete method kept for binary compatibility
	 		/// </summary>
	 		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	 		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	 		public void ClearBindings()
	 		{
	 			__Store.ClearBindings();
	 		}
	 		
	 		/// <summary>
	 		/// Obsolete method kept for binary compatibility
	 		/// </summary>
	 		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	 		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	 		public void RestoreBindings()
	 		{
	 			__Store.RestoreBindings();
	 		}
	 		
	 		/// <summary>
	 		/// Obsolete method kept for binary compatibility
	 		/// </summary>
	 		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	 		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	 		public void ApplyCompiledBindings()
	 		{
	 		}
	 		
	 		private global::Uno.UI.DataBinding.ManagedWeakReference _selfWeakReference;
	 		global::Uno.UI.DataBinding.ManagedWeakReference IWeakReferenceProvider.WeakReference 
	 		{
	 			get
	 			{
	 				if(_selfWeakReference == null)
	 				{
	 					_selfWeakReference = global::Uno.UI.DataBinding.WeakReferencePool.RentSelfWeakReference(this);
	 				}
	 				
	 				return _selfWeakReference;
	 			}
	 		}
	 						
	 		public override string ToString() => GetType().FullName;		// hasOverridesAttachedToWindowiOS=false		// hasOverridesAttachedToWindowiOS=false		// Skipped _iosViewSymbol: False, hasNoWillMoveToSuperviewMethod: True		// Skipped _macosViewSymbol: False, hasNoViewWillMoveToSuperviewMethod: True
	 		
	 		
	 		#region DataContext DependencyProperty
	 		
	 		public object DataContext
	 		{
	 			get => GetValue(DataContextProperty);
	 			set => SetValue(DataContextProperty, value);
	 		}
	 		
	 		// Using a DependencyProperty as the backing store for DataContext.  This enables animation, styling, binding, etc...
	 		public static DependencyProperty DataContextProperty { get ; } =
	 			DependencyProperty.Register(
	 				name: nameof(DataContext),
	 				propertyType: typeof(object),
	 				ownerType: typeof(Inner),
	 				typeMetadata: new FrameworkPropertyMetadata(
	 					defaultValue: null,
	 					options: FrameworkPropertyMetadataOptions.Inherits,
	 					propertyChangedCallback: (s, e) => ((Inner)s).OnDataContextChanged(e)
	 				)
	 		);
	 		
	 		internal protected virtual void OnDataContextChanged(DependencyPropertyChangedEventArgs e)
	 		{
	 			OnDataContextChangedPartial(e);
	 			DataContextChanged?.Invoke(null, new DataContextChangedEventArgs(DataContext));
	 		}
	 		
	 		#endregion
	 		
	 		#region TemplatedParent DependencyProperty
	 		
	 		public DependencyObject TemplatedParent
	 		{
	 			get => (DependencyObject)GetValue(TemplatedParentProperty);
	 			set => SetValue(TemplatedParentProperty, value);
	 		}
	 		
	 		// Using a DependencyProperty as the backing store for TemplatedParent.  This enables animation, styling, binding, etc...
	 		public static DependencyProperty TemplatedParentProperty { get ; } =
	 			DependencyProperty.Register(
	 				name: nameof(TemplatedParent),
	 				propertyType: typeof(DependencyObject),
	 				ownerType: typeof(Inner),
	 				typeMetadata: new FrameworkPropertyMetadata(
	 					defaultValue: null,
	 					options: FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.ValueDoesNotInheritDataContext | FrameworkPropertyMetadataOptions.WeakStorage,
	 					propertyChangedCallback: (s, e) => ((Inner)s).OnTemplatedParentChanged(e)
	 				)
	 			);
	 		
	 		
	 		internal protected virtual void OnTemplatedParentChanged(DependencyPropertyChangedEventArgs e)
	 		{
	 			__Store.SetTemplatedParent(e.NewValue as FrameworkElement);
	 			OnTemplatedParentChangedPartial(e);
	 		}
	 		
	 		#endregion
	 		
	 		public void SetBinding(object target, string dependencyProperty, global::Microsoft.UI.Xaml.Data.BindingBase binding)
	 		{
	 			__Store.SetBinding(target, dependencyProperty, binding);
	 		}
	 		
	 		public void SetBinding(string dependencyProperty, global::Microsoft.UI.Xaml.Data.BindingBase binding)
	 		{
	 			__Store.SetBinding(dependencyProperty, binding);
	 		}
	 		
	 		public void SetBinding(DependencyProperty dependencyProperty, global::Microsoft.UI.Xaml.Data.BindingBase binding)
	 		{
	 			__Store.SetBinding(dependencyProperty, binding);
	 		}
	 		
	 		public void SetBindingValue(object value, [CallerMemberName] string propertyName = null)
	 		{
	 			__Store.SetBindingValue(value, propertyName);
	 		}
	 		
	 		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	 		internal bool IsAutoPropertyInheritanceEnabled { get => __Store.IsAutoPropertyInheritanceEnabled; set => __Store.IsAutoPropertyInheritanceEnabled = value; }
	 		
	 		partial void OnDataContextChangedPartial(DependencyPropertyChangedEventArgs e);
	 		
	 		partial void OnTemplatedParentChangedPartial(DependencyPropertyChangedEventArgs e);
	 		
	 		public global::Microsoft.UI.Xaml.Data.BindingExpression GetBindingExpression(DependencyProperty dependencyProperty)
	 			=>  __Store.GetBindingExpression(dependencyProperty);
	 		
	 		public void ResumeBindings() 
	 			=>__Store.ResumeBindings();
	 		
	 		public void SuspendBindings() => 
	 			__Store.SuspendBindings();
	 						
	 	}
	 }
	 
	 """, Encoding.UTF8)) }
				}
			},
			ReferenceAssemblies = _Net60WithUno,
		}.RunAsync();
	}
}
