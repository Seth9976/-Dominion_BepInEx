using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E9 RID: 745
	[Serializable]
	[StructLayout(2)]
	public struct SNetSocket_t
	{
		// Token: 0x06002B22 RID: 11042 RVA: 0x000B9048 File Offset: 0x000B7248
		// Note: this type is marked as 'beforefieldinit'.
		static SNetSocket_t()
		{
			Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SNetSocket_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr);
			SNetSocket_t.NativeFieldInfoPtr_m_SNetSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, "m_SNetSocket");
			SNetSocket_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668866);
			SNetSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668867);
			SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668868);
			SNetSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668869);
			SNetSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668870);
			SNetSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668871);
			SNetSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SNetSocket_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668872);
			SNetSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668873);
			SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668874);
			SNetSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100668875);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000B9154 File Offset: 0x000B7354
		[CallerCount(0)]
		public unsafe SNetSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000B9188 File Offset: 0x000B7388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000B91B4 File Offset: 0x000B73B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210881, XrefRangeEnd = 210884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000B91F8 File Offset: 0x000B73F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000B9228 File Offset: 0x000B7428
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000B9274 File Offset: 0x000B7474
		[CallerCount(0)]
		public unsafe static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000B92C0 File Offset: 0x000B74C0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SNetSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SNetSocket_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000B9300 File Offset: 0x000B7500
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(SNetSocket_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000B9340 File Offset: 0x000B7540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SNetSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000B9380 File Offset: 0x000B7580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SNetSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000110F3 File Offset: 0x0000F2F3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeFieldInfoPtr_m_SNetSocket;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0;

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SNetSocket_t_UInt32_0;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetSocket_t_0;

		// Token: 0x04002986 RID: 10630
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetSocket_t_0;

		// Token: 0x04002987 RID: 10631
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetSocket_t_0;

		// Token: 0x04002988 RID: 10632
		[FieldOffset(0)]
		public uint m_SNetSocket;
	}
}
