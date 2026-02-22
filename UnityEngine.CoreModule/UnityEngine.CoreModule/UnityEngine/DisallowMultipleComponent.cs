using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009F RID: 159
	public sealed class DisallowMultipleComponent : Attribute
	{
		// Token: 0x06000FCA RID: 4042 RVA: 0x00009D34 File Offset: 0x00007F34
		// Note: this type is marked as 'beforefieldinit'.
		static DisallowMultipleComponent()
		{
			Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DisallowMultipleComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr);
			DisallowMultipleComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr, 100664321);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00041664 File Offset: 0x0003F864
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisallowMultipleComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisallowMultipleComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00009D6D File Offset: 0x00007F6D
		public DisallowMultipleComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
