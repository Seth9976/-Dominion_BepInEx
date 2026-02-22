using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000184 RID: 388
	public sealed class ResourceLocator : ValueType
	{
		// Token: 0x06001ADF RID: 6879 RVA: 0x0009B948 File Offset: 0x00099B48
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLocator()
		{
			Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr);
			ResourceLocator.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, "_value");
			ResourceLocator.NativeFieldInfoPtr__dataPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, "_dataPos");
			ResourceLocator.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667827);
			ResourceLocator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667828);
			ResourceLocator.NativeMethodInfoPtr_get_Value_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667829);
			ResourceLocator.NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667830);
			ResourceLocator.NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667831);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0009BA04 File Offset: 0x00099C04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316164, RefRangeEnd = 316167, XrefRangeStart = 316164, XrefRangeEnd = 316164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocator(int dataPos, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0009BA64 File Offset: 0x00099C64
		public unsafe int DataPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0009BAA8 File Offset: 0x00099CA8
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0009BAEC File Offset: 0x00099CEC
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_get_Value_Internal_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0009BB34 File Offset: 0x00099D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316167, RefRangeEnd = 316169, XrefRangeStart = 316167, XrefRangeEnd = 316167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanCache(ResourceTypeCode value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x000093A0 File Offset: 0x000075A0
		public ResourceLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000093A9 File Offset: 0x000075A9
		public ResourceLocator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr))
		{
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0009BB74 File Offset: 0x00099D74
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x000093BB File Offset: 0x000075BB
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0009BBA4 File Offset: 0x00099DA4
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x000093DA File Offset: 0x000075DA
		public unsafe int _dataPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__dataPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__dataPos)) = value;
			}
		}

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr__dataPos;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_Object_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0;
	}
}
