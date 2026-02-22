using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000083 RID: 131
	[StructLayout(2)]
	public struct Matrix4x4
	{
		// Token: 0x06000CBF RID: 3263 RVA: 0x000365C8 File Offset: 0x000347C8
		// Note: this type is marked as 'beforefieldinit'.
		static Matrix4x4()
		{
			Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Matrix4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr);
			Matrix4x4.NativeFieldInfoPtr_m00 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m00");
			Matrix4x4.NativeFieldInfoPtr_m10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m10");
			Matrix4x4.NativeFieldInfoPtr_m20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m20");
			Matrix4x4.NativeFieldInfoPtr_m30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m30");
			Matrix4x4.NativeFieldInfoPtr_m01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m01");
			Matrix4x4.NativeFieldInfoPtr_m11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m11");
			Matrix4x4.NativeFieldInfoPtr_m21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m21");
			Matrix4x4.NativeFieldInfoPtr_m31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m31");
			Matrix4x4.NativeFieldInfoPtr_m02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m02");
			Matrix4x4.NativeFieldInfoPtr_m12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m12");
			Matrix4x4.NativeFieldInfoPtr_m22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m22");
			Matrix4x4.NativeFieldInfoPtr_m32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m32");
			Matrix4x4.NativeFieldInfoPtr_m03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m03");
			Matrix4x4.NativeFieldInfoPtr_m13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m13");
			Matrix4x4.NativeFieldInfoPtr_m23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m23");
			Matrix4x4.NativeFieldInfoPtr_m33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m33");
			Matrix4x4.NativeFieldInfoPtr_zeroMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "zeroMatrix");
			Matrix4x4.NativeFieldInfoPtr_identityMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "identityMatrix");
			Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664014);
			Matrix4x4.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664015);
			Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664016);
			Matrix4x4.NativeMethodInfoPtr_SetTRS_Public_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664017);
			Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664018);
			Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664019);
			Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664020);
			Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664021);
			Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664022);
			Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664023);
			Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664024);
			Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664025);
			Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664026);
			Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664027);
			Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664028);
			Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664029);
			Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664031);
			Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664032);
			Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100664033);
			Matrix4x4.GetRotation_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetRotation_InjectedDelegate>("UnityEngine.Matrix4x4::GetRotation_Injected");
			Matrix4x4.IsIdentity_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.IsIdentity_InjectedDelegate>("UnityEngine.Matrix4x4::IsIdentity_Injected");
			Matrix4x4.GetDeterminant_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetDeterminant_InjectedDelegate>("UnityEngine.Matrix4x4::GetDeterminant_Injected");
			Matrix4x4.ValidTRS_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.ValidTRS_InjectedDelegate>("UnityEngine.Matrix4x4::ValidTRS_Injected");
			Matrix4x4.Inverse_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.Inverse_InjectedDelegate>("UnityEngine.Matrix4x4::Inverse_Injected");
			Matrix4x4.Transpose_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.Transpose_InjectedDelegate>("UnityEngine.Matrix4x4::Transpose_Injected");
			Matrix4x4.Ortho_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.Ortho_InjectedDelegate>("UnityEngine.Matrix4x4::Ortho_Injected");
			Matrix4x4.Perspective_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.Perspective_InjectedDelegate>("UnityEngine.Matrix4x4::Perspective_Injected");
			Matrix4x4.LookAt_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.LookAt_InjectedDelegate>("UnityEngine.Matrix4x4::LookAt_Injected");
			Matrix4x4.Frustum_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.Frustum_InjectedDelegate>("UnityEngine.Matrix4x4::Frustum_Injected");
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00036974 File Offset: 0x00034B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65311, XrefRangeEnd = 65313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLossyScale()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000369A4 File Offset: 0x00034BA4
		public unsafe Vector3 lossyScale
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 65315, RefRangeEnd = 65319, XrefRangeStart = 65313, XrefRangeEnd = 65315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000369D4 File Offset: 0x00034BD4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 65321, RefRangeEnd = 65331, XrefRangeStart = 65319, XrefRangeEnd = 65321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00036A30 File Offset: 0x00034C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65333, RefRangeEnd = 65334, XrefRangeStart = 65331, XrefRangeEnd = 65333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_SetTRS_Public_Void_Vector3_Quaternion_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00036A80 File Offset: 0x00034C80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65336, RefRangeEnd = 65338, XrefRangeStart = 65334, XrefRangeEnd = 65336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00036ACC File Offset: 0x00034CCC
		[CallerCount(0)]
		public unsafe Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref column0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00036B28 File Offset: 0x00034D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65338, XrefRangeEnd = 65346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00036B58 File Offset: 0x00034D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65346, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00036B9C File Offset: 0x00034D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65358, RefRangeEnd = 65359, XrefRangeStart = 65350, XrefRangeEnd = 65358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Matrix4x4 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00036BDC File Offset: 0x00034DDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 65359, RefRangeEnd = 65364, XrefRangeStart = 65359, XrefRangeEnd = 65359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00036C28 File Offset: 0x00034E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65364, XrefRangeEnd = 65368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetColumn(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00036C68 File Offset: 0x00034E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65368, RefRangeEnd = 65370, XrefRangeStart = 65368, XrefRangeEnd = 65368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyPoint(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00036CA8 File Offset: 0x00034EA8
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 65370, RefRangeEnd = 65408, XrefRangeStart = 65370, XrefRangeEnd = 65370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyPoint3x4(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00036CE8 File Offset: 0x00034EE8
		public unsafe static Matrix4x4 identity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 65410, RefRangeEnd = 65411, XrefRangeStart = 65408, XrefRangeEnd = 65410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00036D18 File Offset: 0x00034F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65411, XrefRangeEnd = 65423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00036D44 File Offset: 0x00034F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65533, RefRangeEnd = 65534, XrefRangeStart = 65423, XrefRangeEnd = 65533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00036D94 File Offset: 0x00034F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65534, XrefRangeEnd = 65536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00036DD4 File Offset: 0x00034FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65536, XrefRangeEnd = 65538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00036E30 File Offset: 0x00035030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65538, XrefRangeEnd = 65540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00009156 File Offset: 0x00007356
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00036E7C File Offset: 0x0003507C
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00009168 File Offset: 0x00007368
		public unsafe static Matrix4x4 zeroMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*)(&value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00036E98 File Offset: 0x00035098
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00009176 File Offset: 0x00007376
		public unsafe static Matrix4x4 identityMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*)(&value));
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00036EB4 File Offset: 0x000350B4
		public Quaternion GetRotation()
		{
			Quaternion quaternion;
			Matrix4x4.GetRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00009184 File Offset: 0x00007384
		public bool IsIdentity()
		{
			return Matrix4x4.IsIdentity_Injected(ref this);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0000918C File Offset: 0x0000738C
		public float GetDeterminant()
		{
			return Matrix4x4.GetDeterminant_Injected(ref this);
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00036ECC File Offset: 0x000350CC
		public Quaternion rotation
		{
			get
			{
				return this.GetRotation();
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00036EE4 File Offset: 0x000350E4
		public bool isIdentity
		{
			get
			{
				return this.IsIdentity();
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00036EFC File Offset: 0x000350FC
		public float determinant
		{
			get
			{
				return this.GetDeterminant();
			}
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00009194 File Offset: 0x00007394
		public bool ValidTRS()
		{
			return Matrix4x4.ValidTRS_Injected(ref this);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00036F14 File Offset: 0x00035114
		public static float Determinant(Matrix4x4 m)
		{
			return m.determinant;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00036F30 File Offset: 0x00035130
		public static Matrix4x4 Inverse(Matrix4x4 m)
		{
			Matrix4x4 matrix4x;
			Matrix4x4.Inverse_Injected(ref m, out matrix4x);
			return matrix4x;
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00036F48 File Offset: 0x00035148
		public Matrix4x4 inverse
		{
			get
			{
				return Matrix4x4.Inverse(this);
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00036F68 File Offset: 0x00035168
		public static Matrix4x4 Transpose(Matrix4x4 m)
		{
			Matrix4x4 matrix4x;
			Matrix4x4.Transpose_Injected(ref m, out matrix4x);
			return matrix4x;
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00036F80 File Offset: 0x00035180
		public Matrix4x4 transpose
		{
			get
			{
				return Matrix4x4.Transpose(this);
			}
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00036FA0 File Offset: 0x000351A0
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			Matrix4x4 matrix4x;
			Matrix4x4.Ortho_Injected(left, right, bottom, top, zNear, zFar, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00036FC0 File Offset: 0x000351C0
		public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
		{
			Matrix4x4 matrix4x;
			Matrix4x4.Perspective_Injected(fov, aspect, zNear, zFar, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00036FDC File Offset: 0x000351DC
		public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
		{
			Matrix4x4 matrix4x;
			Matrix4x4.LookAt_Injected(ref from, ref to, ref up, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00036FF8 File Offset: 0x000351F8
		public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			Matrix4x4 matrix4x;
			Matrix4x4.Frustum_Injected(left, right, bottom, top, zNear, zFar, out matrix4x);
			return matrix4x;
		}

		// Token: 0x170002CA RID: 714
		public float this[int row, int column]
		{
			get
			{
				return this[row + column * 4];
			}
			set
			{
				this[row + column * 4] = value;
			}
		}

		// Token: 0x170002CB RID: 715
		public float this[int index]
		{
			get
			{
				float num;
				switch (index)
				{
				case 0:
					num = this.m00;
					break;
				case 1:
					num = this.m10;
					break;
				case 2:
					num = this.m20;
					break;
				case 3:
					num = this.m30;
					break;
				case 4:
					num = this.m01;
					break;
				case 5:
					num = this.m11;
					break;
				case 6:
					num = this.m21;
					break;
				case 7:
					num = this.m31;
					break;
				case 8:
					num = this.m02;
					break;
				case 9:
					num = this.m12;
					break;
				case 10:
					num = this.m22;
					break;
				case 11:
					num = this.m32;
					break;
				case 12:
					num = this.m03;
					break;
				case 13:
					num = this.m13;
					break;
				case 14:
					num = this.m23;
					break;
				case 15:
					num = this.m33;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
				return num;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.m00 = value;
					break;
				case 1:
					this.m10 = value;
					break;
				case 2:
					this.m20 = value;
					break;
				case 3:
					this.m30 = value;
					break;
				case 4:
					this.m01 = value;
					break;
				case 5:
					this.m11 = value;
					break;
				case 6:
					this.m21 = value;
					break;
				case 7:
					this.m31 = value;
					break;
				case 8:
					this.m02 = value;
					break;
				case 9:
					this.m12 = value;
					break;
				case 10:
					this.m22 = value;
					break;
				case 11:
					this.m32 = value;
					break;
				case 12:
					this.m03 = value;
					break;
				case 13:
					this.m13 = value;
					break;
				case 14:
					this.m23 = value;
					break;
				case 15:
					this.m33 = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00037240 File Offset: 0x00035440
		public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector)
		{
			Vector4 vector2;
			vector2.x = lhs.m00 * vector.x + lhs.m01 * vector.y + lhs.m02 * vector.z + lhs.m03 * vector.w;
			vector2.y = lhs.m10 * vector.x + lhs.m11 * vector.y + lhs.m12 * vector.z + lhs.m13 * vector.w;
			vector2.z = lhs.m20 * vector.x + lhs.m21 * vector.y + lhs.m22 * vector.z + lhs.m23 * vector.w;
			vector2.w = lhs.m30 * vector.x + lhs.m31 * vector.y + lhs.m32 * vector.z + lhs.m33 * vector.w;
			return vector2;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0003734C File Offset: 0x0003554C
		public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return lhs.GetColumn(0) == rhs.GetColumn(0) && lhs.GetColumn(1) == rhs.GetColumn(1) && lhs.GetColumn(2) == rhs.GetColumn(2) && lhs.GetColumn(3) == rhs.GetColumn(3);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000373BC File Offset: 0x000355BC
		public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000373D8 File Offset: 0x000355D8
		public Vector4 GetRow(int index)
		{
			Vector4 vector;
			switch (index)
			{
			case 0:
				vector = new Vector4(this.m00, this.m01, this.m02, this.m03);
				break;
			case 1:
				vector = new Vector4(this.m10, this.m11, this.m12, this.m13);
				break;
			case 2:
				vector = new Vector4(this.m20, this.m21, this.m22, this.m23);
				break;
			case 3:
				vector = new Vector4(this.m30, this.m31, this.m32, this.m33);
				break;
			default:
				throw new IndexOutOfRangeException("Invalid row index!");
			}
			return vector;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000091AC File Offset: 0x000073AC
		public void SetColumn(int index, Vector4 column)
		{
			this[0, index] = column.x;
			this[1, index] = column.y;
			this[2, index] = column.z;
			this[3, index] = column.w;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000091EB File Offset: 0x000073EB
		public void SetRow(int index, Vector4 row)
		{
			this[index, 0] = row.x;
			this[index, 1] = row.y;
			this[index, 2] = row.z;
			this[index, 3] = row.w;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00037494 File Offset: 0x00035694
		public Vector3 MultiplyVector(Vector3 vector)
		{
			Vector3 vector2;
			vector2.x = this.m00 * vector.x + this.m01 * vector.y + this.m02 * vector.z;
			vector2.y = this.m10 * vector.x + this.m11 * vector.y + this.m12 * vector.z;
			vector2.z = this.m20 * vector.x + this.m21 * vector.y + this.m22 * vector.z;
			return vector2;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00037538 File Offset: 0x00035738
		public Plane TransformPlane(Plane plane)
		{
			Matrix4x4 inverse = this.inverse;
			float x = plane.normal.x;
			float y = plane.normal.y;
			float z = plane.normal.z;
			float distance = plane.distance;
			float num = inverse.m00 * x + inverse.m10 * y + inverse.m20 * z + inverse.m30 * distance;
			float num2 = inverse.m01 * x + inverse.m11 * y + inverse.m21 * z + inverse.m31 * distance;
			float num3 = inverse.m02 * x + inverse.m12 * y + inverse.m22 * z + inverse.m32 * distance;
			float num4 = inverse.m03 * x + inverse.m13 * y + inverse.m23 * z + inverse.m33 * distance;
			return new Plane(new Vector3(num, num2, num3), num4);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00037630 File Offset: 0x00035830
		public static Matrix4x4 Scale(Vector3 vector)
		{
			Matrix4x4 matrix4x;
			matrix4x.m00 = vector.x;
			matrix4x.m01 = 0f;
			matrix4x.m02 = 0f;
			matrix4x.m03 = 0f;
			matrix4x.m10 = 0f;
			matrix4x.m11 = vector.y;
			matrix4x.m12 = 0f;
			matrix4x.m13 = 0f;
			matrix4x.m20 = 0f;
			matrix4x.m21 = 0f;
			matrix4x.m22 = vector.z;
			matrix4x.m23 = 0f;
			matrix4x.m30 = 0f;
			matrix4x.m31 = 0f;
			matrix4x.m32 = 0f;
			matrix4x.m33 = 1f;
			return matrix4x;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00037708 File Offset: 0x00035908
		public static Matrix4x4 Translate(Vector3 vector)
		{
			Matrix4x4 matrix4x;
			matrix4x.m00 = 1f;
			matrix4x.m01 = 0f;
			matrix4x.m02 = 0f;
			matrix4x.m03 = vector.x;
			matrix4x.m10 = 0f;
			matrix4x.m11 = 1f;
			matrix4x.m12 = 0f;
			matrix4x.m13 = vector.y;
			matrix4x.m20 = 0f;
			matrix4x.m21 = 0f;
			matrix4x.m22 = 1f;
			matrix4x.m23 = vector.z;
			matrix4x.m30 = 0f;
			matrix4x.m31 = 0f;
			matrix4x.m32 = 0f;
			matrix4x.m33 = 1f;
			return matrix4x;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000377E0 File Offset: 0x000359E0
		public static Matrix4x4 Rotate(Quaternion q)
		{
			float num = q.x * 2f;
			float num2 = q.y * 2f;
			float num3 = q.z * 2f;
			float num4 = q.x * num;
			float num5 = q.y * num2;
			float num6 = q.z * num3;
			float num7 = q.x * num2;
			float num8 = q.x * num3;
			float num9 = q.y * num3;
			float num10 = q.w * num;
			float num11 = q.w * num2;
			float num12 = q.w * num3;
			Matrix4x4 matrix4x;
			matrix4x.m00 = 1f - (num5 + num6);
			matrix4x.m10 = num7 + num12;
			matrix4x.m20 = num8 - num11;
			matrix4x.m30 = 0f;
			matrix4x.m01 = num7 - num12;
			matrix4x.m11 = 1f - (num4 + num6);
			matrix4x.m21 = num9 + num10;
			matrix4x.m31 = 0f;
			matrix4x.m02 = num8 + num11;
			matrix4x.m12 = num9 - num10;
			matrix4x.m22 = 1f - (num4 + num5);
			matrix4x.m32 = 0f;
			matrix4x.m03 = 0f;
			matrix4x.m13 = 0f;
			matrix4x.m23 = 0f;
			matrix4x.m33 = 1f;
			return matrix4x;
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00037948 File Offset: 0x00035B48
		public static Matrix4x4 zero
		{
			get
			{
				return Matrix4x4.zeroMatrix;
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00037960 File Offset: 0x00035B60
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0000922A File Offset: 0x0000742A
		public static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret)
		{
			Matrix4x4.GetRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00009238 File Offset: 0x00007438
		public static bool IsIdentity_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.IsIdentity_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00009245 File Offset: 0x00007445
		public static float GetDeterminant_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.GetDeterminant_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00009252 File Offset: 0x00007452
		public static bool ValidTRS_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.ValidTRS_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0000925F File Offset: 0x0000745F
		public static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
		{
			Matrix4x4.Inverse_InjectedDelegateField(ref m, out ret);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0000926D File Offset: 0x0000746D
		public static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
		{
			Matrix4x4.Transpose_InjectedDelegateField(ref m, out ret);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0000927B File Offset: 0x0000747B
		public static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			Matrix4x4.Ortho_InjectedDelegateField(left, right, bottom, top, zNear, zFar, out ret);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00009291 File Offset: 0x00007491
		public static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret)
		{
			Matrix4x4.Perspective_InjectedDelegateField(fov, aspect, zNear, zFar, out ret);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000092A3 File Offset: 0x000074A3
		public static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret)
		{
			Matrix4x4.LookAt_InjectedDelegateField(ref from, ref to, ref up, out ret);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000092B3 File Offset: 0x000074B3
		public static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			Matrix4x4.Frustum_InjectedDelegateField(left, right, bottom, top, zNear, zFar, out ret);
		}

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_m00;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_m10;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_m20;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_m30;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_m01;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_m11;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr_m21;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_m31;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_m02;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_m12;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_m22;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_m32;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_m03;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_m13;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_m23;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_m33;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_zeroMatrix;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_identityMatrix;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_SetTRS_Public_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x04000A59 RID: 2649
		[FieldOffset(0)]
		public float m00;

		// Token: 0x04000A5A RID: 2650
		[FieldOffset(4)]
		public float m10;

		// Token: 0x04000A5B RID: 2651
		[FieldOffset(8)]
		public float m20;

		// Token: 0x04000A5C RID: 2652
		[FieldOffset(12)]
		public float m30;

		// Token: 0x04000A5D RID: 2653
		[FieldOffset(16)]
		public float m01;

		// Token: 0x04000A5E RID: 2654
		[FieldOffset(20)]
		public float m11;

		// Token: 0x04000A5F RID: 2655
		[FieldOffset(24)]
		public float m21;

		// Token: 0x04000A60 RID: 2656
		[FieldOffset(28)]
		public float m31;

		// Token: 0x04000A61 RID: 2657
		[FieldOffset(32)]
		public float m02;

		// Token: 0x04000A62 RID: 2658
		[FieldOffset(36)]
		public float m12;

		// Token: 0x04000A63 RID: 2659
		[FieldOffset(40)]
		public float m22;

		// Token: 0x04000A64 RID: 2660
		[FieldOffset(44)]
		public float m32;

		// Token: 0x04000A65 RID: 2661
		[FieldOffset(48)]
		public float m03;

		// Token: 0x04000A66 RID: 2662
		[FieldOffset(52)]
		public float m13;

		// Token: 0x04000A67 RID: 2663
		[FieldOffset(56)]
		public float m23;

		// Token: 0x04000A68 RID: 2664
		[FieldOffset(60)]
		public float m33;

		// Token: 0x04000A69 RID: 2665
		private static readonly Matrix4x4.GetRotation_InjectedDelegate GetRotation_InjectedDelegateField;

		// Token: 0x04000A6A RID: 2666
		private static readonly Matrix4x4.IsIdentity_InjectedDelegate IsIdentity_InjectedDelegateField;

		// Token: 0x04000A6B RID: 2667
		private static readonly Matrix4x4.GetDeterminant_InjectedDelegate GetDeterminant_InjectedDelegateField;

		// Token: 0x04000A6C RID: 2668
		private static readonly Matrix4x4.ValidTRS_InjectedDelegate ValidTRS_InjectedDelegateField;

		// Token: 0x04000A6D RID: 2669
		private static readonly Matrix4x4.Inverse_InjectedDelegate Inverse_InjectedDelegateField;

		// Token: 0x04000A6E RID: 2670
		private static readonly Matrix4x4.Transpose_InjectedDelegate Transpose_InjectedDelegateField;

		// Token: 0x04000A6F RID: 2671
		private static readonly Matrix4x4.Ortho_InjectedDelegate Ortho_InjectedDelegateField;

		// Token: 0x04000A70 RID: 2672
		private static readonly Matrix4x4.Perspective_InjectedDelegate Perspective_InjectedDelegateField;

		// Token: 0x04000A71 RID: 2673
		private static readonly Matrix4x4.LookAt_InjectedDelegate LookAt_InjectedDelegateField;

		// Token: 0x04000A72 RID: 2674
		private static readonly Matrix4x4.Frustum_InjectedDelegate Frustum_InjectedDelegateField;

		// Token: 0x0200073E RID: 1854
		// (Invoke) Token: 0x06002C3F RID: 11327
		private delegate void GetRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200073F RID: 1855
		// (Invoke) Token: 0x06002C41 RID: 11329
		private delegate bool IsIdentity_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000740 RID: 1856
		// (Invoke) Token: 0x06002C43 RID: 11331
		private delegate float GetDeterminant_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000741 RID: 1857
		// (Invoke) Token: 0x06002C45 RID: 11333
		private delegate bool ValidTRS_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000742 RID: 1858
		// (Invoke) Token: 0x06002C47 RID: 11335
		private delegate void Inverse_InjectedDelegate(IntPtr m, [Out] IntPtr ret);

		// Token: 0x02000743 RID: 1859
		// (Invoke) Token: 0x06002C49 RID: 11337
		private delegate void Transpose_InjectedDelegate(IntPtr m, [Out] IntPtr ret);

		// Token: 0x02000744 RID: 1860
		// (Invoke) Token: 0x06002C4B RID: 11339
		private delegate void Ortho_InjectedDelegate(float left, float right, float bottom, float top, float zNear, float zFar, [Out] IntPtr ret);

		// Token: 0x02000745 RID: 1861
		// (Invoke) Token: 0x06002C4D RID: 11341
		private delegate void Perspective_InjectedDelegate(float fov, float aspect, float zNear, float zFar, [Out] IntPtr ret);

		// Token: 0x02000746 RID: 1862
		// (Invoke) Token: 0x06002C4F RID: 11343
		private delegate void LookAt_InjectedDelegate(IntPtr from, IntPtr to, IntPtr up, [Out] IntPtr ret);

		// Token: 0x02000747 RID: 1863
		// (Invoke) Token: 0x06002C51 RID: 11345
		private delegate void Frustum_InjectedDelegate(float left, float right, float bottom, float top, float zNear, float zFar, [Out] IntPtr ret);
	}
}
