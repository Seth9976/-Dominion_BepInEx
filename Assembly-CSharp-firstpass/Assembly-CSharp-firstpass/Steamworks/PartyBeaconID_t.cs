using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000301 RID: 769
	[Serializable]
	[StructLayout(2)]
	public struct PartyBeaconID_t
	{
		// Token: 0x06002C60 RID: 11360 RVA: 0x000BDE38 File Offset: 0x000BC038
		// Note: this type is marked as 'beforefieldinit'.
		static PartyBeaconID_t()
		{
			Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PartyBeaconID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr);
			PartyBeaconID_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, "Invalid");
			PartyBeaconID_t.NativeFieldInfoPtr_m_PartyBeaconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, "m_PartyBeaconID");
			PartyBeaconID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669074);
			PartyBeaconID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669075);
			PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669076);
			PartyBeaconID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669077);
			PartyBeaconID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669078);
			PartyBeaconID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669079);
			PartyBeaconID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PartyBeaconID_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669080);
			PartyBeaconID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669081);
			PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669082);
			PartyBeaconID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100669083);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000BDF58 File Offset: 0x000BC158
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartyBeaconID_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000BDF8C File Offset: 0x000BC18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x000BDFB8 File Offset: 0x000BC1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211077, XrefRangeEnd = 211082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000BDFFC File Offset: 0x000BC1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000BE02C File Offset: 0x000BC22C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000BE078 File Offset: 0x000BC278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211082, XrefRangeEnd = 211085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x000BE0C4 File Offset: 0x000BC2C4
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator PartyBeaconID_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PartyBeaconID_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000BE104 File Offset: 0x000BC304
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(PartyBeaconID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000BE144 File Offset: 0x000BC344
		[CallerCount(0)]
		public unsafe bool Equals(PartyBeaconID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PartyBeaconID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000BE184 File Offset: 0x000BC384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(PartyBeaconID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PartyBeaconID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000115F5 File Offset: 0x0000F7F5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000BE1C4 File Offset: 0x000BC3C4
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x00011607 File Offset: 0x0000F807
		public unsafe static PartyBeaconID_t Invalid
		{
			get
			{
				PartyBeaconID_t partyBeaconID_t;
				IL2CPP.il2cpp_field_static_get_value(PartyBeaconID_t.NativeFieldInfoPtr_Invalid, (void*)(&partyBeaconID_t));
				return partyBeaconID_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartyBeaconID_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeFieldInfoPtr_m_PartyBeaconID;

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_PartyBeaconID_t_UInt64_0;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PartyBeaconID_t_0;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PartyBeaconID_t_0;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PartyBeaconID_t_0;

		// Token: 0x04002A95 RID: 10901
		[FieldOffset(0)]
		public ulong m_PartyBeaconID;
	}
}
