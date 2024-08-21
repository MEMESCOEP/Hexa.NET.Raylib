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
	/// GlyphInfo, font characters glyphs info<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "GlyphInfo")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct GlyphInfo
	{
		/// <summary>
		/// Character value (Unicode)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "value")]
		[NativeName(NativeNameType.Type, "int")]
		public int Value;

		/// <summary>
		/// Character offset X when drawing<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "offsetX")]
		[NativeName(NativeNameType.Type, "int")]
		public int OffsetX;

		/// <summary>
		/// Character offset Y when drawing<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "offsetY")]
		[NativeName(NativeNameType.Type, "int")]
		public int OffsetY;

		/// <summary>
		/// Character advance position X<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "advanceX")]
		[NativeName(NativeNameType.Type, "int")]
		public int AdvanceX;

		/// <summary>
		/// Character image data<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "image")]
		[NativeName(NativeNameType.Type, "Image")]
		public Image Image;


		public unsafe GlyphInfo(int value = default, int offsetX = default, int offsetY = default, int advanceX = default, Image image = default)
		{
			Value = value;
			OffsetX = offsetX;
			OffsetY = offsetY;
			AdvanceX = advanceX;
			Image = image;
		}


	}

}
