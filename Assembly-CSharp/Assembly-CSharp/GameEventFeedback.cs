using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000089 RID: 137
public class GameEventFeedback : Object
{
	// Token: 0x0600113E RID: 4414 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
	// Note: this type is marked as 'beforefieldinit'.
	static GameEventFeedback()
	{
		Il2CppClassPointerStore<GameEventFeedback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameEventFeedback");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEventFeedback>.NativeClassPtr);
		GameEventFeedback.NativeFieldInfoPtr_bBreakFromUpdateLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventFeedback>.NativeClassPtr, "bBreakFromUpdateLoop");
		GameEventFeedback.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventFeedback>.NativeClassPtr, 100664599);
		GameEventFeedback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventFeedback>.NativeClassPtr, 100664600);
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x0004D85C File Offset: 0x0004BA5C
	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventFeedback.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x0004D890 File Offset: 0x0004BA90
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventFeedback()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventFeedback>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventFeedback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x0000BC01 File Offset: 0x00009E01
	public GameEventFeedback(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x06001142 RID: 4418 RVA: 0x0004D8CC File Offset: 0x0004BACC
	// (set) Token: 0x06001143 RID: 4419 RVA: 0x0000BC0A File Offset: 0x00009E0A
	public unsafe bool bBreakFromUpdateLoop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventFeedback.NativeFieldInfoPtr_bBreakFromUpdateLoop);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventFeedback.NativeFieldInfoPtr_bBreakFromUpdateLoop)) = value;
		}
	}

	// Token: 0x04000C11 RID: 3089
	private static readonly IntPtr NativeFieldInfoPtr_bBreakFromUpdateLoop;

	// Token: 0x04000C12 RID: 3090
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	// Token: 0x04000C13 RID: 3091
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
