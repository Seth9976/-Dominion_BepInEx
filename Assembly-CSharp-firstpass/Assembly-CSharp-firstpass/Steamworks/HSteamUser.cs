using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200030B RID: 779
	[Serializable]
	[StructLayout(2)]
	public struct HSteamUser
	{
		// Token: 0x06002CDD RID: 11485 RVA: 0x000C0028 File Offset: 0x000BE228
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamUser()
		{
			Il2CppClassPointerStore<HSteamUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HSteamUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr);
			HSteamUser.NativeFieldInfoPtr_m_HSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, "m_HSteamUser");
			HSteamUser.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669174);
			HSteamUser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669175);
			HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669176);
			HSteamUser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669177);
			HSteamUser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669178);
			HSteamUser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669179);
			HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamUser_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669180);
			HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669181);
			HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669182);
			HSteamUser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100669183);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000C0134 File Offset: 0x000BE334
		[CallerCount(0)]
		public unsafe HSteamUser(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000C0168 File Offset: 0x000BE368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000C0194 File Offset: 0x000BE394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211156, XrefRangeEnd = 211159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000C01D8 File Offset: 0x000BE3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000C0208 File Offset: 0x000BE408
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamUser x, HSteamUser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000C0254 File Offset: 0x000BE454
		[CallerCount(0)]
		public unsafe static bool operator !=(HSteamUser x, HSteamUser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000C02A0 File Offset: 0x000BE4A0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HSteamUser(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamUser_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000C02E0 File Offset: 0x000BE4E0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(HSteamUser that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000C0320 File Offset: 0x000BE520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HSteamUser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x000C0360 File Offset: 0x000BE560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamUser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000116EF File Offset: 0x0000F8EF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, ref this));
		}

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeFieldInfoPtr_m_HSteamUser;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002B09 RID: 11017
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002B0A RID: 11018
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0;

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamUser_Int32_0;

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamUser_0;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0;

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0;

		// Token: 0x04002B10 RID: 11024
		[FieldOffset(0)]
		public int m_HSteamUser;
	}
}
