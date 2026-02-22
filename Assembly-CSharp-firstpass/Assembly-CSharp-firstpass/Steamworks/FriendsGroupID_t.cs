using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002DA RID: 730
	[Serializable]
	[StructLayout(2)]
	public struct FriendsGroupID_t
	{
		// Token: 0x06002A5E RID: 10846 RVA: 0x000B5B2C File Offset: 0x000B3D2C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsGroupID_t()
		{
			Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsGroupID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr);
			FriendsGroupID_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, "Invalid");
			FriendsGroupID_t.NativeFieldInfoPtr_m_FriendsGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, "m_FriendsGroupID");
			FriendsGroupID_t.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668708);
			FriendsGroupID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668709);
			FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668710);
			FriendsGroupID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668711);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668712);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668713);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_FriendsGroupID_t_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668714);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668715);
			FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668716);
			FriendsGroupID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100668717);
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000B5C4C File Offset: 0x000B3E4C
		[CallerCount(0)]
		public unsafe FriendsGroupID_t(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000B5C80 File Offset: 0x000B3E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210762, XrefRangeEnd = 210765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000B5CAC File Offset: 0x000B3EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210765, XrefRangeEnd = 210770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000B5CF0 File Offset: 0x000B3EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210770, XrefRangeEnd = 210771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000B5D20 File Offset: 0x000B3F20
		[CallerCount(0)]
		public unsafe static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000B5D6C File Offset: 0x000B3F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210771, XrefRangeEnd = 210774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x000B5DB8 File Offset: 0x000B3FB8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator FriendsGroupID_t(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_FriendsGroupID_t_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000B5DF8 File Offset: 0x000B3FF8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator short(FriendsGroupID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000B5E38 File Offset: 0x000B4038
		[CallerCount(0)]
		public unsafe bool Equals(FriendsGroupID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000B5E78 File Offset: 0x000B4078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210784, XrefRangeEnd = 210785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FriendsGroupID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00010F67 File Offset: 0x0000F167
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000B5EB8 File Offset: 0x000B40B8
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x00010F79 File Offset: 0x0000F179
		public unsafe static FriendsGroupID_t Invalid
		{
			get
			{
				FriendsGroupID_t friendsGroupID_t;
				IL2CPP.il2cpp_field_static_get_value(FriendsGroupID_t.NativeFieldInfoPtr_Invalid, (void*)(&friendsGroupID_t));
				return friendsGroupID_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsGroupID_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeFieldInfoPtr_m_FriendsGroupID;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0;

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_FriendsGroupID_t_Int16_0;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_FriendsGroupID_t_0;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0;

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0;

		// Token: 0x040028CE RID: 10446
		[FieldOffset(0)]
		public short m_FriendsGroupID;
	}
}
