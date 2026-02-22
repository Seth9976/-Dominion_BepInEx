using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000AD RID: 173
public class ScrollRect_AutoScroll : MonoBehaviour
{
	// Token: 0x0600144A RID: 5194 RVA: 0x000579D8 File Offset: 0x00055BD8
	// Note: this type is marked as 'beforefieldinit'.
	static ScrollRect_AutoScroll()
	{
		Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScrollRect_AutoScroll");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr);
		ScrollRect_AutoScroll.NativeFieldInfoPtr_m_AutoScrollVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, "m_AutoScrollVelocity");
		ScrollRect_AutoScroll.NativeFieldInfoPtr_m_bTouching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, "m_bTouching");
		ScrollRect_AutoScroll.NativeFieldInfoPtr_m_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, "m_ScrollRect");
		ScrollRect_AutoScroll.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, 100664928);
		ScrollRect_AutoScroll.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, 100664929);
		ScrollRect_AutoScroll.NativeMethodInfoPtr_ResetScroll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, 100664930);
		ScrollRect_AutoScroll.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, 100664931);
		ScrollRect_AutoScroll.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, 100664932);
		ScrollRect_AutoScroll.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr, 100664933);
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x00057ABC File Offset: 0x00055CBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245783, XrefRangeEnd = 245792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect_AutoScroll.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x00057AF0 File Offset: 0x00055CF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245792, XrefRangeEnd = 245797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect_AutoScroll.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00057B24 File Offset: 0x00055D24
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245799, RefRangeEnd = 245800, XrefRangeStart = 245797, XrefRangeEnd = 245799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetScroll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect_AutoScroll.NativeMethodInfoPtr_ResetScroll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00057B58 File Offset: 0x00055D58
	[CallerCount(0)]
	public unsafe virtual void OnPointerDown(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect_AutoScroll.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x00057B9C File Offset: 0x00055D9C
	[CallerCount(0)]
	public unsafe virtual void OnPointerUp(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect_AutoScroll.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x00057BE0 File Offset: 0x00055DE0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollRect_AutoScroll()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRect_AutoScroll>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect_AutoScroll.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x0000D310 File Offset: 0x0000B510
	public ScrollRect_AutoScroll(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x06001452 RID: 5202 RVA: 0x00057C1C File Offset: 0x00055E1C
	// (set) Token: 0x06001453 RID: 5203 RVA: 0x0000D319 File Offset: 0x0000B519
	public unsafe float m_AutoScrollVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect_AutoScroll.NativeFieldInfoPtr_m_AutoScrollVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect_AutoScroll.NativeFieldInfoPtr_m_AutoScrollVelocity)) = value;
		}
	}

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x06001454 RID: 5204 RVA: 0x00057C44 File Offset: 0x00055E44
	// (set) Token: 0x06001455 RID: 5205 RVA: 0x0000D334 File Offset: 0x0000B534
	public unsafe bool m_bTouching
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect_AutoScroll.NativeFieldInfoPtr_m_bTouching);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect_AutoScroll.NativeFieldInfoPtr_m_bTouching)) = value;
		}
	}

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x06001456 RID: 5206 RVA: 0x00057C6C File Offset: 0x00055E6C
	// (set) Token: 0x06001457 RID: 5207 RVA: 0x0000D34F File Offset: 0x0000B54F
	public unsafe ScrollRect m_ScrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect_AutoScroll.NativeFieldInfoPtr_m_ScrollRect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect_AutoScroll.NativeFieldInfoPtr_m_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000E25 RID: 3621
	private static readonly IntPtr NativeFieldInfoPtr_m_AutoScrollVelocity;

	// Token: 0x04000E26 RID: 3622
	private static readonly IntPtr NativeFieldInfoPtr_m_bTouching;

	// Token: 0x04000E27 RID: 3623
	private static readonly IntPtr NativeFieldInfoPtr_m_ScrollRect;

	// Token: 0x04000E28 RID: 3624
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000E29 RID: 3625
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000E2A RID: 3626
	private static readonly IntPtr NativeMethodInfoPtr_ResetScroll_Public_Void_0;

	// Token: 0x04000E2B RID: 3627
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000E2C RID: 3628
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000E2D RID: 3629
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
