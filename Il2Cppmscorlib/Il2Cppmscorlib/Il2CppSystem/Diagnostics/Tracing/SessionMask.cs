using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051E RID: 1310
	[StructLayout(2)]
	public struct SessionMask
	{
		// Token: 0x06004BC6 RID: 19398 RVA: 0x00159DC8 File Offset: 0x00157FC8
		// Note: this type is marked as 'beforefieldinit'.
		static SessionMask()
		{
			Il2CppClassPointerStore<SessionMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "SessionMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionMask>.NativeClassPtr);
			SessionMask.NativeFieldInfoPtr_m_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, "m_mask");
			SessionMask.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674502);
			SessionMask.NativeMethodInfoPtr_IsEqualOrSupersetOf_Public_Boolean_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674503);
			SessionMask.NativeMethodInfoPtr_get_All_Public_Static_get_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674504);
			SessionMask.NativeMethodInfoPtr_FromId_Public_Static_SessionMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674505);
			SessionMask.NativeMethodInfoPtr_ToEventKeywords_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674506);
			SessionMask.NativeMethodInfoPtr_FromEventKeywords_Public_Static_SessionMask_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674507);
			SessionMask.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674508);
			SessionMask.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674509);
			SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674510);
			SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674511);
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00159ED4 File Offset: 0x001580D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373876, RefRangeEnd = 373879, XrefRangeStart = 373876, XrefRangeEnd = 373876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionMask(uint mask = 0U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x00159F08 File Offset: 0x00158108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373879, RefRangeEnd = 373881, XrefRangeStart = 373879, XrefRangeEnd = 373879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEqualOrSupersetOf(SessionMask m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_IsEqualOrSupersetOf_Public_Boolean_SessionMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x00159F48 File Offset: 0x00158148
		public unsafe static SessionMask All
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 22552, RefRangeEnd = 22562, XrefRangeStart = 22552, XrefRangeEnd = 22562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_get_All_Public_Static_get_SessionMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x00159F78 File Offset: 0x00158178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373881, RefRangeEnd = 373882, XrefRangeStart = 373881, XrefRangeEnd = 373881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SessionMask FromId(int perEventSourceSessionId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perEventSourceSessionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_FromId_Public_Static_SessionMask_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x00159FB8 File Offset: 0x001581B8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 373882, RefRangeEnd = 373893, XrefRangeStart = 373882, XrefRangeEnd = 373882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong ToEventKeywords()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_ToEventKeywords_Public_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x00159FE8 File Offset: 0x001581E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373893, RefRangeEnd = 373894, XrefRangeStart = 373893, XrefRangeEnd = 373893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SessionMask FromEventKeywords(ulong m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_FromEventKeywords_Public_Static_SessionMask_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700130B RID: 4875
		public unsafe bool this[int perEventSourceSessionId]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 373894, RefRangeEnd = 373898, XrefRangeStart = 373894, XrefRangeEnd = 373894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref perEventSourceSessionId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 373898, RefRangeEnd = 373900, XrefRangeStart = 373898, XrefRangeEnd = 373898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref perEventSourceSessionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x0015A0A8 File Offset: 0x001582A8
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SessionMask m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SessionMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x0015A0E8 File Offset: 0x001582E8
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(SessionMask m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SessionMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x0001C8AC File Offset: 0x0001AAAC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, ref this));
		}

		// Token: 0x04003D22 RID: 15650
		private static readonly IntPtr NativeFieldInfoPtr_m_mask;

		// Token: 0x04003D23 RID: 15651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04003D24 RID: 15652
		private static readonly IntPtr NativeMethodInfoPtr_IsEqualOrSupersetOf_Public_Boolean_SessionMask_0;

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_SessionMask_0;

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeMethodInfoPtr_FromId_Public_Static_SessionMask_Int32_0;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeMethodInfoPtr_ToEventKeywords_Public_UInt64_0;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeMethodInfoPtr_FromEventKeywords_Public_Static_SessionMask_UInt64_0;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SessionMask_0;

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SessionMask_0;

		// Token: 0x04003D2D RID: 15661
		[FieldOffset(0)]
		public uint m_mask;
	}
}
