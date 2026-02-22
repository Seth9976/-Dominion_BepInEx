using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200005F RID: 95
public class GP_QuestResult : GooglePlayResult
{
	// Token: 0x06000735 RID: 1845 RVA: 0x0002F814 File Offset: 0x0002DA14
	// Note: this type is marked as 'beforefieldinit'.
	static GP_QuestResult()
	{
		Il2CppClassPointerStore<GP_QuestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_QuestResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_QuestResult>.NativeClassPtr);
		GP_QuestResult.NativeFieldInfoPtr_quest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_QuestResult>.NativeClassPtr, "quest");
		GP_QuestResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_QuestResult>.NativeClassPtr, 100664152);
		GP_QuestResult.NativeMethodInfoPtr_GetQuest_Public_GP_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_QuestResult>.NativeClassPtr, 100664153);
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x0002F880 File Offset: 0x0002DA80
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_QuestResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_QuestResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_QuestResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x0002F8CC File Offset: 0x0002DACC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Quest GetQuest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_QuestResult.NativeMethodInfoPtr_GetQuest_Public_GP_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Quest>(intPtr3) : null;
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00004FEA File Offset: 0x000031EA
	public GP_QuestResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x06000739 RID: 1849 RVA: 0x0002F90C File Offset: 0x0002DB0C
	// (set) Token: 0x0600073A RID: 1850 RVA: 0x00004FF3 File Offset: 0x000031F3
	public unsafe GP_Quest quest
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_QuestResult.NativeFieldInfoPtr_quest);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_Quest>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_QuestResult.NativeFieldInfoPtr_quest), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040005CF RID: 1487
	private static readonly IntPtr NativeFieldInfoPtr_quest;

	// Token: 0x040005D0 RID: 1488
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x040005D1 RID: 1489
	private static readonly IntPtr NativeMethodInfoPtr_GetQuest_Public_GP_Quest_0;
}
