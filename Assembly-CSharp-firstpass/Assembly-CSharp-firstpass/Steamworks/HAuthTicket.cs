using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D3 RID: 723
	[Serializable]
	[StructLayout(2)]
	public struct HAuthTicket
	{
		// Token: 0x06002A00 RID: 10752 RVA: 0x000B45C0 File Offset: 0x000B27C0
		// Note: this type is marked as 'beforefieldinit'.
		static HAuthTicket()
		{
			Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HAuthTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr);
			HAuthTicket.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, "Invalid");
			HAuthTicket.NativeFieldInfoPtr_m_HAuthTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, "m_HAuthTicket");
			HAuthTicket.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668655);
			HAuthTicket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668656);
			HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668657);
			HAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668658);
			HAuthTicket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668659);
			HAuthTicket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668660);
			HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_HAuthTicket_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668661);
			HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668662);
			HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668663);
			HAuthTicket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100668664);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x000B46E0 File Offset: 0x000B28E0
		[CallerCount(0)]
		public unsafe HAuthTicket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x000B4714 File Offset: 0x000B2914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210649, XrefRangeEnd = 210650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x000B4740 File Offset: 0x000B2940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210652, XrefRangeEnd = 210657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x000B4784 File Offset: 0x000B2984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210657, XrefRangeEnd = 210658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000B47B4 File Offset: 0x000B29B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x000B4800 File Offset: 0x000B2A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210665, XrefRangeEnd = 210668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000B484C File Offset: 0x000B2A4C
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HAuthTicket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_HAuthTicket_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x000B488C File Offset: 0x000B2A8C
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(HAuthTicket that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000B48CC File Offset: 0x000B2ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HAuthTicket other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000B490C File Offset: 0x000B2B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210746, XrefRangeEnd = 210747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HAuthTicket other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00010D51 File Offset: 0x0000EF51
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, ref this));
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x000B494C File Offset: 0x000B2B4C
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x00010D63 File Offset: 0x0000EF63
		public unsafe static HAuthTicket Invalid
		{
			get
			{
				HAuthTicket hauthTicket;
				IL2CPP.il2cpp_field_static_get_value(HAuthTicket.NativeFieldInfoPtr_Invalid, (void*)(&hauthTicket));
				return hauthTicket;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HAuthTicket.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeFieldInfoPtr_m_HAuthTicket;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0;

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HAuthTicket_UInt32_0;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HAuthTicket_0;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0;

		// Token: 0x04002883 RID: 10371
		[FieldOffset(0)]
		public uint m_HAuthTicket;
	}
}
