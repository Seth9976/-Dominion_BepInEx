using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DD RID: 477
	public sealed class MonoPropertyInfo : ValueType
	{
		// Token: 0x06001EA7 RID: 7847 RVA: 0x000AB5B8 File Offset: 0x000A97B8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoPropertyInfo()
		{
			Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoPropertyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr);
			MonoPropertyInfo.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "parent");
			MonoPropertyInfo.NativeFieldInfoPtr_declaring_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "declaring_type");
			MonoPropertyInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "name");
			MonoPropertyInfo.NativeFieldInfoPtr_get_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "get_method");
			MonoPropertyInfo.NativeFieldInfoPtr_set_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "set_method");
			MonoPropertyInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "attrs");
			MonoPropertyInfo.NativeMethodInfoPtr_get_property_info_Internal_Static_Void_MonoProperty_byref_MonoPropertyInfo_PInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, 100668374);
			MonoPropertyInfo.NativeMethodInfoPtr_GetTypeModifiers_Internal_Static_Il2CppReferenceArray_1_Type_MonoProperty_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, 100668375);
			MonoPropertyInfo.NativeMethodInfoPtr_get_default_value_Internal_Static_Object_MonoProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, 100668376);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000AB69C File Offset: 0x000A989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318915, XrefRangeEnd = 318916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref req_info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPropertyInfo.NativeMethodInfoPtr_get_property_info_Internal_Static_Void_MonoProperty_byref_MonoPropertyInfo_PInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000AB6F4 File Offset: 0x000A98F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318916, XrefRangeEnd = 318917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetTypeModifiers(MonoProperty prop, bool optional)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPropertyInfo.NativeMethodInfoPtr_GetTypeModifiers_Internal_Static_Il2CppReferenceArray_1_Type_MonoProperty_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000AB748 File Offset: 0x000A9948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object get_default_value(MonoProperty prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPropertyInfo.NativeMethodInfoPtr_get_default_value_Internal_Static_Object_MonoProperty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0000A81D File Offset: 0x00008A1D
		public MonoPropertyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0000A826 File Offset: 0x00008A26
		public MonoPropertyInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x000AB78C File Offset: 0x000A998C
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x0000A838 File Offset: 0x00008A38
		public unsafe Type parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000AB7BC File Offset: 0x000A99BC
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x0000A857 File Offset: 0x00008A57
		public unsafe Type declaring_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_declaring_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_declaring_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000AB7EC File Offset: 0x000A99EC
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x0000A876 File Offset: 0x00008A76
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000AB814 File Offset: 0x000A9A14
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x0000A895 File Offset: 0x00008A95
		public unsafe MethodInfo get_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_get_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_get_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000AB844 File Offset: 0x000A9A44
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		public unsafe MethodInfo set_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_set_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_set_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x000AB874 File Offset: 0x000A9A74
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x0000A8D3 File Offset: 0x00008AD3
		public unsafe PropertyAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeFieldInfoPtr_declaring_type;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeFieldInfoPtr_get_method;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeFieldInfoPtr_set_method;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_get_property_info_Internal_Static_Void_MonoProperty_byref_MonoPropertyInfo_PInfo_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeModifiers_Internal_Static_Il2CppReferenceArray_1_Type_MonoProperty_Boolean_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_get_default_value_Internal_Static_Object_MonoProperty_0;
	}
}
