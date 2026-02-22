using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class GoogleMobileAdBanner : Il2CppObjectBase
{
	// Token: 0x060000ED RID: 237 RVA: 0x0001A1B0 File Offset: 0x000183B0
	// Note: this type is marked as 'beforefieldinit'.
	static GoogleMobileAdBanner()
	{
		Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GoogleMobileAdBanner");
		GoogleMobileAdBanner.NativeMethodInfoPtr_Hide_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663437);
		GoogleMobileAdBanner.NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663438);
		GoogleMobileAdBanner.NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663439);
		GoogleMobileAdBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663440);
		GoogleMobileAdBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Abstract_Virtual_New_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663441);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663442);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_width_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663443);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_height_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663444);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_IsLoaded_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663445);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_IsOnScreen_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663446);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_ShowOnLoad_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663447);
		GoogleMobileAdBanner.NativeMethodInfoPtr_set_ShowOnLoad_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663448);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_size_Public_Abstract_Virtual_New_get_GADBannerSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663449);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_anchor_Public_Abstract_Virtual_New_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663450);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnLoadedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663451);
		GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnLoadedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663452);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnFailedLoadingAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663453);
		GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnFailedLoadingAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663454);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnOpenedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663455);
		GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnOpenedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663456);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnClosedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663457);
		GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnClosedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663458);
		GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnLeftApplicationAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663459);
		GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnLeftApplicationAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdBanner>.NativeClassPtr, 100663460);
	}

	// Token: 0x060000EE RID: 238 RVA: 0x0001A3B8 File Offset: 0x000185B8
	[CallerCount(0)]
	public unsafe virtual void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_Hide_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0001A3F4 File Offset: 0x000185F4
	[CallerCount(0)]
	public unsafe virtual void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0001A430 File Offset: 0x00018630
	[CallerCount(0)]
	public unsafe virtual void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0001A46C File Offset: 0x0001866C
	[CallerCount(0)]
	public unsafe virtual void SetBannerPosition(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x0001A4C4 File Offset: 0x000186C4
	[CallerCount(0)]
	public unsafe virtual void SetBannerPosition(TextAnchor anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Abstract_Virtual_New_Void_TextAnchor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000F3 RID: 243 RVA: 0x0001A510 File Offset: 0x00018710
	public unsafe virtual int id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x0001A558 File Offset: 0x00018758
	public unsafe virtual int width
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_width_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000F5 RID: 245 RVA: 0x0001A5A0 File Offset: 0x000187A0
	public unsafe virtual int height
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_height_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x0001A5E8 File Offset: 0x000187E8
	public unsafe virtual bool IsLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_IsLoaded_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000F7 RID: 247 RVA: 0x0001A630 File Offset: 0x00018830
	public unsafe virtual bool IsOnScreen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_IsOnScreen_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x0001A678 File Offset: 0x00018878
	// (set) Token: 0x060000F9 RID: 249 RVA: 0x0001A6C0 File Offset: 0x000188C0
	public unsafe virtual bool ShowOnLoad
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_ShowOnLoad_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_set_ShowOnLoad_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000FA RID: 250 RVA: 0x0001A70C File Offset: 0x0001890C
	public unsafe virtual GADBannerSize size
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_size_Public_Abstract_Virtual_New_get_GADBannerSize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000FB RID: 251 RVA: 0x0001A754 File Offset: 0x00018954
	public unsafe virtual TextAnchor anchor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_anchor_Public_Abstract_Virtual_New_get_TextAnchor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000FC RID: 252 RVA: 0x0001A79C File Offset: 0x0001899C
	// (set) Token: 0x060000FD RID: 253 RVA: 0x0001A7E8 File Offset: 0x000189E8
	public unsafe virtual Action<GoogleMobileAdBanner> OnLoadedAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnLoadedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnLoadedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000FE RID: 254 RVA: 0x0001A838 File Offset: 0x00018A38
	// (set) Token: 0x060000FF RID: 255 RVA: 0x0001A884 File Offset: 0x00018A84
	public unsafe virtual Action<GoogleMobileAdBanner> OnFailedLoadingAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnFailedLoadingAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnFailedLoadingAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000100 RID: 256 RVA: 0x0001A8D4 File Offset: 0x00018AD4
	// (set) Token: 0x06000101 RID: 257 RVA: 0x0001A920 File Offset: 0x00018B20
	public unsafe virtual Action<GoogleMobileAdBanner> OnOpenedAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnOpenedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnOpenedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000102 RID: 258 RVA: 0x0001A970 File Offset: 0x00018B70
	// (set) Token: 0x06000103 RID: 259 RVA: 0x0001A9BC File Offset: 0x00018BBC
	public unsafe virtual Action<GoogleMobileAdBanner> OnClosedAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnClosedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnClosedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000104 RID: 260 RVA: 0x0001AA0C File Offset: 0x00018C0C
	// (set) Token: 0x06000105 RID: 261 RVA: 0x0001AA58 File Offset: 0x00018C58
	public unsafe virtual Action<GoogleMobileAdBanner> OnLeftApplicationAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_get_OnLeftApplicationAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdBanner.NativeMethodInfoPtr_set_OnLeftApplicationAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x000024A1 File Offset: 0x000006A1
	public GoogleMobileAdBanner(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040000E4 RID: 228
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040000E5 RID: 229
	private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040000E6 RID: 230
	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040000E7 RID: 231
	private static readonly IntPtr NativeMethodInfoPtr_SetBannerPosition_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

	// Token: 0x040000E8 RID: 232
	private static readonly IntPtr NativeMethodInfoPtr_SetBannerPosition_Public_Abstract_Virtual_New_Void_TextAnchor_0;

	// Token: 0x040000E9 RID: 233
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0;

	// Token: 0x040000EA RID: 234
	private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Abstract_Virtual_New_get_Int32_0;

	// Token: 0x040000EB RID: 235
	private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Abstract_Virtual_New_get_Int32_0;

	// Token: 0x040000EC RID: 236
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLoaded_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x040000ED RID: 237
	private static readonly IntPtr NativeMethodInfoPtr_get_IsOnScreen_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x040000EE RID: 238
	private static readonly IntPtr NativeMethodInfoPtr_get_ShowOnLoad_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x040000EF RID: 239
	private static readonly IntPtr NativeMethodInfoPtr_set_ShowOnLoad_Public_Abstract_Virtual_New_set_Void_Boolean_0;

	// Token: 0x040000F0 RID: 240
	private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_Abstract_Virtual_New_get_GADBannerSize_0;

	// Token: 0x040000F1 RID: 241
	private static readonly IntPtr NativeMethodInfoPtr_get_anchor_Public_Abstract_Virtual_New_get_TextAnchor_0;

	// Token: 0x040000F2 RID: 242
	private static readonly IntPtr NativeMethodInfoPtr_get_OnLoadedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000F3 RID: 243
	private static readonly IntPtr NativeMethodInfoPtr_set_OnLoadedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000F4 RID: 244
	private static readonly IntPtr NativeMethodInfoPtr_get_OnFailedLoadingAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000F5 RID: 245
	private static readonly IntPtr NativeMethodInfoPtr_set_OnFailedLoadingAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000F6 RID: 246
	private static readonly IntPtr NativeMethodInfoPtr_get_OnOpenedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000F7 RID: 247
	private static readonly IntPtr NativeMethodInfoPtr_set_OnOpenedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000F8 RID: 248
	private static readonly IntPtr NativeMethodInfoPtr_get_OnClosedAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000F9 RID: 249
	private static readonly IntPtr NativeMethodInfoPtr_set_OnClosedAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000FA RID: 250
	private static readonly IntPtr NativeMethodInfoPtr_get_OnLeftApplicationAction_Public_Abstract_Virtual_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x040000FB RID: 251
	private static readonly IntPtr NativeMethodInfoPtr_set_OnLeftApplicationAction_Public_Abstract_Virtual_New_set_Void_Action_1_GoogleMobileAdBanner_0;
}
