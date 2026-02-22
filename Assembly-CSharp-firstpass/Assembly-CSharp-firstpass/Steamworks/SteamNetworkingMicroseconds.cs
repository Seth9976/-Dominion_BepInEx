using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F5 RID: 757
	[Serializable]
	[StructLayout(2)]
	public struct SteamNetworkingMicroseconds
	{
		// Token: 0x06002BC0 RID: 11200 RVA: 0x000BB318 File Offset: 0x000B9518
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingMicroseconds()
		{
			Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingMicroseconds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr);
			SteamNetworkingMicroseconds.NativeFieldInfoPtr_m_SteamNetworkingMicroseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, "m_SteamNetworkingMicroseconds");
			SteamNetworkingMicroseconds.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668946);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668947);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668948);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668949);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamNetworkingMicroseconds_SteamNetworkingMicroseconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668950);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamNetworkingMicroseconds_SteamNetworkingMicroseconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668951);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamNetworkingMicroseconds_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668952);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_SteamNetworkingMicroseconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668953);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingMicroseconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668954);
			SteamNetworkingMicroseconds.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamNetworkingMicroseconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, 100668955);
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000BB424 File Offset: 0x000B9624
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingMicroseconds(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000BB458 File Offset: 0x000B9658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210997, XrefRangeEnd = 210998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000BB484 File Offset: 0x000B9684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210998, XrefRangeEnd = 211001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000BB4C8 File Offset: 0x000B96C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211001, XrefRangeEnd = 211002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000BB4F8 File Offset: 0x000B96F8
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamNetworkingMicroseconds_SteamNetworkingMicroseconds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000BB544 File Offset: 0x000B9744
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamNetworkingMicroseconds_SteamNetworkingMicroseconds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000BB590 File Offset: 0x000B9790
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamNetworkingMicroseconds(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamNetworkingMicroseconds_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000BB5D0 File Offset: 0x000B97D0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator long(SteamNetworkingMicroseconds that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_SteamNetworkingMicroseconds_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000BB610 File Offset: 0x000B9810
		[CallerCount(0)]
		public unsafe bool Equals(SteamNetworkingMicroseconds other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingMicroseconds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000BB650 File Offset: 0x000B9850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211002, XrefRangeEnd = 211003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamNetworkingMicroseconds other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMicroseconds.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamNetworkingMicroseconds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000114AD File Offset: 0x0000F6AD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingMicroseconds>.NativeClassPtr, ref this));
		}

		// Token: 0x040029F1 RID: 10737
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamNetworkingMicroseconds;

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamNetworkingMicroseconds_SteamNetworkingMicroseconds_0;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamNetworkingMicroseconds_SteamNetworkingMicroseconds_0;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamNetworkingMicroseconds_Int64_0;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_SteamNetworkingMicroseconds_0;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingMicroseconds_0;

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamNetworkingMicroseconds_0;

		// Token: 0x040029FC RID: 10748
		[FieldOffset(0)]
		public long m_SteamNetworkingMicroseconds;
	}
}
