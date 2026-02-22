using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000300 RID: 768
	[Serializable]
	[StructLayout(2)]
	public struct ManifestId_t
	{
		// Token: 0x06002C52 RID: 11346 RVA: 0x000BDA90 File Offset: 0x000BBC90
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestId_t()
		{
			Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ManifestId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr);
			ManifestId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, "Invalid");
			ManifestId_t.NativeFieldInfoPtr_m_ManifestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, "m_ManifestId");
			ManifestId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669063);
			ManifestId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669064);
			ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669065);
			ManifestId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669066);
			ManifestId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669067);
			ManifestId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669068);
			ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ManifestId_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669069);
			ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669070);
			ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669071);
			ManifestId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100669072);
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000BDBB0 File Offset: 0x000BBDB0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000BDBE4 File Offset: 0x000BBDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000BDC10 File Offset: 0x000BBE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211069, XrefRangeEnd = 211074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000BDC54 File Offset: 0x000BBE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000BDC84 File Offset: 0x000BBE84
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000BDCD0 File Offset: 0x000BBED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211074, XrefRangeEnd = 211077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000BDD1C File Offset: 0x000BBF1C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ManifestId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ManifestId_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000BDD5C File Offset: 0x000BBF5C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(ManifestId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ManifestId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000BDD9C File Offset: 0x000BBF9C
		[CallerCount(0)]
		public unsafe bool Equals(ManifestId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManifestId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000BDDDC File Offset: 0x000BBFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ManifestId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ManifestId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000115D5 File Offset: 0x0000F7D5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000BDE1C File Offset: 0x000BC01C
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x000115E7 File Offset: 0x0000F7E7
		public unsafe static ManifestId_t Invalid
		{
			get
			{
				ManifestId_t manifestId_t;
				IL2CPP.il2cpp_field_static_get_value(ManifestId_t.NativeFieldInfoPtr_Invalid, (void*)(&manifestId_t));
				return manifestId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManifestId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeFieldInfoPtr_m_ManifestId;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ManifestId_t_UInt64_0;

		// Token: 0x04002A85 RID: 10885
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ManifestId_t_0;

		// Token: 0x04002A86 RID: 10886
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManifestId_t_0;

		// Token: 0x04002A87 RID: 10887
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ManifestId_t_0;

		// Token: 0x04002A88 RID: 10888
		[FieldOffset(0)]
		public ulong m_ManifestId;
	}
}
