using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000033 RID: 51
public class GlowColorAdjust : MonoBehaviour
{
	// Token: 0x0600096A RID: 2410 RVA: 0x00035BF8 File Offset: 0x00033DF8
	// Note: this type is marked as 'beforefieldinit'.
	static GlowColorAdjust()
	{
		Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GlowColorAdjust");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr);
		GlowColorAdjust.NativeFieldInfoPtr_m_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, "m_DefaultColor");
		GlowColorAdjust.NativeFieldInfoPtr_m_GlowGraphicList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, "m_GlowGraphicList");
		GlowColorAdjust.NativeFieldInfoPtr_m_GlowParticleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, "m_GlowParticleList");
		GlowColorAdjust.NativeFieldInfoPtr_m_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, "m_particles");
		GlowColorAdjust.NativeFieldInfoPtr_m_bInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, "m_bInit");
		GlowColorAdjust.NativeFieldInfoPtr_m_CurrentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, "m_CurrentColor");
		GlowColorAdjust.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, 100663943);
		GlowColorAdjust.NativeMethodInfoPtr_SetDefaultColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, 100663944);
		GlowColorAdjust.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, 100663945);
		GlowColorAdjust.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, 100663946);
		GlowColorAdjust.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr, 100663947);
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00035D04 File Offset: 0x00033F04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235714, XrefRangeEnd = 235716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlowColorAdjust.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00035D38 File Offset: 0x00033F38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235716, XrefRangeEnd = 235717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlowColorAdjust.NativeMethodInfoPtr_SetDefaultColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00035D6C File Offset: 0x00033F6C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 235736, RefRangeEnd = 235741, XrefRangeStart = 235717, XrefRangeEnd = 235736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(Color newColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref newColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlowColorAdjust.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00035DAC File Offset: 0x00033FAC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235753, RefRangeEnd = 235755, XrefRangeStart = 235741, XrefRangeEnd = 235753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlowColorAdjust.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00035DE0 File Offset: 0x00033FE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235755, XrefRangeEnd = 235757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlowColorAdjust()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlowColorAdjust>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlowColorAdjust.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00007C88 File Offset: 0x00005E88
	public GlowColorAdjust(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06000971 RID: 2417 RVA: 0x00035E1C File Offset: 0x0003401C
	// (set) Token: 0x06000972 RID: 2418 RVA: 0x00007C91 File Offset: 0x00005E91
	public unsafe Color m_DefaultColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_DefaultColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_DefaultColor)) = value;
		}
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06000973 RID: 2419 RVA: 0x00035E44 File Offset: 0x00034044
	// (set) Token: 0x06000974 RID: 2420 RVA: 0x00007CAC File Offset: 0x00005EAC
	public unsafe Il2CppReferenceArray<Graphic> m_GlowGraphicList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_GlowGraphicList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Graphic>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_GlowGraphicList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06000975 RID: 2421 RVA: 0x00035E74 File Offset: 0x00034074
	// (set) Token: 0x06000976 RID: 2422 RVA: 0x00007CCB File Offset: 0x00005ECB
	public unsafe Il2CppReferenceArray<ParticleSystem> m_GlowParticleList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_GlowParticleList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_GlowParticleList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06000977 RID: 2423 RVA: 0x00035EA4 File Offset: 0x000340A4
	// (set) Token: 0x06000978 RID: 2424 RVA: 0x00007CEA File Offset: 0x00005EEA
	public unsafe Il2CppStructArray<ParticleSystem.Particle> m_particles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_particles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParticleSystem.Particle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06000979 RID: 2425 RVA: 0x00035ED4 File Offset: 0x000340D4
	// (set) Token: 0x0600097A RID: 2426 RVA: 0x00007D09 File Offset: 0x00005F09
	public unsafe bool m_bInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_bInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_bInit)) = value;
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x0600097B RID: 2427 RVA: 0x00035EFC File Offset: 0x000340FC
	// (set) Token: 0x0600097C RID: 2428 RVA: 0x00007D24 File Offset: 0x00005F24
	public unsafe Color m_CurrentColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_CurrentColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlowColorAdjust.NativeFieldInfoPtr_m_CurrentColor)) = value;
		}
	}

	// Token: 0x040005DC RID: 1500
	private static readonly IntPtr NativeFieldInfoPtr_m_DefaultColor;

	// Token: 0x040005DD RID: 1501
	private static readonly IntPtr NativeFieldInfoPtr_m_GlowGraphicList;

	// Token: 0x040005DE RID: 1502
	private static readonly IntPtr NativeFieldInfoPtr_m_GlowParticleList;

	// Token: 0x040005DF RID: 1503
	private static readonly IntPtr NativeFieldInfoPtr_m_particles;

	// Token: 0x040005E0 RID: 1504
	private static readonly IntPtr NativeFieldInfoPtr_m_bInit;

	// Token: 0x040005E1 RID: 1505
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentColor;

	// Token: 0x040005E2 RID: 1506
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040005E3 RID: 1507
	private static readonly IntPtr NativeMethodInfoPtr_SetDefaultColor_Public_Void_0;

	// Token: 0x040005E4 RID: 1508
	private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

	// Token: 0x040005E5 RID: 1509
	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	// Token: 0x040005E6 RID: 1510
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
