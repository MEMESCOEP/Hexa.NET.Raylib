// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Raylib
{
	/// <summary>
	/// Texture parameters: filter mode<br/>
	/// NOTE 1: Filtering considers mipmaps if available in the texture<br/>
	/// NOTE 2: Filter is accordingly set for minification and magnification<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "TextureFilter")]
	[Flags]
	public enum TextureFilter : int
	{
		/// <summary>
		/// No filter, just pixel approximation<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "TEXTURE_FILTER_POINT")]
		[NativeName(NativeNameType.Value, "0")]
		Point = unchecked(0),

		/// <summary>
		/// Linear filtering<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "TEXTURE_FILTER_BILINEAR")]
		[NativeName(NativeNameType.Value, "1")]
		Bilinear = unchecked(1),

		/// <summary>
		/// Trilinear filtering (linear with mipmaps)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "TEXTURE_FILTER_TRILINEAR")]
		[NativeName(NativeNameType.Value, "2")]
		Trilinear = unchecked(2),

		/// <summary>
		/// Anisotropic filtering 4x<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "TEXTURE_FILTER_ANISOTROPIC_4X")]
		[NativeName(NativeNameType.Value, "3")]
		Anisotropic4X = unchecked(3),

		/// <summary>
		/// Anisotropic filtering 8x<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "TEXTURE_FILTER_ANISOTROPIC_8X")]
		[NativeName(NativeNameType.Value, "4")]
		Anisotropic8X = unchecked(4),

		/// <summary>
		/// Anisotropic filtering 16x<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "TEXTURE_FILTER_ANISOTROPIC_16X")]
		[NativeName(NativeNameType.Value, "5")]
		Anisotropic16X = unchecked(5),
	}
}
