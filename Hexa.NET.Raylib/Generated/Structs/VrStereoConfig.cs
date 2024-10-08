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
	/// VrStereoConfig, VR stereo rendering configuration for simulator<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "VrStereoConfig")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VrStereoConfig
	{
		/// <summary>
		/// VR projection matrices (per eye)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "projection")]
		[NativeName(NativeNameType.Type, "Matrix[2]")]
		public Matrix4x4 Projection_0;
		public Matrix4x4 Projection_1;

		/// <summary>
		/// VR view offset matrices (per eye)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "viewOffset")]
		[NativeName(NativeNameType.Type, "Matrix[2]")]
		public Matrix4x4 ViewOffset_0;
		public Matrix4x4 ViewOffset_1;

		/// <summary>
		/// VR left lens center<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "leftLensCenter")]
		[NativeName(NativeNameType.Type, "float[2]")]
		public float LeftLensCenter_0;
		public float LeftLensCenter_1;

		/// <summary>
		/// VR right lens center<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "rightLensCenter")]
		[NativeName(NativeNameType.Type, "float[2]")]
		public float RightLensCenter_0;
		public float RightLensCenter_1;

		/// <summary>
		/// VR left screen center<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "leftScreenCenter")]
		[NativeName(NativeNameType.Type, "float[2]")]
		public float LeftScreenCenter_0;
		public float LeftScreenCenter_1;

		/// <summary>
		/// VR right screen center<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "rightScreenCenter")]
		[NativeName(NativeNameType.Type, "float[2]")]
		public float RightScreenCenter_0;
		public float RightScreenCenter_1;

		/// <summary>
		/// VR distortion scale<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "scale")]
		[NativeName(NativeNameType.Type, "float[2]")]
		public float Scale_0;
		public float Scale_1;

		/// <summary>
		/// VR distortion scale in<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "scaleIn")]
		[NativeName(NativeNameType.Type, "float[2]")]
		public float ScaleIn_0;
		public float ScaleIn_1;


		public unsafe VrStereoConfig(Matrix4x4* projection = default, Matrix4x4* viewOffset = default, float* leftLensCenter = default, float* rightLensCenter = default, float* leftScreenCenter = default, float* rightScreenCenter = default, float* scale = default, float* scaleIn = default)
		{
			if (projection != default(Matrix4x4*))
			{
				Projection_0 = projection[0];
				Projection_1 = projection[1];
			}
			if (viewOffset != default(Matrix4x4*))
			{
				ViewOffset_0 = viewOffset[0];
				ViewOffset_1 = viewOffset[1];
			}
			if (leftLensCenter != default(float*))
			{
				LeftLensCenter_0 = leftLensCenter[0];
				LeftLensCenter_1 = leftLensCenter[1];
			}
			if (rightLensCenter != default(float*))
			{
				RightLensCenter_0 = rightLensCenter[0];
				RightLensCenter_1 = rightLensCenter[1];
			}
			if (leftScreenCenter != default(float*))
			{
				LeftScreenCenter_0 = leftScreenCenter[0];
				LeftScreenCenter_1 = leftScreenCenter[1];
			}
			if (rightScreenCenter != default(float*))
			{
				RightScreenCenter_0 = rightScreenCenter[0];
				RightScreenCenter_1 = rightScreenCenter[1];
			}
			if (scale != default(float*))
			{
				Scale_0 = scale[0];
				Scale_1 = scale[1];
			}
			if (scaleIn != default(float*))
			{
				ScaleIn_0 = scaleIn[0];
				ScaleIn_1 = scaleIn[1];
			}
		}

		public unsafe VrStereoConfig(Span<Matrix4x4> projection = default, Span<Matrix4x4> viewOffset = default, Span<float> leftLensCenter = default, Span<float> rightLensCenter = default, Span<float> leftScreenCenter = default, Span<float> rightScreenCenter = default, Span<float> scale = default, Span<float> scaleIn = default)
		{
			if (projection != default(Span<Matrix4x4>))
			{
				Projection_0 = projection[0];
				Projection_1 = projection[1];
			}
			if (viewOffset != default(Span<Matrix4x4>))
			{
				ViewOffset_0 = viewOffset[0];
				ViewOffset_1 = viewOffset[1];
			}
			if (leftLensCenter != default(Span<float>))
			{
				LeftLensCenter_0 = leftLensCenter[0];
				LeftLensCenter_1 = leftLensCenter[1];
			}
			if (rightLensCenter != default(Span<float>))
			{
				RightLensCenter_0 = rightLensCenter[0];
				RightLensCenter_1 = rightLensCenter[1];
			}
			if (leftScreenCenter != default(Span<float>))
			{
				LeftScreenCenter_0 = leftScreenCenter[0];
				LeftScreenCenter_1 = leftScreenCenter[1];
			}
			if (rightScreenCenter != default(Span<float>))
			{
				RightScreenCenter_0 = rightScreenCenter[0];
				RightScreenCenter_1 = rightScreenCenter[1];
			}
			if (scale != default(Span<float>))
			{
				Scale_0 = scale[0];
				Scale_1 = scale[1];
			}
			if (scaleIn != default(Span<float>))
			{
				ScaleIn_0 = scaleIn[0];
				ScaleIn_1 = scaleIn[1];
			}
		}


		/// <summary>
		/// VR projection matrices (per eye)<br/>
		/// </summary>
		public unsafe Span<Matrix4x4> Projection
		
		{
			get
			{
				fixed (Matrix4x4* p = &this.Projection_0)
				{
					return new Span<Matrix4x4>(p, 2);
				}
			}
		}
		/// <summary>
		/// VR view offset matrices (per eye)<br/>
		/// </summary>
		public unsafe Span<Matrix4x4> ViewOffset
		
		{
			get
			{
				fixed (Matrix4x4* p = &this.ViewOffset_0)
				{
					return new Span<Matrix4x4>(p, 2);
				}
			}
		}
	}

}
