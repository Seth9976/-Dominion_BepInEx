using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000AA RID: 170
	public class Behaviour : Component
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x00041D08 File Offset: 0x0003FF08
		// Note: this type is marked as 'beforefieldinit'.
		static Behaviour()
		{
			Il2CppClassPointerStore<Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Behaviour>.NativeClassPtr);
			Behaviour.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100664332);
			Behaviour.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100664333);
			Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100664334);
			Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100664335);
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00041D88 File Offset: 0x0003FF88
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x00041DC4 File Offset: 0x0003FFC4
		public unsafe bool enabled
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 68319, RefRangeEnd = 68335, XrefRangeStart = 68317, XrefRangeEnd = 68319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(68)]
			[CachedScanResults(RefRangeStart = 68337, RefRangeEnd = 68405, XrefRangeStart = 68335, XrefRangeEnd = 68337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00041E04 File Offset: 0x00040004
		public unsafe bool isActiveAndEnabled
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 68407, RefRangeEnd = 68431, XrefRangeStart = 68405, XrefRangeEnd = 68407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00041E40 File Offset: 0x00040040
		[CallerCount(279)]
		[CachedScanResults(RefRangeStart = 59667, RefRangeEnd = 59946, XrefRangeStart = 59667, XrefRangeEnd = 59946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0000A011 File Offset: 0x00008211
		public Behaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
