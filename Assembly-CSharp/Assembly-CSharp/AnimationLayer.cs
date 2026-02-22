using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200007E RID: 126
public class AnimationLayer : MonoBehaviour
{
	// Token: 0x06000FF3 RID: 4083 RVA: 0x00048CFC File Offset: 0x00046EFC
	// Note: this type is marked as 'beforefieldinit'.
	static AnimationLayer()
	{
		Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimationLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr);
		AnimationLayer.NativeFieldInfoPtr_m_LayerAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr, "m_LayerAbove");
		AnimationLayer.NativeFieldInfoPtr_m_LayerAboveThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr, "m_LayerAboveThreshold");
		AnimationLayer.NativeFieldInfoPtr_m_LayerBelow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr, "m_LayerBelow");
		AnimationLayer.NativeFieldInfoPtr_m_LayerBelowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr, "m_LayerBelowThreshold");
		AnimationLayer.NativeMethodInfoPtr_AddAnimation_Public_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr, 100664456);
		AnimationLayer.NativeMethodInfoPtr_UpdateAnimation_Public_Void_AnimateObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr, 100664457);
		AnimationLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr, 100664458);
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00048DB8 File Offset: 0x00046FB8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 241055, RefRangeEnd = 241059, XrefRangeStart = 241031, XrefRangeEnd = 241055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAnimation(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayer.NativeMethodInfoPtr_AddAnimation_Public_Void_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x00048DFC File Offset: 0x00046FFC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241075, RefRangeEnd = 241076, XrefRangeStart = 241059, XrefRangeEnd = 241075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAnimation(AnimateObject animate_object, float previousHeight, float updateHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousHeight;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateHeight;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayer.NativeMethodInfoPtr_UpdateAnimation_Public_Void_AnimateObject_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00048E5C File Offset: 0x0004705C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationLayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationLayer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0000B25B File Offset: 0x0000945B
	public AnimationLayer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00048E98 File Offset: 0x00047098
	// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0000B264 File Offset: 0x00009464
	public unsafe AnimationLayer m_LayerAbove
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerAbove);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLayer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerAbove), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00048EC8 File Offset: 0x000470C8
	// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0000B283 File Offset: 0x00009483
	public unsafe float m_LayerAboveThreshold
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerAboveThreshold);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerAboveThreshold)) = value;
		}
	}

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00048EF0 File Offset: 0x000470F0
	// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0000B29E File Offset: 0x0000949E
	public unsafe AnimationLayer m_LayerBelow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerBelow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLayer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerBelow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00048F20 File Offset: 0x00047120
	// (set) Token: 0x06000FFF RID: 4095 RVA: 0x0000B2BD File Offset: 0x000094BD
	public unsafe float m_LayerBelowThreshold
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerBelowThreshold);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLayer.NativeFieldInfoPtr_m_LayerBelowThreshold)) = value;
		}
	}

	// Token: 0x04000B2F RID: 2863
	private static readonly IntPtr NativeFieldInfoPtr_m_LayerAbove;

	// Token: 0x04000B30 RID: 2864
	private static readonly IntPtr NativeFieldInfoPtr_m_LayerAboveThreshold;

	// Token: 0x04000B31 RID: 2865
	private static readonly IntPtr NativeFieldInfoPtr_m_LayerBelow;

	// Token: 0x04000B32 RID: 2866
	private static readonly IntPtr NativeFieldInfoPtr_m_LayerBelowThreshold;

	// Token: 0x04000B33 RID: 2867
	private static readonly IntPtr NativeMethodInfoPtr_AddAnimation_Public_Void_AnimateObject_0;

	// Token: 0x04000B34 RID: 2868
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimation_Public_Void_AnimateObject_Single_Single_0;

	// Token: 0x04000B35 RID: 2869
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
