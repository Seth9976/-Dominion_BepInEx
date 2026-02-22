using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMono
{
	// Token: 0x02000008 RID: 8
	[StructLayout(2)]
	public struct RuntimeGenericParamInfoHandle
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000231FC File Offset: 0x000213FC
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeGenericParamInfoHandle()
		{
			Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeGenericParamInfoHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr);
			RuntimeGenericParamInfoHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, "value");
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663321);
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663322);
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663323);
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663324);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00023290 File Offset: 0x00021490
		public unsafe Il2CppReferenceArray<Type> Constraints
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258378, XrefRangeEnd = 258379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000232C4 File Offset: 0x000214C4
		public unsafe GenericParameterAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000232F4 File Offset: 0x000214F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258388, RefRangeEnd = 258390, XrefRangeStart = 258379, XrefRangeEnd = 258388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetConstraints()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00023328 File Offset: 0x00021528
		[CallerCount(0)]
		public unsafe int GetConstraintsCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020A6 File Offset: 0x000002A6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0;

		// Token: 0x04000021 RID: 33
		[FieldOffset(0)]
		public IntPtr value;
	}
}
