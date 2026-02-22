using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000085 RID: 133
	[StructLayout(2)]
	public struct Quaternion
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x00038F00 File Offset: 0x00037100
		// Note: this type is marked as 'beforefieldinit'.
		static Quaternion()
		{
			Il2CppClassPointerStore<Quaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Quaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quaternion>.NativeClassPtr);
			Quaternion.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "x");
			Quaternion.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "y");
			Quaternion.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "z");
			Quaternion.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "w");
			Quaternion.NativeFieldInfoPtr_identityQuaternion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "identityQuaternion");
			Quaternion.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "kEpsilon");
			Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664074);
			Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664075);
			Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664076);
			Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664077);
			Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664078);
			Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664079);
			Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664080);
			Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664081);
			Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664082);
			Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664083);
			Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664084);
			Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664085);
			Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664086);
			Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664087);
			Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664088);
			Quaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664089);
			Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664090);
			Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664091);
			Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664092);
			Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664093);
			Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664094);
			Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664095);
			Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664096);
			Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664097);
			Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664098);
			Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664100);
			Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664101);
			Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664102);
			Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664103);
			Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664104);
			Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100664105);
			Quaternion.FromToRotation_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.FromToRotation_InjectedDelegate>("UnityEngine.Quaternion::FromToRotation_Injected");
			Quaternion.SlerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.SlerpUnclamped_InjectedDelegate>("UnityEngine.Quaternion::SlerpUnclamped_Injected");
			Quaternion.LerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.LerpUnclamped_InjectedDelegate>("UnityEngine.Quaternion::LerpUnclamped_Injected");
			Quaternion.Internal_ToAxisAngleRad_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.Internal_ToAxisAngleRad_InjectedDelegate>("UnityEngine.Quaternion::Internal_ToAxisAngleRad_Injected");
			Quaternion.AngleAxis_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.AngleAxis_InjectedDelegate>("UnityEngine.Quaternion::AngleAxis_Injected");
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00039260 File Offset: 0x00037460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66060, RefRangeEnd = 66062, XrefRangeStart = 66058, XrefRangeEnd = 66060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Inverse(Quaternion rotation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000392A0 File Offset: 0x000374A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66064, RefRangeEnd = 66066, XrefRangeStart = 66062, XrefRangeEnd = 66064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000392FC File Offset: 0x000374FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66068, RefRangeEnd = 66069, XrefRangeStart = 66066, XrefRangeEnd = 66068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00039358 File Offset: 0x00037558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66069, XrefRangeEnd = 66071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00039398 File Offset: 0x00037598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66071, XrefRangeEnd = 66073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000393D8 File Offset: 0x000375D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66073, XrefRangeEnd = 66075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upwards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00039424 File Offset: 0x00037624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66078, RefRangeEnd = 66079, XrefRangeStart = 66075, XrefRangeEnd = 66078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00039464 File Offset: 0x00037664
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 61474, RefRangeEnd = 61587, XrefRangeStart = 61474, XrefRangeEnd = 61587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000394C0 File Offset: 0x000376C0
		public unsafe static Quaternion identity
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 66081, RefRangeEnd = 66094, XrefRangeStart = 66079, XrefRangeEnd = 66081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x000394F0 File Offset: 0x000376F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 66094, RefRangeEnd = 66100, XrefRangeStart = 66094, XrefRangeEnd = 66094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0003953C File Offset: 0x0003773C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 66100, RefRangeEnd = 66108, XrefRangeStart = 66100, XrefRangeEnd = 66100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00039588 File Offset: 0x00037788
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66108, RefRangeEnd = 66111, XrefRangeStart = 66108, XrefRangeEnd = 66108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEqualUsingDot(float dot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000395C8 File Offset: 0x000377C8
		[CallerCount(0)]
		public unsafe static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00039614 File Offset: 0x00037814
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 66111, RefRangeEnd = 66115, XrefRangeStart = 66111, XrefRangeEnd = 66111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00039660 File Offset: 0x00037860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66115, RefRangeEnd = 66118, XrefRangeStart = 66115, XrefRangeEnd = 66115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Dot(Quaternion a, Quaternion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000396AC File Offset: 0x000378AC
		[CallerCount(0)]
		public unsafe static float Angle(Quaternion a, Quaternion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000396F8 File Offset: 0x000378F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66118, XrefRangeEnd = 66121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Internal_MakePositive(Vector3 euler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00039738 File Offset: 0x00037938
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x000094A6 File Offset: 0x000076A6
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 66126, RefRangeEnd = 66137, XrefRangeStart = 66121, XrefRangeEnd = 66126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this = Quaternion.Internal_FromEulerRad(value * 0.017453292f);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00039768 File Offset: 0x00037968
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 66139, RefRangeEnd = 66150, XrefRangeStart = 66137, XrefRangeEnd = 66139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000397C4 File Offset: 0x000379C4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 66152, RefRangeEnd = 66183, XrefRangeStart = 66150, XrefRangeEnd = 66152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(Vector3 euler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00039804 File Offset: 0x00037A04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 66187, RefRangeEnd = 66192, XrefRangeStart = 66183, XrefRangeEnd = 66187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00039834 File Offset: 0x00037A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66192, XrefRangeEnd = 66199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00039878 File Offset: 0x00037A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64935, RefRangeEnd = 64936, XrefRangeStart = 64935, XrefRangeEnd = 64936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Quaternion other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000398B8 File Offset: 0x00037AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66199, XrefRangeEnd = 66200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000398E4 File Offset: 0x00037AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66240, RefRangeEnd = 66241, XrefRangeStart = 66200, XrefRangeEnd = 66240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00039934 File Offset: 0x00037B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66241, XrefRangeEnd = 66243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00039974 File Offset: 0x00037B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66243, XrefRangeEnd = 66245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000399D0 File Offset: 0x00037BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66245, XrefRangeEnd = 66247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00039A2C File Offset: 0x00037C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66247, XrefRangeEnd = 66249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &euler;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00039A6C File Offset: 0x00037C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66249, XrefRangeEnd = 66251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00039AAC File Offset: 0x00037CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66251, XrefRangeEnd = 66253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &upwards;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0000943D File Offset: 0x0000763D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, ref this));
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00039AFC File Offset: 0x00037CFC
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x0000944F File Offset: 0x0000764F
		public unsafe static Quaternion identityQuaternion
		{
			get
			{
				Quaternion quaternion;
				IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*)(&quaternion));
				return quaternion;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*)(&value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00039B18 File Offset: 0x00037D18
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x0000945D File Offset: 0x0000765D
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00039B34 File Offset: 0x00037D34
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			Quaternion quaternion;
			Quaternion.FromToRotation_Injected(ref fromDirection, ref toDirection, out quaternion);
			return quaternion;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00039B50 File Offset: 0x00037D50
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.SlerpUnclamped_Injected(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00039B6C File Offset: 0x00037D6C
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.LerpUnclamped_Injected(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0000946B File Offset: 0x0000766B
		public static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad_Injected(ref q, out axis, out angle);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00039B88 File Offset: 0x00037D88
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			Quaternion quaternion;
			Quaternion.AngleAxis_Injected(angle, ref axis, out quaternion);
			return quaternion;
		}

		// Token: 0x170002EC RID: 748
		public float this[int index]
		{
			get
			{
				float num;
				switch (index)
				{
				case 0:
					num = this.x;
					break;
				case 1:
					num = this.y;
					break;
				case 2:
					num = this.z;
					break;
				case 3:
					num = this.w;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
				return num;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.x = value;
					break;
				case 1:
					this.y = value;
					break;
				case 2:
					this.z = value;
					break;
				case 3:
					this.w = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00009476 File Offset: 0x00007676
		public void Set(float newX, float newY, float newZ, float newW)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
			this.w = newW;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00039C58 File Offset: 0x00037E58
		public void SetLookRotation(Vector3 view)
		{
			Vector3 up = Vector3.up;
			this.SetLookRotation(view, up);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00009496 File Offset: 0x00007696
		public void SetLookRotation(Vector3 view, Vector3 up)
		{
			this = Quaternion.LookRotation(view, up);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000094BF File Offset: 0x000076BF
		public void ToAngleAxis(out float angle, out Vector3 axis)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
			angle *= 57.29578f;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000094DA File Offset: 0x000076DA
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			this = Quaternion.FromToRotation(fromDirection, toDirection);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00039C78 File Offset: 0x00037E78
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			float num = Quaternion.Angle(from, to);
			bool flag = num == 0f;
			Quaternion quaternion;
			if (flag)
			{
				quaternion = to;
			}
			else
			{
				quaternion = Quaternion.SlerpUnclamped(from, to, Mathf.Min(1f, maxDegreesDelta / num));
			}
			return quaternion;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00039CB8 File Offset: 0x00037EB8
		public static Quaternion Normalize(Quaternion q)
		{
			float num = Mathf.Sqrt(Quaternion.Dot(q, q));
			bool flag = num < Mathf.Epsilon;
			Quaternion quaternion;
			if (flag)
			{
				quaternion = Quaternion.identity;
			}
			else
			{
				quaternion = new Quaternion(q.x / num, q.y / num, q.z / num, q.w / num);
			}
			return quaternion;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000094EA File Offset: 0x000076EA
		public void Normalize()
		{
			this = Quaternion.Normalize(this);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00039D10 File Offset: 0x00037F10
		public Quaternion normalized
		{
			get
			{
				return Quaternion.Normalize(this);
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00039D30 File Offset: 0x00037F30
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00039D4C File Offset: 0x00037F4C
		public static Quaternion EulerRotation(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00039D6C File Offset: 0x00037F6C
		public static Quaternion EulerRotation(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000094FE File Offset: 0x000076FE
		public void SetEulerRotation(float x, float y, float z)
		{
			this = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00009514 File Offset: 0x00007714
		public void SetEulerRotation(Vector3 euler)
		{
			this = Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00039D84 File Offset: 0x00037F84
		public Vector3 ToEuler()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00039DA4 File Offset: 0x00037FA4
		public static Quaternion EulerAngles(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00039DC4 File Offset: 0x00037FC4
		public static Quaternion EulerAngles(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00009523 File Offset: 0x00007723
		public void ToAxisAngle(out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00009534 File Offset: 0x00007734
		public void SetEulerAngles(float x, float y, float z)
		{
			this.SetEulerRotation(new Vector3(x, y, z));
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00009546 File Offset: 0x00007746
		public void SetEulerAngles(Vector3 euler)
		{
			this = Quaternion.EulerRotation(euler);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00039DDC File Offset: 0x00037FDC
		public static Vector3 ToEulerAngles(Quaternion rotation)
		{
			return Quaternion.Internal_ToEulerRad(rotation);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00039DF4 File Offset: 0x00037FF4
		public Vector3 ToEulerAngles()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00009555 File Offset: 0x00007755
		public void SetAxisAngle(Vector3 axis, float angle)
		{
			this = Quaternion.AxisAngle(axis, angle);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00039E14 File Offset: 0x00038014
		public static Quaternion AxisAngle(Vector3 axis, float angle)
		{
			return Quaternion.AngleAxis(57.29578f * angle, axis);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00009565 File Offset: 0x00007765
		public static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret)
		{
			Quaternion.FromToRotation_InjectedDelegateField(ref fromDirection, ref toDirection, out ret);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00009574 File Offset: 0x00007774
		public static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			Quaternion.SlerpUnclamped_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00009584 File Offset: 0x00007784
		public static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			Quaternion.LerpUnclamped_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00009594 File Offset: 0x00007794
		public static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad_InjectedDelegateField(ref q, out axis, out angle);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000095A3 File Offset: 0x000077A3
		public static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret)
		{
			Quaternion.AngleAxis_InjectedDelegateField(angle, ref axis, out ret);
		}

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr_identityQuaternion;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04000AD6 RID: 2774
		[FieldOffset(0)]
		public float x;

		// Token: 0x04000AD7 RID: 2775
		[FieldOffset(4)]
		public float y;

		// Token: 0x04000AD8 RID: 2776
		[FieldOffset(8)]
		public float z;

		// Token: 0x04000AD9 RID: 2777
		[FieldOffset(12)]
		public float w;

		// Token: 0x04000ADA RID: 2778
		private static readonly Quaternion.FromToRotation_InjectedDelegate FromToRotation_InjectedDelegateField;

		// Token: 0x04000ADB RID: 2779
		private static readonly Quaternion.SlerpUnclamped_InjectedDelegate SlerpUnclamped_InjectedDelegateField;

		// Token: 0x04000ADC RID: 2780
		private static readonly Quaternion.LerpUnclamped_InjectedDelegate LerpUnclamped_InjectedDelegateField;

		// Token: 0x04000ADD RID: 2781
		private static readonly Quaternion.Internal_ToAxisAngleRad_InjectedDelegate Internal_ToAxisAngleRad_InjectedDelegateField;

		// Token: 0x04000ADE RID: 2782
		private static readonly Quaternion.AngleAxis_InjectedDelegate AngleAxis_InjectedDelegateField;

		// Token: 0x0200074D RID: 1869
		// (Invoke) Token: 0x06002C5D RID: 11357
		private delegate void FromToRotation_InjectedDelegate(IntPtr fromDirection, IntPtr toDirection, [Out] IntPtr ret);

		// Token: 0x0200074E RID: 1870
		// (Invoke) Token: 0x06002C5F RID: 11359
		private delegate void SlerpUnclamped_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x0200074F RID: 1871
		// (Invoke) Token: 0x06002C61 RID: 11361
		private delegate void LerpUnclamped_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x02000750 RID: 1872
		// (Invoke) Token: 0x06002C63 RID: 11363
		private delegate void Internal_ToAxisAngleRad_InjectedDelegate(IntPtr q, [Out] IntPtr axis, [Out] IntPtr angle);

		// Token: 0x02000751 RID: 1873
		// (Invoke) Token: 0x06002C65 RID: 11365
		private delegate void AngleAxis_InjectedDelegate(float angle, IntPtr axis, [Out] IntPtr ret);
	}
}
