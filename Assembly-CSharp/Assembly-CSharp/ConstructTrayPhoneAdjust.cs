using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200002E RID: 46
public class ConstructTrayPhoneAdjust : MonoBehaviour
{
	// Token: 0x060008FE RID: 2302 RVA: 0x00034634 File Offset: 0x00032834
	// Note: this type is marked as 'beforefieldinit'.
	static ConstructTrayPhoneAdjust()
	{
		Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ConstructTrayPhoneAdjust");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr);
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_verticalHeightAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_verticalHeightAdjust");
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_constructTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_constructTray");
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_trayAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_trayAnimationTime");
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_bCurrentTrayState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_bCurrentTrayState");
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_currentAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_currentAdjust");
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_initialValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_initialValue");
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_animtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_animtime");
		ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_bAnimating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, "m_bAnimating");
		ConstructTrayPhoneAdjust.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, 100663900);
		ConstructTrayPhoneAdjust.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, 100663901);
		ConstructTrayPhoneAdjust.NativeMethodInfoPtr_SetTrayAdjust_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, 100663902);
		ConstructTrayPhoneAdjust.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr, 100663903);
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00034754 File Offset: 0x00032954
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235318, XrefRangeEnd = 235332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructTrayPhoneAdjust.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00034788 File Offset: 0x00032988
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235332, XrefRangeEnd = 235337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructTrayPhoneAdjust.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x000347BC File Offset: 0x000329BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235346, RefRangeEnd = 235348, XrefRangeStart = 235337, XrefRangeEnd = 235346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTrayAdjust(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructTrayPhoneAdjust.NativeMethodInfoPtr_SetTrayAdjust_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x000347FC File Offset: 0x000329FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235348, XrefRangeEnd = 235349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConstructTrayPhoneAdjust()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructTrayPhoneAdjust>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructTrayPhoneAdjust.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x0000796F File Offset: 0x00005B6F
	public ConstructTrayPhoneAdjust(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x06000904 RID: 2308 RVA: 0x00034838 File Offset: 0x00032A38
	// (set) Token: 0x06000905 RID: 2309 RVA: 0x00007978 File Offset: 0x00005B78
	public unsafe float m_verticalHeightAdjust
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_verticalHeightAdjust);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_verticalHeightAdjust)) = value;
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x06000906 RID: 2310 RVA: 0x00034860 File Offset: 0x00032A60
	// (set) Token: 0x06000907 RID: 2311 RVA: 0x00007993 File Offset: 0x00005B93
	public unsafe TrayToggle m_constructTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_constructTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_constructTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x06000908 RID: 2312 RVA: 0x00034890 File Offset: 0x00032A90
	// (set) Token: 0x06000909 RID: 2313 RVA: 0x000079B2 File Offset: 0x00005BB2
	public unsafe float m_trayAnimationTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_trayAnimationTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_trayAnimationTime)) = value;
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x0600090A RID: 2314 RVA: 0x000348B8 File Offset: 0x00032AB8
	// (set) Token: 0x0600090B RID: 2315 RVA: 0x000079CD File Offset: 0x00005BCD
	public unsafe bool m_bCurrentTrayState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_bCurrentTrayState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_bCurrentTrayState)) = value;
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x0600090C RID: 2316 RVA: 0x000348E0 File Offset: 0x00032AE0
	// (set) Token: 0x0600090D RID: 2317 RVA: 0x000079E8 File Offset: 0x00005BE8
	public unsafe float m_currentAdjust
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_currentAdjust);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_currentAdjust)) = value;
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x0600090E RID: 2318 RVA: 0x00034908 File Offset: 0x00032B08
	// (set) Token: 0x0600090F RID: 2319 RVA: 0x00007A03 File Offset: 0x00005C03
	public unsafe float m_initialValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_initialValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_initialValue)) = value;
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x06000910 RID: 2320 RVA: 0x00034930 File Offset: 0x00032B30
	// (set) Token: 0x06000911 RID: 2321 RVA: 0x00007A1E File Offset: 0x00005C1E
	public unsafe float m_animtime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_animtime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_animtime)) = value;
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x06000912 RID: 2322 RVA: 0x00034958 File Offset: 0x00032B58
	// (set) Token: 0x06000913 RID: 2323 RVA: 0x00007A39 File Offset: 0x00005C39
	public unsafe bool m_bAnimating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_bAnimating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructTrayPhoneAdjust.NativeFieldInfoPtr_m_bAnimating)) = value;
		}
	}

	// Token: 0x04000596 RID: 1430
	private static readonly IntPtr NativeFieldInfoPtr_m_verticalHeightAdjust;

	// Token: 0x04000597 RID: 1431
	private static readonly IntPtr NativeFieldInfoPtr_m_constructTray;

	// Token: 0x04000598 RID: 1432
	private static readonly IntPtr NativeFieldInfoPtr_m_trayAnimationTime;

	// Token: 0x04000599 RID: 1433
	private static readonly IntPtr NativeFieldInfoPtr_m_bCurrentTrayState;

	// Token: 0x0400059A RID: 1434
	private static readonly IntPtr NativeFieldInfoPtr_m_currentAdjust;

	// Token: 0x0400059B RID: 1435
	private static readonly IntPtr NativeFieldInfoPtr_m_initialValue;

	// Token: 0x0400059C RID: 1436
	private static readonly IntPtr NativeFieldInfoPtr_m_animtime;

	// Token: 0x0400059D RID: 1437
	private static readonly IntPtr NativeFieldInfoPtr_m_bAnimating;

	// Token: 0x0400059E RID: 1438
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400059F RID: 1439
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040005A0 RID: 1440
	private static readonly IntPtr NativeMethodInfoPtr_SetTrayAdjust_Private_Void_Single_0;

	// Token: 0x040005A1 RID: 1441
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
