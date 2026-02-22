using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct RuntimeClassHandle
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00022F7C File Offset: 0x0002117C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeClassHandle()
		{
			Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeClassHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr);
			RuntimeClassHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, "value");
			RuntimeClassHandle.NativeMethodInfoPtr__ctor_Internal_Void_ptr_MonoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663312);
			RuntimeClassHandle.NativeMethodInfoPtr_get_Value_Internal_get_ptr_MonoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663314);
			RuntimeClassHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663315);
			RuntimeClassHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663316);
			RuntimeClassHandle.NativeMethodInfoPtr_GetTypeFromClass_Internal_Static_IntPtr_ptr_MonoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663317);
			RuntimeClassHandle.NativeMethodInfoPtr_GetTypeHandle_Internal_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663318);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00023038 File Offset: 0x00021238
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr__ctor_Internal_Void_ptr_MonoClass_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0002306C File Offset: 0x0002126C
		public unsafe RuntimeStructs.MonoClass* Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_get_Value_Internal_get_ptr_MonoClass_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00023094 File Offset: 0x00021294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258357, XrefRangeEnd = 258368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000230D8 File Offset: 0x000212D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258368, XrefRangeEnd = 258370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00023108 File Offset: 0x00021308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258370, XrefRangeEnd = 258371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = klass;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_GetTypeFromClass_Internal_Static_IntPtr_ptr_MonoClass_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00023144 File Offset: 0x00021344
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 258373, RefRangeEnd = 258378, XrefRangeStart = 258371, XrefRangeEnd = 258373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeTypeHandle GetTypeHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_GetTypeHandle_Internal_RuntimeTypeHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002082 File Offset: 0x00000282
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_MonoClass_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_ptr_MonoClass_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromClass_Internal_Static_IntPtr_ptr_MonoClass_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeHandle_Internal_RuntimeTypeHandle_0;

		// Token: 0x04000018 RID: 24
		[FieldOffset(0)]
		public IntPtr value;
	}
}
