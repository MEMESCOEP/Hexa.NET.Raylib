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
	#if NET5_0_OR_GREATER
	/// <summary>
	/// Callbacks to hook some internal functions<br/>
	/// WARNING: These callbacks are intended for advance users<br/>
	/// </summary>
	[NativeName(NativeNameType.Delegate, "TraceLogCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void TraceLogCallback([NativeName(NativeNameType.Param, "logLevel")] [NativeName(NativeNameType.Type, "int")] int logLevel, [NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] byte* text, [NativeName(NativeNameType.Param, "args")] [NativeName(NativeNameType.Type, "va_list")] nint args);

	#else
	/// <summary>
	/// Callbacks to hook some internal functions<br/>
	/// WARNING: These callbacks are intended for advance users<br/>
	/// </summary>
	[NativeName(NativeNameType.Delegate, "TraceLogCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void TraceLogCallback([NativeName(NativeNameType.Param, "logLevel")] [NativeName(NativeNameType.Type, "int")] int logLevel, [NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] nint text, [NativeName(NativeNameType.Param, "args")] [NativeName(NativeNameType.Type, "va_list")] nint args);

	#endif

	#if NET5_0_OR_GREATER
	[NativeName(NativeNameType.Delegate, "LoadFileDataCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* LoadFileDataCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] byte* fileName, [NativeName(NativeNameType.Param, "dataSize")] [NativeName(NativeNameType.Type, "int*")] int* dataSize);

	#else
	[NativeName(NativeNameType.Delegate, "LoadFileDataCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate nint LoadFileDataCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] nint fileName, [NativeName(NativeNameType.Param, "dataSize")] [NativeName(NativeNameType.Type, "int*")] nint dataSize);

	#endif

	#if NET5_0_OR_GREATER
	[NativeName(NativeNameType.Delegate, "SaveFileDataCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte SaveFileDataCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] byte* fileName, [NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "void*")] void* data, [NativeName(NativeNameType.Param, "dataSize")] [NativeName(NativeNameType.Type, "int")] int dataSize);

	#else
	[NativeName(NativeNameType.Delegate, "SaveFileDataCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte SaveFileDataCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] nint fileName, [NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "void*")] nint data, [NativeName(NativeNameType.Param, "dataSize")] [NativeName(NativeNameType.Type, "int")] int dataSize);

	#endif

	#if NET5_0_OR_GREATER
	[NativeName(NativeNameType.Delegate, "LoadFileTextCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* LoadFileTextCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] byte* fileName);

	#else
	[NativeName(NativeNameType.Delegate, "LoadFileTextCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate nint LoadFileTextCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] nint fileName);

	#endif

	#if NET5_0_OR_GREATER
	[NativeName(NativeNameType.Delegate, "SaveFileTextCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte SaveFileTextCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] byte* fileName, [NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "char*")] byte* text);

	#else
	[NativeName(NativeNameType.Delegate, "SaveFileTextCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte SaveFileTextCallback([NativeName(NativeNameType.Param, "fileName")] [NativeName(NativeNameType.Type, "const char*")] nint fileName, [NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "char*")] nint text);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// ------------------------------------------------------------------------------------<br/>
	/// Audio Loading and Playing Functions (Module: audio)<br/>
	/// ------------------------------------------------------------------------------------<br/>
	/// </summary>
	[NativeName(NativeNameType.Delegate, "AudioCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void AudioCallback([NativeName(NativeNameType.Param, "bufferData")] [NativeName(NativeNameType.Type, "void*")] void* bufferData, [NativeName(NativeNameType.Param, "frames")] [NativeName(NativeNameType.Type, "unsigned int")] uint frames);

	#else
	/// <summary>
	/// ------------------------------------------------------------------------------------<br/>
	/// Audio Loading and Playing Functions (Module: audio)<br/>
	/// ------------------------------------------------------------------------------------<br/>
	/// </summary>
	[NativeName(NativeNameType.Delegate, "AudioCallback")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void AudioCallback([NativeName(NativeNameType.Param, "bufferData")] [NativeName(NativeNameType.Type, "void*")] nint bufferData, [NativeName(NativeNameType.Param, "frames")] [NativeName(NativeNameType.Type, "unsigned int")] uint frames);

	#endif

}
