using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SA.Common.Animation;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000143 RID: 323
public class SA_Notifications_EditorUIController : MonoBehaviour
{
	// Token: 0x060017D3 RID: 6099 RVA: 0x00069120 File Offset: 0x00067320
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Notifications_EditorUIController()
	{
		Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_Notifications_EditorUIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr);
		SA_Notifications_EditorUIController.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, "Title");
		SA_Notifications_EditorUIController.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, "Message");
		SA_Notifications_EditorUIController.NativeFieldInfoPtr_Icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, "Icons");
		SA_Notifications_EditorUIController.NativeFieldInfoPtr_HightDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, "HightDependence");
		SA_Notifications_EditorUIController.NativeFieldInfoPtr__CurrentTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, "_CurrentTween");
		SA_Notifications_EditorUIController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666189);
		SA_Notifications_EditorUIController.NativeMethodInfoPtr_ShowNotification_Public_Void_String_String_SA_EditorNotificationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666190);
		SA_Notifications_EditorUIController.NativeMethodInfoPtr_HandleOnInTweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666191);
		SA_Notifications_EditorUIController.NativeMethodInfoPtr_NotificationDelayComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666192);
		SA_Notifications_EditorUIController.NativeMethodInfoPtr_HandleOnOutTweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666193);
		SA_Notifications_EditorUIController.NativeMethodInfoPtr_HandleOnValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666194);
		SA_Notifications_EditorUIController.NativeMethodInfoPtr_Animate_Private_Void_Single_Single_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666195);
		SA_Notifications_EditorUIController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr, 100666196);
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x00069254 File Offset: 0x00067454
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194630, XrefRangeEnd = 194641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x00069288 File Offset: 0x00067488
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194641, XrefRangeEnd = 194676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowNotification(string title, string message, SA_EditorNotificationType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr_ShowNotification_Public_Void_String_String_SA_EditorNotificationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x000692EC File Offset: 0x000674EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194677, XrefRangeEnd = 194680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnInTweenComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr_HandleOnInTweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x00069320 File Offset: 0x00067520
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194680, XrefRangeEnd = 194689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotificationDelayComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr_NotificationDelayComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x00069354 File Offset: 0x00067554
	[CallerCount(0)]
	public unsafe void HandleOnOutTweenComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr_HandleOnOutTweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x00069388 File Offset: 0x00067588
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194689, XrefRangeEnd = 194691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnValueChanged(float pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr_HandleOnValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x000693C8 File Offset: 0x000675C8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194702, RefRangeEnd = 194704, XrefRangeStart = 194691, XrefRangeEnd = 194702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Animate(float from, float to, EaseType easeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref from;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr_Animate_Private_Void_Single_Single_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00069424 File Offset: 0x00067624
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_Notifications_EditorUIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Notifications_EditorUIController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Notifications_EditorUIController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x0000B7BE File Offset: 0x000099BE
	public SA_Notifications_EditorUIController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x060017DD RID: 6109 RVA: 0x00069460 File Offset: 0x00067660
	// (set) Token: 0x060017DE RID: 6110 RVA: 0x0000B7C7 File Offset: 0x000099C7
	public unsafe Text Title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_Title);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x060017DF RID: 6111 RVA: 0x00069490 File Offset: 0x00067690
	// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0000B7E6 File Offset: 0x000099E6
	public unsafe Text Message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_Message);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x060017E1 RID: 6113 RVA: 0x000694C0 File Offset: 0x000676C0
	// (set) Token: 0x060017E2 RID: 6114 RVA: 0x0000B805 File Offset: 0x00009A05
	public unsafe Il2CppReferenceArray<Image> Icons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_Icons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_Icons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x060017E3 RID: 6115 RVA: 0x000694F0 File Offset: 0x000676F0
	// (set) Token: 0x060017E4 RID: 6116 RVA: 0x0000B824 File Offset: 0x00009A24
	public unsafe SA_UIHightDependence HightDependence
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_HightDependence);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_UIHightDependence>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr_HightDependence), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00069520 File Offset: 0x00067720
	// (set) Token: 0x060017E6 RID: 6118 RVA: 0x0000B843 File Offset: 0x00009A43
	public unsafe ValuesTween _CurrentTween
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr__CurrentTween);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValuesTween>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Notifications_EditorUIController.NativeFieldInfoPtr__CurrentTween), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001207 RID: 4615
	private static readonly IntPtr NativeFieldInfoPtr_Title;

	// Token: 0x04001208 RID: 4616
	private static readonly IntPtr NativeFieldInfoPtr_Message;

	// Token: 0x04001209 RID: 4617
	private static readonly IntPtr NativeFieldInfoPtr_Icons;

	// Token: 0x0400120A RID: 4618
	private static readonly IntPtr NativeFieldInfoPtr_HightDependence;

	// Token: 0x0400120B RID: 4619
	private static readonly IntPtr NativeFieldInfoPtr__CurrentTween;

	// Token: 0x0400120C RID: 4620
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400120D RID: 4621
	private static readonly IntPtr NativeMethodInfoPtr_ShowNotification_Public_Void_String_String_SA_EditorNotificationType_0;

	// Token: 0x0400120E RID: 4622
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnInTweenComplete_Private_Void_0;

	// Token: 0x0400120F RID: 4623
	private static readonly IntPtr NativeMethodInfoPtr_NotificationDelayComplete_Private_Void_0;

	// Token: 0x04001210 RID: 4624
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnOutTweenComplete_Private_Void_0;

	// Token: 0x04001211 RID: 4625
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnValueChanged_Private_Void_Single_0;

	// Token: 0x04001212 RID: 4626
	private static readonly IntPtr NativeMethodInfoPtr_Animate_Private_Void_Single_Single_EaseType_0;

	// Token: 0x04001213 RID: 4627
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
