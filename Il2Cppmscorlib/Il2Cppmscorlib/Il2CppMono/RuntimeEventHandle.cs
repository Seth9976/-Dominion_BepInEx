using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct RuntimeEventHandle
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00023358 File Offset: 0x00021558
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeEventHandle()
		{
			Il2CppClassPointerStore<RuntimeEventHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeEventHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeEventHandle>.NativeClassPtr);
			RuntimeEventHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeEventHandle>.NativeClassPtr, "value");
			RuntimeEventHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeEventHandle>.NativeClassPtr, 100663326);
			RuntimeEventHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeEventHandle>.NativeClassPtr, 100663327);
			RuntimeEventHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeEventHandle>.NativeClassPtr, 100663328);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000233D8 File Offset: 0x000215D8
		public unsafe IntPtr Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeEventHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00023408 File Offset: 0x00021608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258390, XrefRangeEnd = 258402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeEventHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0002344C File Offset: 0x0002164C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeEventHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020B8 File Offset: 0x000002B8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeEventHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000026 RID: 38
		[FieldOffset(0)]
		public IntPtr value;
	}
}
