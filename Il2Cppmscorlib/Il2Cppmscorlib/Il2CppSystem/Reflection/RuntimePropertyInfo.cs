using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DF RID: 479
	public class RuntimePropertyInfo : PropertyInfo
	{
		// Token: 0x06001EB9 RID: 7865 RVA: 0x000AB89C File Offset: 0x000A9A9C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimePropertyInfo()
		{
			Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimePropertyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668377);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668378);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668379);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668380);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668381);
			RuntimePropertyInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668382);
			RuntimePropertyInfo.NativeMethodInfoPtr_FormatNameAndSig_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668383);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668384);
			RuntimePropertyInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668385);
			RuntimePropertyInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100668386);
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000AB994 File Offset: 0x000A9B94
		public unsafe BindingFlags BindingFlags
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x000AB9D0 File Offset: 0x000A9BD0
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318917, XrefRangeEnd = 318922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000ABA1C File Offset: 0x000A9C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318922, XrefRangeEnd = 318924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetDeclaringTypeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x000ABA5C File Offset: 0x000A9C5C
		public unsafe RuntimeType ReflectedTypeInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318924, XrefRangeEnd = 318926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000ABA9C File Offset: 0x000A9C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule GetRuntimeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x000ABADC File Offset: 0x000A9CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318926, XrefRangeEnd = 318927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000ABB20 File Offset: 0x000A9D20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318943, RefRangeEnd = 318946, XrefRangeStart = 318927, XrefRangeEnd = 318943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatNameAndSig(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_FormatNameAndSig_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000ABB64 File Offset: 0x000A9D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318946, XrefRangeEnd = 318951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000ABBC0 File Offset: 0x000A9DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318951, XrefRangeEnd = 318952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SerializationToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000ABBF8 File Offset: 0x000A9DF8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimePropertyInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0000A8EE File Offset: 0x00008AEE
		public RuntimePropertyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeMethodInfoPtr_FormatNameAndSig_Private_String_Boolean_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_SerializationToString_Internal_String_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
