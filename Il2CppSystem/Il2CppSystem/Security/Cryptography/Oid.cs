using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200007A RID: 122
	public sealed class Oid : Object
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x0002D264 File Offset: 0x0002B464
		// Note: this type is marked as 'beforefieldinit'.
		static Oid()
		{
			Il2CppClassPointerStore<Oid>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "Oid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Oid>.NativeClassPtr);
			Oid.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "m_value");
			Oid.NativeFieldInfoPtr_m_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "m_friendlyName");
			Oid.NativeFieldInfoPtr_m_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "m_group");
			Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664309);
			Oid.NativeMethodInfoPtr__ctor_Internal_Void_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664310);
			Oid.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664311);
			Oid.NativeMethodInfoPtr__ctor_Public_Void_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664312);
			Oid.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664313);
			Oid.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664314);
			Oid.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664315);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0002D35C File Offset: 0x0002B55C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41376, RefRangeEnd = 41378, XrefRangeStart = 41374, XrefRangeEnd = 41376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string oid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41378, XrefRangeEnd = 41381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string oid, OidGroup group, bool lookupFriendlyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref group;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookupFriendlyName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Internal_Void_String_OidGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0002D410 File Offset: 0x0002B610
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string value, string friendlyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0002D470 File Offset: 0x0002B670
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41382, RefRangeEnd = 41390, XrefRangeStart = 41381, XrefRangeEnd = 41382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(Oid oid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002D538 File Offset: 0x0002B738
		public unsafe string FriendlyName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 41391, RefRangeEnd = 41393, XrefRangeStart = 41390, XrefRangeEnd = 41391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000534A File Offset: 0x0000354A
		public Oid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x0002D570 File Offset: 0x0002B770
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00005353 File Offset: 0x00003553
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0002D598 File Offset: 0x0002B798
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00005372 File Offset: 0x00003572
		public unsafe string m_friendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_friendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_friendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0002D5C0 File Offset: 0x0002B7C0
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00005391 File Offset: 0x00003591
		public unsafe OidGroup m_group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_group);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_group)) = value;
			}
		}

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_m_friendlyName;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_m_group;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_OidGroup_Boolean_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Oid_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0;
	}
}
