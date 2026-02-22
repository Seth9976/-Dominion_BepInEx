using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002EE RID: 750
	[Serializable]
	[StructLayout(2)]
	public struct HSteamNetConnection
	{
		// Token: 0x06002B4D RID: 11085 RVA: 0x000B9B3C File Offset: 0x000B7D3C
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamNetConnection()
		{
			Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HSteamNetConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr);
			HSteamNetConnection.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, "Invalid");
			HSteamNetConnection.NativeFieldInfoPtr_m_HSteamNetConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, "m_HSteamNetConnection");
			HSteamNetConnection.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668895);
			HSteamNetConnection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668896);
			HSteamNetConnection.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668897);
			HSteamNetConnection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668898);
			HSteamNetConnection.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetConnection_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668899);
			HSteamNetConnection.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetConnection_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668900);
			HSteamNetConnection.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamNetConnection_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668901);
			HSteamNetConnection.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668902);
			HSteamNetConnection.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668903);
			HSteamNetConnection.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, 100668904);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000B9C5C File Offset: 0x000B7E5C
		[CallerCount(0)]
		public unsafe HSteamNetConnection(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000B9C90 File Offset: 0x000B7E90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000B9CBC File Offset: 0x000B7EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210900, XrefRangeEnd = 210905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000B9D00 File Offset: 0x000B7F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000B9D30 File Offset: 0x000B7F30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamNetConnection x, HSteamNetConnection y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetConnection_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x000B9D7C File Offset: 0x000B7F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210905, XrefRangeEnd = 210908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HSteamNetConnection x, HSteamNetConnection y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetConnection_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000B9DC8 File Offset: 0x000B7FC8
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HSteamNetConnection(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamNetConnection_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000B9E08 File Offset: 0x000B8008
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(HSteamNetConnection that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000B9E48 File Offset: 0x000B8048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HSteamNetConnection other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetConnection_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000B9E88 File Offset: 0x000B8088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamNetConnection other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetConnection.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetConnection_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x00011179 File Offset: 0x0000F379
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamNetConnection>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000B9EC8 File Offset: 0x000B80C8
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x0001118B File Offset: 0x0000F38B
		public unsafe static HSteamNetConnection Invalid
		{
			get
			{
				HSteamNetConnection hsteamNetConnection;
				IL2CPP.il2cpp_field_static_get_value(HSteamNetConnection.NativeFieldInfoPtr_Invalid, (void*)(&hsteamNetConnection));
				return hsteamNetConnection;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HSteamNetConnection.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400299F RID: 10655
		private static readonly IntPtr NativeFieldInfoPtr_m_HSteamNetConnection;

		// Token: 0x040029A0 RID: 10656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040029A1 RID: 10657
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040029A2 RID: 10658
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040029A3 RID: 10659
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040029A4 RID: 10660
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetConnection_HSteamNetConnection_0;

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetConnection_HSteamNetConnection_0;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamNetConnection_UInt32_0;

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamNetConnection_0;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetConnection_0;

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetConnection_0;

		// Token: 0x040029AA RID: 10666
		[FieldOffset(0)]
		public uint m_HSteamNetConnection;
	}
}
