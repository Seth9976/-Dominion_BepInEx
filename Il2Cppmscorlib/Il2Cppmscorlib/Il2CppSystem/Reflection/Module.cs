using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CB RID: 459
	[Serializable]
	public class Module : Object
	{
		// Token: 0x06001D82 RID: 7554 RVA: 0x000A638C File Offset: 0x000A458C
		// Note: this type is marked as 'beforefieldinit'.
		static Module()
		{
			Il2CppClassPointerStore<Module>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Module");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Module>.NativeClassPtr);
			Module.NativeFieldInfoPtr_FilterTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "FilterTypeName");
			Module.NativeFieldInfoPtr_FilterTypeNameIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "FilterTypeNameIgnoreCase");
			Module.NativeFieldInfoPtr__impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "_impl");
			Module.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "assembly");
			Module.NativeFieldInfoPtr_fqname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "fqname");
			Module.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "name");
			Module.NativeFieldInfoPtr_scopename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "scopename");
			Module.NativeFieldInfoPtr_is_resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "is_resource");
			Module.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "token");
			Module.NativeFieldInfoPtr_defaultBindingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Module>.NativeClassPtr, "defaultBindingFlags");
			Module.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668191);
			Module.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668192);
			Module.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668193);
			Module.NativeMethodInfoPtr_GetModuleVersionId_Internal_Virtual_New_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668194);
			Module.NativeMethodInfoPtr_filter_by_type_name_Private_Static_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668195);
			Module.NativeMethodInfoPtr_filter_by_type_name_ignore_case_Private_Static_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668196);
			Module.NativeMethodInfoPtr_GetGuidInternal_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668197);
			Module.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668198);
			Module.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668199);
			Module.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Module_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668200);
			Module.NativeMethodInfoPtr_get_Assembly_Public_Virtual_New_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668201);
			Module.NativeMethodInfoPtr_get_ScopeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668202);
			Module.NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668203);
			Module.NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668204);
			Module.NativeMethodInfoPtr_IsResource_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668205);
			Module.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668206);
			Module.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Module>.NativeClassPtr, 100668207);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000A65D8 File Offset: 0x000A47D8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Module()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Module>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Module.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000A6614 File Offset: 0x000A4814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318310, XrefRangeEnd = 318315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000A6678 File Offset: 0x000A4878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x000A66BC File Offset: 0x000A48BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318315, XrefRangeEnd = 318317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Guid GetModuleVersionId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_GetModuleVersionId_Internal_Virtual_New_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000A6704 File Offset: 0x000A4904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318317, XrefRangeEnd = 318325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool filter_by_type_name(Type m, Object filterCriteria)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Module.NativeMethodInfoPtr_filter_by_type_name_Private_Static_Boolean_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000A6758 File Offset: 0x000A4958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318325, XrefRangeEnd = 318331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool filter_by_type_name_ignore_case(Type m, Object filterCriteria)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Module.NativeMethodInfoPtr_filter_by_type_name_ignore_case_Private_Static_Boolean_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000A67AC File Offset: 0x000A49AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318331, XrefRangeEnd = 318332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGuidInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Module.NativeMethodInfoPtr_GetGuidInternal_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x000A67E4 File Offset: 0x000A49E4
		[CallerCount(0)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000A683C File Offset: 0x000A4A3C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000A6884 File Offset: 0x000A4A84
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 317559, RefRangeEnd = 317601, XrefRangeStart = 317559, XrefRangeEnd = 317601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Module left, Module right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Module.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Module_Module_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x000A68D8 File Offset: 0x000A4AD8
		public unsafe virtual Assembly Assembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318332, XrefRangeEnd = 318339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_get_Assembly_Public_Virtual_New_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000A6924 File Offset: 0x000A4B24
		public unsafe virtual string ScopeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318339, XrefRangeEnd = 318346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_get_ScopeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x000A6968 File Offset: 0x000A4B68
		public unsafe virtual Guid ModuleVersionId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318346, XrefRangeEnd = 318353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x000A69B0 File Offset: 0x000A4BB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 318360, RefRangeEnd = 318366, XrefRangeStart = 318353, XrefRangeEnd = 318360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateNIE()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Module.NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x000A69E4 File Offset: 0x000A4BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318366, XrefRangeEnd = 318387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_IsResource_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000A6A2C File Offset: 0x000A4C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318387, XrefRangeEnd = 318394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000A6A98 File Offset: 0x000A4C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318394, XrefRangeEnd = 318401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Module.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0000A2DE File Offset: 0x000084DE
		public Module(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x000A6B00 File Offset: 0x000A4D00
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0000A2E7 File Offset: 0x000084E7
		public unsafe static TypeFilter FilterTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Module.NativeFieldInfoPtr_FilterTypeName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeFilter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Module.NativeFieldInfoPtr_FilterTypeName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000A6B28 File Offset: 0x000A4D28
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0000A2F9 File Offset: 0x000084F9
		public unsafe static TypeFilter FilterTypeNameIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Module.NativeFieldInfoPtr_FilterTypeNameIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeFilter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Module.NativeFieldInfoPtr_FilterTypeNameIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000A6B50 File Offset: 0x000A4D50
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0000A30B File Offset: 0x0000850B
		public unsafe IntPtr _impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr__impl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr__impl)) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000A6B78 File Offset: 0x000A4D78
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0000A326 File Offset: 0x00008526
		public unsafe Assembly assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_assembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x000A6BA8 File Offset: 0x000A4DA8
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0000A345 File Offset: 0x00008545
		public unsafe string fqname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_fqname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_fqname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x000A6BD0 File Offset: 0x000A4DD0
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0000A364 File Offset: 0x00008564
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x000A6BF8 File Offset: 0x000A4DF8
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0000A383 File Offset: 0x00008583
		public unsafe string scopename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_scopename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_scopename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000A6C20 File Offset: 0x000A4E20
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x0000A3A2 File Offset: 0x000085A2
		public unsafe bool is_resource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_is_resource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_is_resource)) = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000A6C48 File Offset: 0x000A4E48
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0000A3BD File Offset: 0x000085BD
		public unsafe int token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Module.NativeFieldInfoPtr_token)) = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000A6C70 File Offset: 0x000A4E70
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0000A3D8 File Offset: 0x000085D8
		public unsafe static BindingFlags defaultBindingFlags
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(Module.NativeFieldInfoPtr_defaultBindingFlags, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Module.NativeFieldInfoPtr_defaultBindingFlags, (void*)(&value));
			}
		}

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr_FilterTypeName;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeFieldInfoPtr_FilterTypeNameIgnoreCase;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeFieldInfoPtr__impl;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeFieldInfoPtr_fqname;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeFieldInfoPtr_scopename;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeFieldInfoPtr_is_resource;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeFieldInfoPtr_token;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeFieldInfoPtr_defaultBindingFlags;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_GetModuleVersionId_Internal_Virtual_New_Guid_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_filter_by_type_name_Private_Static_Boolean_Type_Object_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_filter_by_type_name_ignore_case_Private_Static_Boolean_Type_Object_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_GetGuidInternal_Private_String_0;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Module_Module_0;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_New_get_Assembly_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopeName_Public_Virtual_New_get_String_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_New_get_Guid_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_IsResource_Public_Virtual_New_Boolean_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0;
	}
}
