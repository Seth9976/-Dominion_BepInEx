using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D2 RID: 1234
	public class NonGenericProperytWriter<ContainerType> : PropertyAccessor<ContainerType>
	{
		// Token: 0x06004850 RID: 18512 RVA: 0x0014B754 File Offset: 0x00149954
		// Note: this type is marked as 'beforefieldinit'.
		static NonGenericProperytWriter()
		{
			Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "NonGenericProperytWriter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr);
			NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_typeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, "typeInfo");
			NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_getterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, "getterInfo");
			NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, 100673989);
			NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, 100673990);
			NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, 100673991);
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x0014B824 File Offset: 0x00149A24
		[CallerCount(0)]
		public unsafe NonGenericProperytWriter(PropertyAnalysis property)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x0014B870 File Offset: 0x00149A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366347, XrefRangeEnd = 366350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(TraceLoggingDataCollector collector, ref ContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			container = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x0014B8E8 File Offset: 0x00149AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366350, XrefRangeEnd = 366353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetData(ContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(ContainerType).IsValueType)
				{
					ContainerType containerType = container;
					intPtr = ((containerType is string) ? IL2CPP.ManagedStringToIl2Cpp(containerType as string) : IL2CPP.Il2CppObjectBaseToPtr(containerType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref container;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
			}
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x0001B644 File Offset: 0x00019844
		public NonGenericProperytWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x0014B97C File Offset: 0x00149B7C
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x0001B64D File Offset: 0x0001984D
		public unsafe TraceLoggingTypeInfo typeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_typeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_typeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x0014B9AC File Offset: 0x00149BAC
		// (set) Token: 0x06004858 RID: 18520 RVA: 0x0001B66C File Offset: 0x0001986C
		public unsafe MethodInfo getterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_getterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_getterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A83 RID: 14979
		private static readonly IntPtr NativeFieldInfoPtr_typeInfo;

		// Token: 0x04003A84 RID: 14980
		private static readonly IntPtr NativeFieldInfoPtr_getterInfo;

		// Token: 0x04003A85 RID: 14981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0;

		// Token: 0x04003A86 RID: 14982
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003A87 RID: 14983
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0;
	}
}
