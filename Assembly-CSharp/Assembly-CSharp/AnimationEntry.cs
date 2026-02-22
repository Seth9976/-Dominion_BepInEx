using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000081 RID: 129
public class AnimationEntry : global::Il2CppSystem.Object
{
	// Token: 0x06001026 RID: 4134 RVA: 0x000497C8 File Offset: 0x000479C8
	// Note: this type is marked as 'beforefieldinit'.
	static AnimationEntry()
	{
		Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimationEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr);
		AnimationEntry.NativeFieldInfoPtr_m_AnimateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_AnimateObject");
		AnimationEntry.NativeFieldInfoPtr_m_SourceLocatorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_SourceLocatorIndex");
		AnimationEntry.NativeFieldInfoPtr_m_SourceLocatorInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_SourceLocatorInstanceID");
		AnimationEntry.NativeFieldInfoPtr_m_DestinationLocatorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_DestinationLocatorIndex");
		AnimationEntry.NativeFieldInfoPtr_m_DestinationLocatorInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_DestinationLocatorInstanceID");
		AnimationEntry.NativeFieldInfoPtr_m_AnimationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_AnimationFlags");
		AnimationEntry.NativeFieldInfoPtr_m_DelayAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_DelayAtStart");
		AnimationEntry.NativeFieldInfoPtr_m_PauseAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_PauseAtDestination");
		AnimationEntry.NativeFieldInfoPtr_m_AdditionalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_AdditionalRotation");
		AnimationEntry.NativeFieldInfoPtr_m_bApplyUpdateAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, "m_bApplyUpdateAtDestination");
		AnimationEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr, 100664475);
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x000498D4 File Offset: 0x00047AD4
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x0000B3ED File Offset: 0x000095ED
	public AnimationEntry(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x06001029 RID: 4137 RVA: 0x00049910 File Offset: 0x00047B10
	// (set) Token: 0x0600102A RID: 4138 RVA: 0x0000B3F6 File Offset: 0x000095F6
	public unsafe AnimateObject m_AnimateObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_AnimateObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_AnimateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x0600102B RID: 4139 RVA: 0x00049940 File Offset: 0x00047B40
	// (set) Token: 0x0600102C RID: 4140 RVA: 0x0000B415 File Offset: 0x00009615
	public unsafe int m_SourceLocatorIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_SourceLocatorIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_SourceLocatorIndex)) = value;
		}
	}

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x0600102D RID: 4141 RVA: 0x00049968 File Offset: 0x00047B68
	// (set) Token: 0x0600102E RID: 4142 RVA: 0x0000B430 File Offset: 0x00009630
	public unsafe int m_SourceLocatorInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_SourceLocatorInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_SourceLocatorInstanceID)) = value;
		}
	}

	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x0600102F RID: 4143 RVA: 0x00049990 File Offset: 0x00047B90
	// (set) Token: 0x06001030 RID: 4144 RVA: 0x0000B44B File Offset: 0x0000964B
	public unsafe int m_DestinationLocatorIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_DestinationLocatorIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_DestinationLocatorIndex)) = value;
		}
	}

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x06001031 RID: 4145 RVA: 0x000499B8 File Offset: 0x00047BB8
	// (set) Token: 0x06001032 RID: 4146 RVA: 0x0000B466 File Offset: 0x00009666
	public unsafe int m_DestinationLocatorInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_DestinationLocatorInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_DestinationLocatorInstanceID)) = value;
		}
	}

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x06001033 RID: 4147 RVA: 0x000499E0 File Offset: 0x00047BE0
	// (set) Token: 0x06001034 RID: 4148 RVA: 0x0000B481 File Offset: 0x00009681
	public unsafe uint m_AnimationFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_AnimationFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_AnimationFlags)) = value;
		}
	}

	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x06001035 RID: 4149 RVA: 0x00049A08 File Offset: 0x00047C08
	// (set) Token: 0x06001036 RID: 4150 RVA: 0x0000B49C File Offset: 0x0000969C
	public unsafe float m_DelayAtStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_DelayAtStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_DelayAtStart)) = value;
		}
	}

	// Token: 0x17000563 RID: 1379
	// (get) Token: 0x06001037 RID: 4151 RVA: 0x00049A30 File Offset: 0x00047C30
	// (set) Token: 0x06001038 RID: 4152 RVA: 0x0000B4B7 File Offset: 0x000096B7
	public unsafe float m_PauseAtDestination
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_PauseAtDestination);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_PauseAtDestination)) = value;
		}
	}

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x06001039 RID: 4153 RVA: 0x00049A58 File Offset: 0x00047C58
	// (set) Token: 0x0600103A RID: 4154 RVA: 0x0000B4D2 File Offset: 0x000096D2
	public unsafe Vector3 m_AdditionalRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_AdditionalRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_AdditionalRotation)) = value;
		}
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x0600103B RID: 4155 RVA: 0x00049A80 File Offset: 0x00047C80
	// (set) Token: 0x0600103C RID: 4156 RVA: 0x0000B4ED File Offset: 0x000096ED
	public unsafe bool m_bApplyUpdateAtDestination
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_bApplyUpdateAtDestination);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEntry.NativeFieldInfoPtr_m_bApplyUpdateAtDestination)) = value;
		}
	}

	// Token: 0x04000B4F RID: 2895
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateObject;

	// Token: 0x04000B50 RID: 2896
	private static readonly IntPtr NativeFieldInfoPtr_m_SourceLocatorIndex;

	// Token: 0x04000B51 RID: 2897
	private static readonly IntPtr NativeFieldInfoPtr_m_SourceLocatorInstanceID;

	// Token: 0x04000B52 RID: 2898
	private static readonly IntPtr NativeFieldInfoPtr_m_DestinationLocatorIndex;

	// Token: 0x04000B53 RID: 2899
	private static readonly IntPtr NativeFieldInfoPtr_m_DestinationLocatorInstanceID;

	// Token: 0x04000B54 RID: 2900
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationFlags;

	// Token: 0x04000B55 RID: 2901
	private static readonly IntPtr NativeFieldInfoPtr_m_DelayAtStart;

	// Token: 0x04000B56 RID: 2902
	private static readonly IntPtr NativeFieldInfoPtr_m_PauseAtDestination;

	// Token: 0x04000B57 RID: 2903
	private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalRotation;

	// Token: 0x04000B58 RID: 2904
	private static readonly IntPtr NativeFieldInfoPtr_m_bApplyUpdateAtDestination;

	// Token: 0x04000B59 RID: 2905
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
