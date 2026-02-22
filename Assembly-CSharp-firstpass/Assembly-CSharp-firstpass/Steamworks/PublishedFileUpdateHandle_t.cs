using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F9 RID: 761
	[Serializable]
	[StructLayout(2)]
	public struct PublishedFileUpdateHandle_t
	{
		// Token: 0x06002BF2 RID: 11250 RVA: 0x000BC128 File Offset: 0x000BA328
		// Note: this type is marked as 'beforefieldinit'.
		static PublishedFileUpdateHandle_t()
		{
			Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PublishedFileUpdateHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr);
			PublishedFileUpdateHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, "Invalid");
			PublishedFileUpdateHandle_t.NativeFieldInfoPtr_m_PublishedFileUpdateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, "m_PublishedFileUpdateHandle");
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668987);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668988);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668989);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668990);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668991);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668992);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668993);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668994);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668995);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100668996);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000BC248 File Offset: 0x000BA448
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PublishedFileUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000BC27C File Offset: 0x000BA47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000BC2A8 File Offset: 0x000BA4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211017, XrefRangeEnd = 211022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000BC2EC File Offset: 0x000BA4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000BC31C File Offset: 0x000BA51C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000BC368 File Offset: 0x000BA568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211022, XrefRangeEnd = 211025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000BC3B4 File Offset: 0x000BA5B4
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000BC3F4 File Offset: 0x000BA5F4
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000BC434 File Offset: 0x000BA634
		[CallerCount(0)]
		public unsafe bool Equals(PublishedFileUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000BC474 File Offset: 0x000BA674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(PublishedFileUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x00011503 File Offset: 0x0000F703
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000BC4B4 File Offset: 0x000BA6B4
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x00011515 File Offset: 0x0000F715
		public unsafe static PublishedFileUpdateHandle_t Invalid
		{
			get
			{
				PublishedFileUpdateHandle_t publishedFileUpdateHandle_t;
				IL2CPP.il2cpp_field_static_get_value(PublishedFileUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&publishedFileUpdateHandle_t));
				return publishedFileUpdateHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PublishedFileUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeFieldInfoPtr_m_PublishedFileUpdateHandle;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0;

		// Token: 0x04002A2E RID: 10798
		[FieldOffset(0)]
		public ulong m_PublishedFileUpdateHandle;
	}
}
