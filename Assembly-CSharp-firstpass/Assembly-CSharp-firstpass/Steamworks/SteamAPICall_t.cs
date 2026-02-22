using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000304 RID: 772
	[Serializable]
	[StructLayout(2)]
	public struct SteamAPICall_t
	{
		// Token: 0x06002C88 RID: 11400 RVA: 0x000BE900 File Offset: 0x000BCB00
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPICall_t()
		{
			Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPICall_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr);
			SteamAPICall_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, "Invalid");
			SteamAPICall_t.NativeFieldInfoPtr_m_SteamAPICall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, "m_SteamAPICall");
			SteamAPICall_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669106);
			SteamAPICall_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669107);
			SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669108);
			SteamAPICall_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669109);
			SteamAPICall_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669110);
			SteamAPICall_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669111);
			SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamAPICall_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669112);
			SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669113);
			SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669114);
			SteamAPICall_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100669115);
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000BEA20 File Offset: 0x000BCC20
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamAPICall_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000BEA54 File Offset: 0x000BCC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x000BEA80 File Offset: 0x000BCC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211096, XrefRangeEnd = 211101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000BEAC4 File Offset: 0x000BCCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000BEAF4 File Offset: 0x000BCCF4
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000BEB40 File Offset: 0x000BCD40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211104, RefRangeEnd = 211107, XrefRangeStart = 211101, XrefRangeEnd = 211104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x000BEB8C File Offset: 0x000BCD8C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamAPICall_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamAPICall_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000BEBCC File Offset: 0x000BCDCC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamAPICall_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000BEC0C File Offset: 0x000BCE0C
		[CallerCount(0)]
		public unsafe bool Equals(SteamAPICall_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamAPICall_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000BEC4C File Offset: 0x000BCE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamAPICall_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamAPICall_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00011647 File Offset: 0x0000F847
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x000BEC8C File Offset: 0x000BCE8C
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x00011659 File Offset: 0x0000F859
		public unsafe static SteamAPICall_t Invalid
		{
			get
			{
				SteamAPICall_t steamAPICall_t;
				IL2CPP.il2cpp_field_static_get_value(SteamAPICall_t.NativeFieldInfoPtr_Invalid, (void*)(&steamAPICall_t));
				return steamAPICall_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAPICall_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002AB0 RID: 10928
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamAPICall;

		// Token: 0x04002AB1 RID: 10929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002AB2 RID: 10930
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamAPICall_t_UInt64_0;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamAPICall_t_0;

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamAPICall_t_0;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamAPICall_t_0;

		// Token: 0x04002ABB RID: 10939
		[FieldOffset(0)]
		public ulong m_SteamAPICall;
	}
}
