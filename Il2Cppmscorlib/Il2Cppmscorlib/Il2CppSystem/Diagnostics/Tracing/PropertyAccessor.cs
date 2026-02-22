using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D1 RID: 1233
	public class PropertyAccessor<ContainerType> : Object
	{
		// Token: 0x0600484A RID: 18506 RVA: 0x0014B50C File Offset: 0x0014970C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAccessor()
		{
			Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "PropertyAccessor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100673985);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_Object_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100673986);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Create_Public_Static_PropertyAccessor_1_ContainerType_PropertyAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100673987);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100673988);
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x0014B5C8 File Offset: 0x001497C8
		[CallerCount(0)]
		public unsafe virtual void Write(TraceLoggingDataCollector collector, ref ContainerType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x0014B640 File Offset: 0x00149840
		[CallerCount(0)]
		public unsafe virtual Object GetData(ContainerType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(ContainerType).IsValueType)
				{
					ContainerType containerType = value;
					intPtr = ((containerType is string) ? IL2CPP.ManagedStringToIl2Cpp(containerType as string) : IL2CPP.Il2CppObjectBaseToPtr(containerType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyAccessor<ContainerType>.NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_Object_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
			}
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x0014B6D4 File Offset: 0x001498D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366314, XrefRangeEnd = 366347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyAccessor<ContainerType> Create(PropertyAnalysis property)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Create_Public_Static_PropertyAccessor_1_ContainerType_PropertyAnalysis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyAccessor<ContainerType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x0014B718 File Offset: 0x00149918
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyAccessor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAccessor<ContainerType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x0001B63B File Offset: 0x0001983B
		public PropertyAccessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003A7F RID: 14975
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003A80 RID: 14976
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_Object_ContainerType_0;

		// Token: 0x04003A81 RID: 14977
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PropertyAccessor_1_ContainerType_PropertyAnalysis_0;

		// Token: 0x04003A82 RID: 14978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
