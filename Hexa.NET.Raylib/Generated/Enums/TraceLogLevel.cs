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
	/// Trace log level<br/>
	/// NOTE: Organized by priority level<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "TraceLogLevel")]
	[Flags]
	public enum TraceLogLevel : int
	{
		/// <summary>
		/// Display all logs<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_ALL")]
		[NativeName(NativeNameType.Value, "0")]
		All = unchecked(0),

		/// <summary>
		/// Trace logging, intended for internal use only<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_TRACE")]
		[NativeName(NativeNameType.Value, "1")]
		Trace = unchecked(1),

		/// <summary>
		/// Debug logging, used for internal debugging, it should be disabled on release builds<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_DEBUG")]
		[NativeName(NativeNameType.Value, "2")]
		Debug = unchecked(2),

		/// <summary>
		/// Info logging, used for program execution info<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_INFO")]
		[NativeName(NativeNameType.Value, "3")]
		Info = unchecked(3),

		/// <summary>
		/// Warning logging, used on recoverable failures<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_WARNING")]
		[NativeName(NativeNameType.Value, "4")]
		Warning = unchecked(4),

		/// <summary>
		/// Error logging, used on unrecoverable failures<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_ERROR")]
		[NativeName(NativeNameType.Value, "5")]
		Error = unchecked(5),

		/// <summary>
		/// Fatal logging, used to abort program: exit(EXIT_FAILURE)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_FATAL")]
		[NativeName(NativeNameType.Value, "6")]
		Fatal = unchecked(6),

		/// <summary>
		/// Disable logging<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LOG_NONE")]
		[NativeName(NativeNameType.Value, "7")]
		None = unchecked(7),
	}
}
