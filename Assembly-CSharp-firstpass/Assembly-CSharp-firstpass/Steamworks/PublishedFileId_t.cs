using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F8 RID: 760
	[Serializable]
	[StructLayout(2)]
	public struct PublishedFileId_t
	{
		// Token: 0x06002BE4 RID: 11236 RVA: 0x000BBD80 File Offset: 0x000B9F80
		// Note: this type is marked as 'beforefieldinit'.
		static PublishedFileId_t()
		{
			Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PublishedFileId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr);
			PublishedFileId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, "Invalid");
			PublishedFileId_t.NativeFieldInfoPtr_m_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, "m_PublishedFileId");
			PublishedFileId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668976);
			PublishedFileId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668977);
			PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668978);
			PublishedFileId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668979);
			PublishedFileId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668980);
			PublishedFileId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668981);
			PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileId_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668982);
			PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668983);
			PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668984);
			PublishedFileId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100668985);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000BBEA0 File Offset: 0x000BA0A0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PublishedFileId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000BBED4 File Offset: 0x000BA0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000BBF00 File Offset: 0x000BA100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211009, XrefRangeEnd = 211014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000BBF44 File Offset: 0x000BA144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000BBF74 File Offset: 0x000BA174
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000BBFC0 File Offset: 0x000BA1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211014, XrefRangeEnd = 211017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000BC00C File Offset: 0x000BA20C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator PublishedFileId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileId_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000BC04C File Offset: 0x000BA24C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(PublishedFileId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000BC08C File Offset: 0x000BA28C
		[CallerCount(0)]
		public unsafe bool Equals(PublishedFileId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x000BC0CC File Offset: 0x000BA2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(PublishedFileId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000114E3 File Offset: 0x0000F6E3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000BC10C File Offset: 0x000BA30C
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x000114F5 File Offset: 0x0000F6F5
		public unsafe static PublishedFileId_t Invalid
		{
			get
			{
				PublishedFileId_t publishedFileId_t;
				IL2CPP.il2cpp_field_static_get_value(PublishedFileId_t.NativeFieldInfoPtr_Invalid, (void*)(&publishedFileId_t));
				return publishedFileId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PublishedFileId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeFieldInfoPtr_m_PublishedFileId;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileId_t_UInt64_0;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileId_t_0;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_t_0;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_t_0;

		// Token: 0x04002A21 RID: 10785
		[FieldOffset(0)]
		public ulong m_PublishedFileId;
	}
}
