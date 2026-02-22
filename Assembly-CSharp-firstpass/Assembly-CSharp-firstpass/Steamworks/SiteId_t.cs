using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000303 RID: 771
	[Serializable]
	[StructLayout(2)]
	public struct SiteId_t
	{
		// Token: 0x06002C7A RID: 11386 RVA: 0x000BE558 File Offset: 0x000BC758
		// Note: this type is marked as 'beforefieldinit'.
		static SiteId_t()
		{
			Il2CppClassPointerStore<SiteId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SiteId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr);
			SiteId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, "Invalid");
			SiteId_t.NativeFieldInfoPtr_m_SiteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, "m_SiteId");
			SiteId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669095);
			SiteId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669096);
			SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669097);
			SiteId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669098);
			SiteId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SiteId_t_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669099);
			SiteId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SiteId_t_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669100);
			SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SiteId_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669101);
			SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669102);
			SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669103);
			SiteId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100669104);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000BE678 File Offset: 0x000BC878
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SiteId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000BE6AC File Offset: 0x000BC8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000BE6D8 File Offset: 0x000BC8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211088, XrefRangeEnd = 211093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000BE71C File Offset: 0x000BC91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000BE74C File Offset: 0x000BC94C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SiteId_t x, SiteId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SiteId_t_SiteId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000BE798 File Offset: 0x000BC998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211093, XrefRangeEnd = 211096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SiteId_t x, SiteId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SiteId_t_SiteId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000BE7E4 File Offset: 0x000BC9E4
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SiteId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SiteId_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000BE824 File Offset: 0x000BCA24
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SiteId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SiteId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000BE864 File Offset: 0x000BCA64
		[CallerCount(0)]
		public unsafe bool Equals(SiteId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SiteId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000BE8A4 File Offset: 0x000BCAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SiteId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SiteId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00011627 File Offset: 0x0000F827
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000BE8E4 File Offset: 0x000BCAE4
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x00011639 File Offset: 0x0000F839
		public unsafe static SiteId_t Invalid
		{
			get
			{
				SiteId_t siteId_t;
				IL2CPP.il2cpp_field_static_get_value(SiteId_t.NativeFieldInfoPtr_Invalid, (void*)(&siteId_t));
				return siteId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SiteId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeFieldInfoPtr_m_SiteId;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SiteId_t_SiteId_t_0;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SiteId_t_SiteId_t_0;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SiteId_t_UInt64_0;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SiteId_t_0;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SiteId_t_0;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SiteId_t_0;

		// Token: 0x04002AAE RID: 10926
		[FieldOffset(0)]
		public ulong m_SiteId;
	}
}
