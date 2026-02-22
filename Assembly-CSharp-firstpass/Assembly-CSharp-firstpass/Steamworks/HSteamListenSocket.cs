using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002ED RID: 749
	[Serializable]
	[StructLayout(2)]
	public struct HSteamListenSocket
	{
		// Token: 0x06002B3F RID: 11071 RVA: 0x000B9794 File Offset: 0x000B7994
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamListenSocket()
		{
			Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HSteamListenSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr);
			HSteamListenSocket.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, "Invalid");
			HSteamListenSocket.NativeFieldInfoPtr_m_HSteamListenSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, "m_HSteamListenSocket");
			HSteamListenSocket.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668884);
			HSteamListenSocket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668885);
			HSteamListenSocket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668886);
			HSteamListenSocket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668887);
			HSteamListenSocket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamListenSocket_HSteamListenSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668888);
			HSteamListenSocket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamListenSocket_HSteamListenSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668889);
			HSteamListenSocket.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamListenSocket_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668890);
			HSteamListenSocket.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamListenSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668891);
			HSteamListenSocket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamListenSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668892);
			HSteamListenSocket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamListenSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, 100668893);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000B98B4 File Offset: 0x000B7AB4
		[CallerCount(0)]
		public unsafe HSteamListenSocket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000B98E8 File Offset: 0x000B7AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000B9914 File Offset: 0x000B7B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210892, XrefRangeEnd = 210897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000B9958 File Offset: 0x000B7B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000B9988 File Offset: 0x000B7B88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamListenSocket x, HSteamListenSocket y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamListenSocket_HSteamListenSocket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000B99D4 File Offset: 0x000B7BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210897, XrefRangeEnd = 210900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HSteamListenSocket x, HSteamListenSocket y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamListenSocket_HSteamListenSocket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000B9A20 File Offset: 0x000B7C20
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HSteamListenSocket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamListenSocket_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000B9A60 File Offset: 0x000B7C60
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(HSteamListenSocket that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamListenSocket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000B9AA0 File Offset: 0x000B7CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HSteamListenSocket other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamListenSocket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000B9AE0 File Offset: 0x000B7CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamListenSocket other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamListenSocket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamListenSocket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00011159 File Offset: 0x0000F359
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamListenSocket>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000B9B20 File Offset: 0x000B7D20
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x0001116B File Offset: 0x0000F36B
		public unsafe static HSteamListenSocket Invalid
		{
			get
			{
				HSteamListenSocket hsteamListenSocket;
				IL2CPP.il2cpp_field_static_get_value(HSteamListenSocket.NativeFieldInfoPtr_Invalid, (void*)(&hsteamListenSocket));
				return hsteamListenSocket;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HSteamListenSocket.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002991 RID: 10641
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002992 RID: 10642
		private static readonly IntPtr NativeFieldInfoPtr_m_HSteamListenSocket;

		// Token: 0x04002993 RID: 10643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002994 RID: 10644
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002995 RID: 10645
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002996 RID: 10646
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002997 RID: 10647
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamListenSocket_HSteamListenSocket_0;

		// Token: 0x04002998 RID: 10648
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamListenSocket_HSteamListenSocket_0;

		// Token: 0x04002999 RID: 10649
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamListenSocket_UInt32_0;

		// Token: 0x0400299A RID: 10650
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamListenSocket_0;

		// Token: 0x0400299B RID: 10651
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamListenSocket_0;

		// Token: 0x0400299C RID: 10652
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamListenSocket_0;

		// Token: 0x0400299D RID: 10653
		[FieldOffset(0)]
		public uint m_HSteamListenSocket;
	}
}
