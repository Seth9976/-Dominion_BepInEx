using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E5 RID: 741
	[Serializable]
	[StructLayout(2)]
	public struct SteamItemInstanceID_t
	{
		// Token: 0x06002AEE RID: 10990 RVA: 0x000B8274 File Offset: 0x000B6474
		// Note: this type is marked as 'beforefieldinit'.
		static SteamItemInstanceID_t()
		{
			Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamItemInstanceID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr);
			SteamItemInstanceID_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, "Invalid");
			SteamItemInstanceID_t.NativeFieldInfoPtr_m_SteamItemInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, "m_SteamItemInstanceID");
			SteamItemInstanceID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668824);
			SteamItemInstanceID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668825);
			SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668826);
			SteamItemInstanceID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668827);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668828);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668829);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemInstanceID_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668830);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668831);
			SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668832);
			SteamItemInstanceID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100668833);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000B8394 File Offset: 0x000B6594
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamItemInstanceID_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000B83C8 File Offset: 0x000B65C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x000B83F4 File Offset: 0x000B65F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210844, XrefRangeEnd = 210849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000B8438 File Offset: 0x000B6638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000B8468 File Offset: 0x000B6668
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000B84B4 File Offset: 0x000B66B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210849, XrefRangeEnd = 210852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x000B8500 File Offset: 0x000B6700
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamItemInstanceID_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemInstanceID_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000B8540 File Offset: 0x000B6740
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamItemInstanceID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000B8580 File Offset: 0x000B6780
		[CallerCount(0)]
		public unsafe bool Equals(SteamItemInstanceID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemInstanceID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x000B85C0 File Offset: 0x000B67C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamItemInstanceID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemInstanceID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00011081 File Offset: 0x0000F281
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x000B8600 File Offset: 0x000B6800
		// (set) Token: 0x06002AFB RID: 11003 RVA: 0x00011093 File Offset: 0x0000F293
		public unsafe static SteamItemInstanceID_t Invalid
		{
			get
			{
				SteamItemInstanceID_t steamItemInstanceID_t;
				IL2CPP.il2cpp_field_static_get_value(SteamItemInstanceID_t.NativeFieldInfoPtr_Invalid, (void*)(&steamItemInstanceID_t));
				return steamItemInstanceID_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamItemInstanceID_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamItemInstanceID;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemInstanceID_t_UInt64_0;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamItemInstanceID_t_0;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemInstanceID_t_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemInstanceID_t_0;

		// Token: 0x04002958 RID: 10584
		[FieldOffset(0)]
		public ulong m_SteamItemInstanceID;
	}
}
