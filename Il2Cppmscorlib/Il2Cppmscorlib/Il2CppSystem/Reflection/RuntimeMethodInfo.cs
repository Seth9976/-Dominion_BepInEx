using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D5 RID: 469
	public class RuntimeMethodInfo : MethodInfo
	{
		// Token: 0x06001E2E RID: 7726 RVA: 0x000A8EC4 File Offset: 0x000A70C4
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeMethodInfo()
		{
			Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeMethodInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr);
			RuntimeMethodInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668282);
			RuntimeMethodInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668283);
			RuntimeMethodInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668284);
			RuntimeMethodInfo.NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668285);
			RuntimeMethodInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668286);
			RuntimeMethodInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668287);
			RuntimeMethodInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668288);
			RuntimeMethodInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668289);
			RuntimeMethodInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr, 100668290);
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x000A8FA8 File Offset: 0x000A71A8
		public unsafe BindingFlags BindingFlags
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x000A8FE4 File Offset: 0x000A71E4
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318600, XrefRangeEnd = 318605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeMethodInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x000A9030 File Offset: 0x000A7230
		public unsafe RuntimeType ReflectedTypeInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318605, XrefRangeEnd = 318607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000A9070 File Offset: 0x000A7270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318607, XrefRangeEnd = 318638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string FormatNameAndSig(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeMethodInfo.NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x000A90C0 File Offset: 0x000A72C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318638, XrefRangeEnd = 318643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeMethodInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x000A9104 File Offset: 0x000A7304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule GetRuntimeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000A9144 File Offset: 0x000A7344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318643, XrefRangeEnd = 318651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000A91A0 File Offset: 0x000A73A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318655, RefRangeEnd = 318657, XrefRangeStart = 318651, XrefRangeEnd = 318655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SerializationToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000A91D8 File Offset: 0x000A73D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeMethodInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeMethodInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0000A6A3 File Offset: 0x000088A3
		public RuntimeMethodInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_String_Boolean_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeMethodInfoPtr_SerializationToString_Internal_String_0;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
