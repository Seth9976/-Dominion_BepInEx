using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002DE RID: 734
	public sealed class CspParameters : Object
	{
		// Token: 0x06003061 RID: 12385 RVA: 0x000F1C24 File Offset: 0x000EFE24
		// Note: this type is marked as 'beforefieldinit'.
		static CspParameters()
		{
			Il2CppClassPointerStore<CspParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CspParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CspParameters>.NativeClassPtr);
			CspParameters.NativeFieldInfoPtr_ProviderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderType");
			CspParameters.NativeFieldInfoPtr_ProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderName");
			CspParameters.NativeFieldInfoPtr_KeyContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyContainerName");
			CspParameters.NativeFieldInfoPtr_KeyNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyNumber");
			CspParameters.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "m_flags");
			CspParameters.NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100670919);
			CspParameters.NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100670920);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100670921);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100670922);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100670923);
			CspParameters.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100670924);
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x000F1D30 File Offset: 0x000EFF30
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x000F1D6C File Offset: 0x000EFF6C
		public unsafe CspProviderFlags Flags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12780, RefRangeEnd = 12781, XrefRangeStart = 12780, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 338909, RefRangeEnd = 338916, XrefRangeStart = 338909, XrefRangeEnd = 338909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x000F1DAC File Offset: 0x000EFFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338917, RefRangeEnd = 338919, XrefRangeStart = 338916, XrefRangeEnd = 338917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x000F1DE8 File Offset: 0x000EFFE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338920, RefRangeEnd = 338922, XrefRangeStart = 338919, XrefRangeEnd = 338920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int dwTypeIn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwTypeIn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x000F1E30 File Offset: 0x000F0030
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338923, RefRangeEnd = 338926, XrefRangeStart = 338922, XrefRangeEnd = 338923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwTypeIn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProviderNameIn);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strContainerNameIn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x000F1E9C File Offset: 0x000F009C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338926, XrefRangeEnd = 338927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref providerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyContainerName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0001115B File Offset: 0x0000F35B
		public CspParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x000F1F18 File Offset: 0x000F0118
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x00011164 File Offset: 0x0000F364
		public unsafe int ProviderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderType)) = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x000F1F40 File Offset: 0x000F0140
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x0001117F File Offset: 0x0000F37F
		public unsafe string ProviderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x000F1F68 File Offset: 0x000F0168
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x0001119E File Offset: 0x0000F39E
		public unsafe string KeyContainerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyContainerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyContainerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x000F1F90 File Offset: 0x000F0190
		// (set) Token: 0x06003070 RID: 12400 RVA: 0x000111BD File Offset: 0x0000F3BD
		public unsafe int KeyNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyNumber)) = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x000F1FB8 File Offset: 0x000F01B8
		// (set) Token: 0x06003072 RID: 12402 RVA: 0x000111D8 File Offset: 0x0000F3D8
		public unsafe int m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeFieldInfoPtr_ProviderType;

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeFieldInfoPtr_ProviderName;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeFieldInfoPtr_KeyContainerName;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeFieldInfoPtr_KeyNumber;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0;
	}
}
