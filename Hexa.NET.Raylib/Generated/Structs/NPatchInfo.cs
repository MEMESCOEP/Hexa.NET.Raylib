// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Raylib
{
	/// <summary>
	/// NPatchInfo, n-patch layout info<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "NPatchInfo")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct NPatchInfo
	{
		/// <summary>
		/// Texture source rectangle<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "source")]
		[NativeName(NativeNameType.Type, "Rectangle")]
		public Rectangle Source;

		/// <summary>
		/// Left border offset<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "left")]
		[NativeName(NativeNameType.Type, "int")]
		public int Left;

		/// <summary>
		/// Top border offset<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "top")]
		[NativeName(NativeNameType.Type, "int")]
		public int Top;

		/// <summary>
		/// Right border offset<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "right")]
		[NativeName(NativeNameType.Type, "int")]
		public int Right;

		/// <summary>
		/// Bottom border offset<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "bottom")]
		[NativeName(NativeNameType.Type, "int")]
		public int Bottom;

		/// <summary>
		/// Layout of the n-patch: 3x3, 1x3 or 3x1<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "layout")]
		[NativeName(NativeNameType.Type, "int")]
		public int Layout;


		public unsafe NPatchInfo(Rectangle source = default, int left = default, int top = default, int right = default, int bottom = default, int layout = default)
		{
			Source = source;
			Left = left;
			Top = top;
			Right = right;
			Bottom = bottom;
			Layout = layout;
		}


	}

}
