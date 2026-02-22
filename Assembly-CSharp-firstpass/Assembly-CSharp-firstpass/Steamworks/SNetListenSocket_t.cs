using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E8 RID: 744
	[Serializable]
	[StructLayout(2)]
	public struct SNetListenSocket_t
	{
		// Token: 0x06002B16 RID: 11030 RVA: 0x000B8CD0 File Offset: 0x000B6ED0
		// Note: this type is marked as 'beforefieldinit'.
		static SNetListenSocket_t()
		{
			Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SNetListenSocket_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr);
			SNetListenSocket_t.NativeFieldInfoPtr_m_SNetListenSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, "m_SNetListenSocket");
			SNetListenSocket_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668856);
			SNetListenSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668857);
			SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668858);
			SNetListenSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668859);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668860);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668861);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SNetListenSocket_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668862);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668863);
			SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668864);
			SNetListenSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100668865);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000B8DDC File Offset: 0x000B6FDC
		[CallerCount(0)]
		public unsafe SNetListenSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000B8E10 File Offset: 0x000B7010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000B8E3C File Offset: 0x000B703C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210878, XrefRangeEnd = 210881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000B8E80 File Offset: 0x000B7080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000B8EB0 File Offset: 0x000B70B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000B8EFC File Offset: 0x000B70FC
		[CallerCount(0)]
		public unsafe static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000B8F48 File Offset: 0x000B7148
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SNetListenSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SNetListenSocket_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000B8F88 File Offset: 0x000B7188
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(SNetListenSocket_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000B8FC8 File Offset: 0x000B71C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SNetListenSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000B9008 File Offset: 0x000B7208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SNetListenSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000110E1 File Offset: 0x0000F2E1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeFieldInfoPtr_m_SNetListenSocket;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SNetListenSocket_t_UInt32_0;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetListenSocket_t_0;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0;

		// Token: 0x0400297C RID: 10620
		[FieldOffset(0)]
		public uint m_SNetListenSocket;
	}
}
