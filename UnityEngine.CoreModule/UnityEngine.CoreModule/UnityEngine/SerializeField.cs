using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000CC RID: 204
	public sealed class SerializeField : Attribute
	{
		// Token: 0x06001198 RID: 4504 RVA: 0x0000A861 File Offset: 0x00008A61
		// Note: this type is marked as 'beforefieldinit'.
		static SerializeField()
		{
			Il2CppClassPointerStore<SerializeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SerializeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeField>.NativeClassPtr);
			SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeField>.NativeClassPtr, 100664538);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00047628 File Offset: 0x00045828
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializeField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0000A89A File Offset: 0x00008A9A
		public SerializeField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
