using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F6 RID: 758
	[Serializable]
	[StructLayout(2)]
	public struct SteamNetworkingPOPID
	{
		// Token: 0x06002BCC RID: 11212 RVA: 0x000BB690 File Offset: 0x000B9890
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingPOPID()
		{
			Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingPOPID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr);
			SteamNetworkingPOPID.NativeFieldInfoPtr_m_SteamNetworkingPOPID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, "m_SteamNetworkingPOPID");
			SteamNetworkingPOPID.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668956);
			SteamNetworkingPOPID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668957);
			SteamNetworkingPOPID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668958);
			SteamNetworkingPOPID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668959);
			SteamNetworkingPOPID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamNetworkingPOPID_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668960);
			SteamNetworkingPOPID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamNetworkingPOPID_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668961);
			SteamNetworkingPOPID.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamNetworkingPOPID_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668962);
			SteamNetworkingPOPID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668963);
			SteamNetworkingPOPID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668964);
			SteamNetworkingPOPID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, 100668965);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000BB79C File Offset: 0x000B999C
		[CallerCount(0)]
		public unsafe SteamNetworkingPOPID(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000BB7D0 File Offset: 0x000B99D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000BB7FC File Offset: 0x000B99FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211003, XrefRangeEnd = 211006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000BB840 File Offset: 0x000B9A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000BB870 File Offset: 0x000B9A70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamNetworkingPOPID_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000BB8BC File Offset: 0x000B9ABC
		[CallerCount(0)]
		public unsafe static bool operator !=(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamNetworkingPOPID_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000BB908 File Offset: 0x000B9B08
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamNetworkingPOPID(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamNetworkingPOPID_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000BB948 File Offset: 0x000B9B48
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(SteamNetworkingPOPID that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000BB988 File Offset: 0x000B9B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SteamNetworkingPOPID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingPOPID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000BB9C8 File Offset: 0x000B9BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamNetworkingPOPID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingPOPID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamNetworkingPOPID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000114BF File Offset: 0x0000F6BF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingPOPID>.NativeClassPtr, ref this));
		}

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamNetworkingPOPID;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamNetworkingPOPID_SteamNetworkingPOPID_0;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamNetworkingPOPID_SteamNetworkingPOPID_0;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamNetworkingPOPID_UInt32_0;

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SteamNetworkingPOPID_0;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingPOPID_0;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamNetworkingPOPID_0;

		// Token: 0x04002A08 RID: 10760
		[FieldOffset(0)]
		public uint m_SteamNetworkingPOPID;
	}
}
