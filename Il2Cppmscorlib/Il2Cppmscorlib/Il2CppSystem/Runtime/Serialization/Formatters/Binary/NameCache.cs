using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000385 RID: 901
	public sealed class NameCache : Object
	{
		// Token: 0x06003AB2 RID: 15026 RVA: 0x001166B0 File Offset: 0x001148B0
		// Note: this type is marked as 'beforefieldinit'.
		static NameCache()
		{
			Il2CppClassPointerStore<NameCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "NameCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameCache>.NativeClassPtr);
			NameCache.NativeFieldInfoPtr_ht = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameCache>.NativeClassPtr, "ht");
			NameCache.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameCache>.NativeClassPtr, "name");
			NameCache.NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100672026);
			NameCache.NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100672027);
			NameCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100672028);
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x00116744 File Offset: 0x00114944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348670, RefRangeEnd = 348671, XrefRangeStart = 348663, XrefRangeEnd = 348670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetCachedValue(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x00116794 File Offset: 0x00114994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348687, RefRangeEnd = 348688, XrefRangeStart = 348671, XrefRangeEnd = 348687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCachedValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x001167D8 File Offset: 0x001149D8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00015F41 File Offset: 0x00014141
		public NameCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x00116814 File Offset: 0x00114A14
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x00015F4A File Offset: 0x0001414A
		public unsafe static ConcurrentDictionary<string, Object> ht
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameCache.NativeFieldInfoPtr_ht, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameCache.NativeFieldInfoPtr_ht, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x0011683C File Offset: 0x00114A3C
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x00015F5C File Offset: 0x0001415C
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameCache.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameCache.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeFieldInfoPtr_ht;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0;

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0;

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
