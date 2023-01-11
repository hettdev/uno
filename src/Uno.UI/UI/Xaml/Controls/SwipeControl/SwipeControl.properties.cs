﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

// DO NOT EDIT! This file was generated by CustomTasks.DependencyPropertyCodeGen

// Imported in uno on 2021/03/21 from commit 307bd99682cccaa128483036b764c0b7c862d666
// https://github.com/microsoft/microsoft-ui-xaml/blob/307bd99682cccaa128483036b764c0b7c862d666/dev/Generated/SwipeControl.properties.cpp

namespace Microsoft.UI.Xaml.Controls
{
	public partial class SwipeControl
	{

		//GlobalDependencyProperty s_BottomItemsProperty{ null };
		//GlobalDependencyProperty s_LeftItemsProperty{ null };
		//GlobalDependencyProperty s_RightItemsProperty{ null };
		//GlobalDependencyProperty s_TopItemsProperty{ null };

		//SwipeControlProperties()
		//{
		//    EnsureProperties();
		//}

		//void EnsureProperties()
		//{
		//    if (!s_BottomItemsProperty)
		//    {
		//        s_BottomItemsProperty =
		//            InitializeDependencyProperty(
		//                "BottomItems",
		//                name_of<SwipeItems>(),
		//                name_of<SwipeControl>(),
		//                false /* isAttached */,
		//                ValueHelper<SwipeItems>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnBottomItemsPropertyChanged));
		//    }
		//    if (!s_LeftItemsProperty)
		//    {
		//        s_LeftItemsProperty =
		//            InitializeDependencyProperty(
		//                "LeftItems",
		//                name_of<SwipeItems>(),
		//                name_of<SwipeControl>(),
		//                false /* isAttached */,
		//                ValueHelper<SwipeItems>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnLeftItemsPropertyChanged));
		//    }
		//    if (!s_RightItemsProperty)
		//    {
		//        s_RightItemsProperty =
		//            InitializeDependencyProperty(
		//                "RightItems",
		//                name_of<SwipeItems>(),
		//                name_of<SwipeControl>(),
		//                false /* isAttached */,
		//                ValueHelper<SwipeItems>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnRightItemsPropertyChanged));
		//    }
		//    if (!s_TopItemsProperty)
		//    {
		//        s_TopItemsProperty =
		//            InitializeDependencyProperty(
		//                "TopItems",
		//                name_of<SwipeItems>(),
		//                name_of<SwipeControl>(),
		//                false /* isAttached */,
		//                ValueHelper<SwipeItems>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnTopItemsPropertyChanged));
		//    }
		//}

		//void ClearProperties()
		//{
		//    s_BottomItemsProperty = null;
		//    s_LeftItemsProperty = null;
		//    s_RightItemsProperty = null;
		//    s_TopItemsProperty = null;
		//}

		private static void OnBottomItemsPropertyChanged(
		    DependencyObject sender,
		    DependencyPropertyChangedEventArgs args)
		{
		    var owner = (SwipeControl)sender;
		    owner.OnPropertyChanged(args);
		}

		private static void OnLeftItemsPropertyChanged(
		    DependencyObject sender,
		    DependencyPropertyChangedEventArgs args)
		{
		    var owner = (SwipeControl)sender;
		    owner.OnPropertyChanged(args);
		}

		private static void OnRightItemsPropertyChanged(
		    DependencyObject sender,
		    DependencyPropertyChangedEventArgs args)
		{
		    var owner = (SwipeControl)sender;
		    owner.OnPropertyChanged(args);
		}

		private static void OnTopItemsPropertyChanged(
		    DependencyObject sender,
		    DependencyPropertyChangedEventArgs args)
		{
		    var owner = (SwipeControl)sender;
		    owner.OnPropertyChanged(args);
		}


		public static DependencyProperty BottomItemsProperty { get; } = DependencyProperty.Register(
			"BottomItems", typeof(SwipeItems), typeof(SwipeControl), new FrameworkPropertyMetadata(default(SwipeItems), OnBottomItemsPropertyChanged));

		public SwipeItems BottomItems
		{
			get { return (SwipeItems)GetValue(BottomItemsProperty); }
			set { SetValue(BottomItemsProperty, value); }
		}
		//void BottomItems(SwipeItems & value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeControl)(this).SetValue(s_BottomItemsProperty, ValueHelper<SwipeItems>.BoxValueIfNecessary(value));
		//    }
		//}

		//SwipeItems BottomItems()
		//{
		//    return ValueHelper<SwipeItems>.CastOrUnbox((SwipeControl)(this).GetValue(s_BottomItemsProperty));
		//}


		public static DependencyProperty LeftItemsProperty { get; } = DependencyProperty.Register(
			"LeftItems", typeof(SwipeItems), typeof(SwipeControl), new FrameworkPropertyMetadata(default(SwipeItems), OnLeftItemsPropertyChanged));

		public SwipeItems LeftItems
		{
			get { return (SwipeItems)GetValue(LeftItemsProperty); }
			set { SetValue(LeftItemsProperty, value); }
		}

		//void LeftItems(SwipeItems & value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeControl)(this).SetValue(s_LeftItemsProperty, ValueHelper<SwipeItems>.BoxValueIfNecessary(value));
		//    }
		//}

		//SwipeItems LeftItems()
		//{
		//    return ValueHelper<SwipeItems>.CastOrUnbox((SwipeControl)(this).GetValue(s_LeftItemsProperty));
		//}

		public static DependencyProperty RightItemsProperty { get; } = DependencyProperty.Register(
			"RightItems", typeof(SwipeItems), typeof(SwipeControl), new FrameworkPropertyMetadata(default(SwipeItems), OnRightItemsPropertyChanged));

		public SwipeItems RightItems
		{
			get { return (SwipeItems)GetValue(RightItemsProperty); }
			set { SetValue(RightItemsProperty, value); }
		}

		//void RightItems(SwipeItems & value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeControl)(this).SetValue(s_RightItemsProperty, ValueHelper<SwipeItems>.BoxValueIfNecessary(value));
		//    }
		//}

		//SwipeItems RightItems()
		//{
		//    return ValueHelper<SwipeItems>.CastOrUnbox((SwipeControl)(this).GetValue(s_RightItemsProperty));
		//}

		public static DependencyProperty TopItemsProperty { get; } = DependencyProperty.Register(
			"TopItems", typeof(SwipeItems), typeof(SwipeControl), new FrameworkPropertyMetadata(default(SwipeItems), OnTopItemsPropertyChanged));

		public SwipeItems TopItems
		{
			get { return (SwipeItems)GetValue(TopItemsProperty); }
			set { SetValue(TopItemsProperty, value); }
		}

		//void TopItems(SwipeItems & value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeControl)(this).SetValue(s_TopItemsProperty, ValueHelper<SwipeItems>.BoxValueIfNecessary(value));
		//    }
		//}

		//SwipeItems TopItems()
		//{
		//    return ValueHelper<SwipeItems>.CastOrUnbox((SwipeControl)(this).GetValue(s_TopItemsProperty));
		//}
}}
