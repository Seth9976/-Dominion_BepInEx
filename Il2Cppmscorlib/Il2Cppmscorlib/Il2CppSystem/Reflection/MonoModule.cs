using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DA RID: 474
	[Serializable]
	public class MonoModule : RuntimeModule
	{
		// Token: 0x06001E93 RID: 7827 RVA: 0x000AAFC4 File Offset: 0x000A91C4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoModule()
		{
			Il2CppClassPointerStore<MonoModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoModule>.NativeClassPtr);
			MonoModule.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668360);
			MonoModule.NativeMethodInfoPtr_get_ScopeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668361);
			MonoModule.NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668362);
			MonoModule.NativeMethodInfoPtr_IsResource_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668363);
			MonoModule.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668364);
			MonoModule.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668365);
			MonoModule.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668366);
			MonoModule.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668367);
			MonoModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoModule>.NativeClassPtr, 100668368);
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000AB0A8 File Offset: 0x000A92A8
		public unsafe override Assembly Assembly
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoModule.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x000AB0F4 File Offset: 0x000A92F4
		public unsafe override string ScopeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoModule.NativeMethodInfoPtr_get_ScopeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000AB138 File Offset: 0x000A9338
		public unsafe override Guid ModuleVersionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoModule.NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000AB180 File Offset: 0x000A9380
		[CallerCount(0)]
		public unsafe override bool IsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoModule.NativeMethodInfoPtr_IsResource_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x000AB1C8 File Offset: 0x000A93C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318862, XrefRangeEnd = 318866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoModule.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000AB234 File Offset: 0x000A9434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318866, XrefRangeEnd = 318870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefined(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoModule.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000AB29C File Offset: 0x000A949C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318870, XrefRangeEnd = 318873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoModule.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000AB300 File Offset: 0x000A9500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318873, XrefRangeEnd = 318875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly GetRuntimeAssembly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoModule.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x000AB340 File Offset: 0x000A9540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318875, XrefRangeEnd = 318876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0000A7C9 File Offset: 0x000089C9
		public MonoModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopeName_Public_Virtual_get_String_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_get_Guid_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr_IsResource_Public_Virtual_Boolean_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
