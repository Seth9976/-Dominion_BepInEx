using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D7 RID: 471
	public class RuntimeConstructorInfo : ConstructorInfo
	{
		// Token: 0x06001E65 RID: 7781 RVA: 0x000AA0FC File Offset: 0x000A82FC
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeConstructorInfo()
		{
			Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeConstructorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr);
			RuntimeConstructorInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668326);
			RuntimeConstructorInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668327);
			RuntimeConstructorInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668328);
			RuntimeConstructorInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668329);
			RuntimeConstructorInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668330);
			RuntimeConstructorInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668331);
			RuntimeConstructorInfo.NativeMethodInfoPtr_SerializationInvoke_Internal_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668332);
			RuntimeConstructorInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr, 100668333);
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000AA1CC File Offset: 0x000A83CC
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318742, XrefRangeEnd = 318747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeConstructorInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000AA218 File Offset: 0x000A8418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule GetRuntimeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeConstructorInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x000AA258 File Offset: 0x000A8458
		public unsafe BindingFlags BindingFlags
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeConstructorInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x000AA294 File Offset: 0x000A8494
		public unsafe RuntimeType ReflectedTypeInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318747, XrefRangeEnd = 318749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeConstructorInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000AA2D4 File Offset: 0x000A84D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318749, XrefRangeEnd = 318753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeConstructorInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000AA330 File Offset: 0x000A8530
		[CallerCount(0)]
		public unsafe string SerializationToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeConstructorInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000AA368 File Offset: 0x000A8568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318762, RefRangeEnd = 318763, XrefRangeStart = 318753, XrefRangeEnd = 318762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializationInvoke(Object target, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeConstructorInfo.NativeMethodInfoPtr_SerializationInvoke_Internal_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000AA3D4 File Offset: 0x000A85D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318767, RefRangeEnd = 318768, XrefRangeStart = 318763, XrefRangeEnd = 318767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeConstructorInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeConstructorInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeConstructorInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0000A71C File Offset: 0x0000891C
		public RuntimeConstructorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_SerializationToString_Internal_String_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_SerializationInvoke_Internal_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
