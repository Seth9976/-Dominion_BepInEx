using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

// Token: 0x0200008A RID: 138
[Serializable]
public class GameEventIntPtr : UnityEvent<IntPtr, GameEventFeedback>
{
	// Token: 0x06001144 RID: 4420 RVA: 0x0000BC25 File Offset: 0x00009E25
	// Note: this type is marked as 'beforefieldinit'.
	static GameEventIntPtr()
	{
		Il2CppClassPointerStore<GameEventIntPtr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameEventIntPtr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEventIntPtr>.NativeClassPtr);
		GameEventIntPtr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventIntPtr>.NativeClassPtr, 100664601);
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x0004D8F4 File Offset: 0x0004BAF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242300, XrefRangeEnd = 242303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventIntPtr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventIntPtr>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventIntPtr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x0000BC5E File Offset: 0x00009E5E
	public GameEventIntPtr(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000C14 RID: 3092
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
