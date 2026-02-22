using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SA.Foundation.Patterns
{
	// Token: 0x0200002A RID: 42
	public static class SA_SingletonService : global::Il2CppSystem.Object
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00009100 File Offset: 0x00007300
		// Note: this type is marked as 'beforefieldinit'.
		static SA_SingletonService()
		{
			Il2CppClassPointerStore<SA_SingletonService>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_SingletonService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_SingletonService>.NativeClassPtr);
			SA_SingletonService.NativeFieldInfoPtr_s_services = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SingletonService>.NativeClassPtr, "s_services");
			SA_SingletonService.NativeMethodInfoPtr_get_Parent_Public_Static_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SingletonService>.NativeClassPtr, 100663517);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00009158 File Offset: 0x00007358
		public unsafe static Transform Parent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 100348, RefRangeEnd = 100349, XrefRangeStart = 100323, XrefRangeEnd = 100348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SingletonService.NativeMethodInfoPtr_get_Parent_Public_Static_get_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002474 File Offset: 0x00000674
		public SA_SingletonService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000918C File Offset: 0x0000738C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000247D File Offset: 0x0000067D
		public unsafe static Transform s_services
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SingletonService.NativeFieldInfoPtr_s_services, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_SingletonService.NativeFieldInfoPtr_s_services, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_s_services;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Static_get_Transform_0;
	}
}
