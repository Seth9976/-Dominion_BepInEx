using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D1 RID: 465
	public class RuntimeFieldInfo : FieldInfo
	{
		// Token: 0x06001DE6 RID: 7654 RVA: 0x000A7B50 File Offset: 0x000A5D50
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeFieldInfo()
		{
			Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeFieldInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr);
			RuntimeFieldInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr, 100668239);
			RuntimeFieldInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr, 100668240);
			RuntimeFieldInfo.NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr, 100668241);
			RuntimeFieldInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr, 100668242);
			RuntimeFieldInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr, 100668243);
			RuntimeFieldInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr, 100668244);
			RuntimeFieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr, 100668245);
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000A7C0C File Offset: 0x000A5E0C
		public unsafe BindingFlags BindingFlags
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x000A7C48 File Offset: 0x000A5E48
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318471, XrefRangeEnd = 318476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeFieldInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000A7C94 File Offset: 0x000A5E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318478, RefRangeEnd = 318480, XrefRangeStart = 318476, XrefRangeEnd = 318478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetDeclaringTypeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldInfo.NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x000A7CD4 File Offset: 0x000A5ED4
		public unsafe RuntimeType ReflectedTypeInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318480, XrefRangeEnd = 318482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000A7D14 File Offset: 0x000A5F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule GetRuntimeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000A7D54 File Offset: 0x000A5F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318482, XrefRangeEnd = 318486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x000A7DB0 File Offset: 0x000A5FB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeFieldInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeFieldInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0000A54F File Offset: 0x0000874F
		public RuntimeFieldInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
