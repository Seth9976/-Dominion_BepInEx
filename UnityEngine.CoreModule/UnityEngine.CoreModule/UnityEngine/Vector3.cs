using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000084 RID: 132
	[StructLayout(2)]
	public struct Vector3
	{
		// Token: 0x06000D03 RID: 3331 RVA: 0x0003797C File Offset: 0x00035B7C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3()
		{
			Il2CppClassPointerStore<Vector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3>.NativeClassPtr);
			Vector3.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "kEpsilon");
			Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "kEpsilonNormalSqrt");
			Vector3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "x");
			Vector3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "y");
			Vector3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "z");
			Vector3.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "zeroVector");
			Vector3.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "oneVector");
			Vector3.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "upVector");
			Vector3.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "downVector");
			Vector3.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "leftVector");
			Vector3.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "rightVector");
			Vector3.NativeFieldInfoPtr_forwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "forwardVector");
			Vector3.NativeFieldInfoPtr_backVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "backVector");
			Vector3.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "positiveInfinityVector");
			Vector3.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "negativeInfinityVector");
			Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664034);
			Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664035);
			Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664036);
			Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664037);
			Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664038);
			Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664039);
			Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664040);
			Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664041);
			Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664042);
			Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664043);
			Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664044);
			Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664045);
			Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664046);
			Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664047);
			Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664048);
			Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664049);
			Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664050);
			Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664051);
			Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664052);
			Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664053);
			Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664054);
			Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664055);
			Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664056);
			Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664057);
			Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664058);
			Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664059);
			Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664060);
			Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664061);
			Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664062);
			Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664063);
			Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664064);
			Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664065);
			Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664066);
			Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664067);
			Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664068);
			Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664069);
			Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664070);
			Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664071);
			Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100664072);
			Vector3.OrthoNormalize2DelegateField = IL2CPP.ResolveICall<Vector3.OrthoNormalize2Delegate>("UnityEngine.Vector3::OrthoNormalize2");
			Vector3.OrthoNormalize3DelegateField = IL2CPP.ResolveICall<Vector3.OrthoNormalize3Delegate>("UnityEngine.Vector3::OrthoNormalize3");
			Vector3.Slerp_InjectedDelegateField = IL2CPP.ResolveICall<Vector3.Slerp_InjectedDelegate>("UnityEngine.Vector3::Slerp_Injected");
			Vector3.SlerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Vector3.SlerpUnclamped_InjectedDelegate>("UnityEngine.Vector3::SlerpUnclamped_Injected");
			Vector3.RotateTowards_InjectedDelegateField = IL2CPP.ResolveICall<Vector3.RotateTowards_InjectedDelegate>("UnityEngine.Vector3::RotateTowards_Injected");
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00037E30 File Offset: 0x00036030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65540, XrefRangeEnd = 65541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Lerp(Vector3 a, Vector3 b, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00037E8C File Offset: 0x0003608C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65544, RefRangeEnd = 65545, XrefRangeStart = 65541, XrefRangeEnd = 65544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00037EF4 File Offset: 0x000360F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65551, RefRangeEnd = 65552, XrefRangeStart = 65545, XrefRangeEnd = 65551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002D9 RID: 729
		public unsafe float this[int index]
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 65552, RefRangeEnd = 65568, XrefRangeStart = 65552, XrefRangeEnd = 65552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 65568, RefRangeEnd = 65569, XrefRangeStart = 65568, XrefRangeEnd = 65568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00037FF8 File Offset: 0x000361F8
		[CallerCount(0)]
		public unsafe Vector3(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00038048 File Offset: 0x00036248
		[CallerCount(0)]
		public unsafe Vector3(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00038088 File Offset: 0x00036288
		[CallerCount(0)]
		public unsafe static Vector3 Scale(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000380D4 File Offset: 0x000362D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65569, RefRangeEnd = 65571, XrefRangeStart = 65569, XrefRangeEnd = 65569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00038120 File Offset: 0x00036320
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65574, RefRangeEnd = 65577, XrefRangeStart = 65571, XrefRangeEnd = 65574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00038150 File Offset: 0x00036350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65577, XrefRangeEnd = 65580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00038194 File Offset: 0x00036394
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 65580, RefRangeEnd = 65585, XrefRangeStart = 65580, XrefRangeEnd = 65580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Vector3 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x000381D4 File Offset: 0x000363D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65593, RefRangeEnd = 65594, XrefRangeStart = 65585, XrefRangeEnd = 65593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Normalize(Vector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00038214 File Offset: 0x00036414
		public unsafe Vector3 normalized
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 65601, RefRangeEnd = 65614, XrefRangeStart = 65594, XrefRangeEnd = 65601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00038244 File Offset: 0x00036444
		[CallerCount(0)]
		public unsafe static float Dot(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00038290 File Offset: 0x00036490
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65619, RefRangeEnd = 65648, XrefRangeStart = 65614, XrefRangeEnd = 65619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Distance(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000382DC File Offset: 0x000364DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65648, XrefRangeEnd = 65651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Magnitude(Vector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0003831C File Offset: 0x0003651C
		public unsafe float magnitude
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 65656, RefRangeEnd = 65686, XrefRangeStart = 65651, XrefRangeEnd = 65656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0003834C File Offset: 0x0003654C
		public unsafe float sqrMagnitude
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 65686, RefRangeEnd = 65688, XrefRangeStart = 65686, XrefRangeEnd = 65686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0003837C File Offset: 0x0003657C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65688, XrefRangeEnd = 65691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000383C8 File Offset: 0x000365C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65691, XrefRangeEnd = 65694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00038414 File Offset: 0x00036614
		public unsafe static Vector3 zero
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 65696, RefRangeEnd = 65824, XrefRangeStart = 65694, XrefRangeEnd = 65696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00038444 File Offset: 0x00036644
		public unsafe static Vector3 one
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 65826, RefRangeEnd = 65863, XrefRangeStart = 65824, XrefRangeEnd = 65826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00038474 File Offset: 0x00036674
		public unsafe static Vector3 forward
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 65865, RefRangeEnd = 65870, XrefRangeStart = 65863, XrefRangeEnd = 65865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x000384A4 File Offset: 0x000366A4
		public unsafe static Vector3 back
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 65872, RefRangeEnd = 65875, XrefRangeStart = 65870, XrefRangeEnd = 65872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000384D4 File Offset: 0x000366D4
		public unsafe static Vector3 up
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 65877, RefRangeEnd = 65883, XrefRangeStart = 65875, XrefRangeEnd = 65877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00038504 File Offset: 0x00036704
		public unsafe static Vector3 down
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65883, XrefRangeEnd = 65885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00038534 File Offset: 0x00036734
		public unsafe static Vector3 left
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65885, XrefRangeEnd = 65887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00038564 File Offset: 0x00036764
		public unsafe static Vector3 right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 65889, RefRangeEnd = 65890, XrefRangeStart = 65887, XrefRangeEnd = 65889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00038594 File Offset: 0x00036794
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 65890, RefRangeEnd = 65950, XrefRangeStart = 65890, XrefRangeEnd = 65890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator +(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000385E0 File Offset: 0x000367E0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 65950, RefRangeEnd = 65969, XrefRangeStart = 65950, XrefRangeEnd = 65950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator -(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0003862C File Offset: 0x0003682C
		[CallerCount(0)]
		public unsafe static Vector3 operator -(Vector3 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0003866C File Offset: 0x0003686C
		[CallerCount(0)]
		public unsafe static Vector3 operator *(Vector3 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x000386B8 File Offset: 0x000368B8
		[CallerCount(0)]
		public unsafe static Vector3 operator *(float d, Vector3 a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00038704 File Offset: 0x00036904
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 65969, RefRangeEnd = 65981, XrefRangeStart = 65969, XrefRangeEnd = 65969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator /(Vector3 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00038750 File Offset: 0x00036950
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65981, RefRangeEnd = 65987, XrefRangeStart = 65981, XrefRangeEnd = 65981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0003879C File Offset: 0x0003699C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 65987, RefRangeEnd = 66006, XrefRangeStart = 65987, XrefRangeEnd = 65987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000387E8 File Offset: 0x000369E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66018, RefRangeEnd = 66020, XrefRangeStart = 66006, XrefRangeEnd = 66018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00038814 File Offset: 0x00036A14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 66052, RefRangeEnd = 66058, XrefRangeStart = 66020, XrefRangeEnd = 66052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000092C9 File Offset: 0x000074C9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3>.NativeClassPtr, ref this));
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00038864 File Offset: 0x00036A64
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x000092DB File Offset: 0x000074DB
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00038880 File Offset: 0x00036A80
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x000092E9 File Offset: 0x000074E9
		public unsafe static float kEpsilonNormalSqrt
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0003889C File Offset: 0x00036A9C
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x000092F7 File Offset: 0x000074F7
		public unsafe static Vector3 zeroVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x000388B8 File Offset: 0x00036AB8
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00009305 File Offset: 0x00007505
		public unsafe static Vector3 oneVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_oneVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x000388D4 File Offset: 0x00036AD4
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00009313 File Offset: 0x00007513
		public unsafe static Vector3 upVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_upVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_upVector, (void*)(&value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000388F0 File Offset: 0x00036AF0
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00009321 File Offset: 0x00007521
		public unsafe static Vector3 downVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_downVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_downVector, (void*)(&value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0003890C File Offset: 0x00036B0C
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x0000932F File Offset: 0x0000752F
		public unsafe static Vector3 leftVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_leftVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_leftVector, (void*)(&value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00038928 File Offset: 0x00036B28
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x0000933D File Offset: 0x0000753D
		public unsafe static Vector3 rightVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_rightVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_rightVector, (void*)(&value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00038944 File Offset: 0x00036B44
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x0000934B File Offset: 0x0000754B
		public unsafe static Vector3 forwardVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*)(&value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00038960 File Offset: 0x00036B60
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00009359 File Offset: 0x00007559
		public unsafe static Vector3 backVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_backVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_backVector, (void*)(&value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0003897C File Offset: 0x00036B7C
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00009367 File Offset: 0x00007567
		public unsafe static Vector3 positiveInfinityVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00038998 File Offset: 0x00036B98
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x00009375 File Offset: 0x00007575
		public unsafe static Vector3 negativeInfinityVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000389B4 File Offset: 0x00036BB4
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			Vector3 vector;
			Vector3.Slerp_Injected(ref a, ref b, t, out vector);
			return vector;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000389D0 File Offset: 0x00036BD0
		public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			Vector3 vector;
			Vector3.SlerpUnclamped_Injected(ref a, ref b, t, out vector);
			return vector;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00009383 File Offset: 0x00007583
		public static void OrthoNormalize2(ref Vector3 a, ref Vector3 b)
		{
			Vector3.OrthoNormalize2DelegateField(ref a, ref b);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00009391 File Offset: 0x00007591
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
			Vector3.OrthoNormalize2(ref normal, ref tangent);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0000939C File Offset: 0x0000759C
		public static void OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c)
		{
			Vector3.OrthoNormalize3DelegateField(ref a, ref b, ref c);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000093AB File Offset: 0x000075AB
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
		{
			Vector3.OrthoNormalize3(ref normal, ref tangent, ref binormal);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000389EC File Offset: 0x00036BEC
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			Vector3 vector;
			Vector3.RotateTowards_Injected(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out vector);
			return vector;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00038A08 File Offset: 0x00036C08
		public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00038A64 File Offset: 0x00036C64
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			float num = target.x - current.x;
			float num2 = target.y - current.y;
			float num3 = target.z - current.z;
			float num4 = num * num + num2 * num2 + num3 * num3;
			bool flag = num4 == 0f || (maxDistanceDelta >= 0f && num4 <= maxDistanceDelta * maxDistanceDelta);
			Vector3 vector;
			if (flag)
			{
				vector = target;
			}
			else
			{
				float num5 = (float)Math.Sqrt((double)num4);
				vector = new Vector3(current.x + num / num5 * maxDistanceDelta, current.y + num2 / num5 * maxDistanceDelta, current.z + num3 / num5 * maxDistanceDelta);
			}
			return vector;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00038B10 File Offset: 0x00036D10
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000093B7 File Offset: 0x000075B7
		public void Set(float newX, float newY, float newZ)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000093CF File Offset: 0x000075CF
		public void Scale(Vector3 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00038B34 File Offset: 0x00036D34
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			float num = -2f * Vector3.Dot(inNormal, inDirection);
			return new Vector3(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y, num * inNormal.z + inDirection.z);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00038B88 File Offset: 0x00036D88
		public void Normalize()
		{
			float num = Vector3.Magnitude(this);
			bool flag = num > 1E-05f;
			if (flag)
			{
				this /= num;
			}
			else
			{
				this = Vector3.zero;
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00038BD0 File Offset: 0x00036DD0
		public static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			float num = Vector3.Dot(onNormal, onNormal);
			bool flag = num < Mathf.Epsilon;
			Vector3 vector2;
			if (flag)
			{
				vector2 = Vector3.zero;
			}
			else
			{
				float num2 = Vector3.Dot(vector, onNormal);
				vector2 = new Vector3(onNormal.x * num2 / num, onNormal.y * num2 / num, onNormal.z * num2 / num);
			}
			return vector2;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00038C2C File Offset: 0x00036E2C
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			float num = Vector3.Dot(planeNormal, planeNormal);
			bool flag = num < Mathf.Epsilon;
			Vector3 vector2;
			if (flag)
			{
				vector2 = vector;
			}
			else
			{
				float num2 = Vector3.Dot(vector, planeNormal);
				vector2 = new Vector3(vector.x - planeNormal.x * num2 / num, vector.y - planeNormal.y * num2 / num, vector.z - planeNormal.z * num2 / num);
			}
			return vector2;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00038C98 File Offset: 0x00036E98
		public static float Angle(Vector3 from, Vector3 to)
		{
			float num = (float)Math.Sqrt((double)(from.sqrMagnitude * to.sqrMagnitude));
			bool flag = num < 1E-15f;
			float num2;
			if (flag)
			{
				num2 = 0f;
			}
			else
			{
				float num3 = Mathf.Clamp(Vector3.Dot(from, to) / num, -1f, 1f);
				num2 = (float)Math.Acos((double)num3) * 57.29578f;
			}
			return num2;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00038CFC File Offset: 0x00036EFC
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			float num = Vector3.Angle(from, to);
			float num2 = from.y * to.z - from.z * to.y;
			float num3 = from.z * to.x - from.x * to.z;
			float num4 = from.x * to.y - from.y * to.x;
			float num5 = Mathf.Sign(axis.x * num2 + axis.y * num3 + axis.z * num4);
			return num * num5;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00038D94 File Offset: 0x00036F94
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			float sqrMagnitude = vector.sqrMagnitude;
			bool flag = sqrMagnitude > maxLength * maxLength;
			Vector3 vector2;
			if (flag)
			{
				float num = (float)Math.Sqrt((double)sqrMagnitude);
				float num2 = vector.x / num;
				float num3 = vector.y / num;
				float num4 = vector.z / num;
				vector2 = new Vector3(num2 * maxLength, num3 * maxLength, num4 * maxLength);
			}
			else
			{
				vector2 = vector;
			}
			return vector2;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00038DF8 File Offset: 0x00036FF8
		public static float SqrMagnitude(Vector3 vector)
		{
			return vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00038E34 File Offset: 0x00037034
		public static Vector3 positiveInfinity
		{
			get
			{
				return Vector3.positiveInfinityVector;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00038E4C File Offset: 0x0003704C
		public static Vector3 negativeInfinity
		{
			get
			{
				return Vector3.negativeInfinityVector;
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00038E64 File Offset: 0x00037064
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00038E80 File Offset: 0x00037080
		public static Vector3 fwd
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00038EA8 File Offset: 0x000370A8
		public static float AngleBetween(Vector3 from, Vector3 to)
		{
			return (float)Math.Acos((double)Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00038EE4 File Offset: 0x000370E4
		public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
		{
			return Vector3.ProjectOnPlane(fromThat, excludeThis);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0000940B File Offset: 0x0000760B
		public static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret)
		{
			Vector3.Slerp_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0000941B File Offset: 0x0000761B
		public static void SlerpUnclamped_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret)
		{
			Vector3.SlerpUnclamped_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0000942B File Offset: 0x0000762B
		public static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret)
		{
			Vector3.RotateTowards_InjectedDelegateField(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out ret);
		}

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_upVector;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_downVector;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_leftVector;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_rightVector;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr_forwardVector;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr_backVector;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000AA9 RID: 2729
		[FieldOffset(0)]
		public float x;

		// Token: 0x04000AAA RID: 2730
		[FieldOffset(4)]
		public float y;

		// Token: 0x04000AAB RID: 2731
		[FieldOffset(8)]
		public float z;

		// Token: 0x04000AAC RID: 2732
		private static readonly Vector3.OrthoNormalize2Delegate OrthoNormalize2DelegateField;

		// Token: 0x04000AAD RID: 2733
		private static readonly Vector3.OrthoNormalize3Delegate OrthoNormalize3DelegateField;

		// Token: 0x04000AAE RID: 2734
		private static readonly Vector3.Slerp_InjectedDelegate Slerp_InjectedDelegateField;

		// Token: 0x04000AAF RID: 2735
		private static readonly Vector3.SlerpUnclamped_InjectedDelegate SlerpUnclamped_InjectedDelegateField;

		// Token: 0x04000AB0 RID: 2736
		private static readonly Vector3.RotateTowards_InjectedDelegate RotateTowards_InjectedDelegateField;

		// Token: 0x02000748 RID: 1864
		// (Invoke) Token: 0x06002C53 RID: 11347
		private delegate void OrthoNormalize2Delegate(IntPtr a, IntPtr b);

		// Token: 0x02000749 RID: 1865
		// (Invoke) Token: 0x06002C55 RID: 11349
		private delegate void OrthoNormalize3Delegate(IntPtr a, IntPtr b, IntPtr c);

		// Token: 0x0200074A RID: 1866
		// (Invoke) Token: 0x06002C57 RID: 11351
		private delegate void Slerp_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x0200074B RID: 1867
		// (Invoke) Token: 0x06002C59 RID: 11353
		private delegate void SlerpUnclamped_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x0200074C RID: 1868
		// (Invoke) Token: 0x06002C5B RID: 11355
		private delegate void RotateTowards_InjectedDelegate(IntPtr current, IntPtr target, float maxRadiansDelta, float maxMagnitudeDelta, [Out] IntPtr ret);
	}
}
