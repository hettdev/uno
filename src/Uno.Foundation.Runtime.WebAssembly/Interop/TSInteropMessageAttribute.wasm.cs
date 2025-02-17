﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uno.Foundation.Interop
{
	/// <summary>
	/// Marks a struct as an interop message for the <see cref="TSBindingsGenerator"/> TypeScript generator.
	/// </summary>
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	public class TSInteropMessageAttribute : Attribute
	{	
		public CodeGeneration Marshaller { get; set; }

		public CodeGeneration UnMarshaller { get; set; }
	}

	public enum CodeGeneration
	{
		Auto = 0,
		Enabled = 1,
		Disabled = 256,
	}
}
