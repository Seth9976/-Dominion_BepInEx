using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000B3 RID: 179
[Serializable]
public class UIC_ScreenResolutionList : global::Il2CppSystem.Object
{
	// Token: 0x06001533 RID: 5427 RVA: 0x0005A6E0 File Offset: 0x000588E0
	// Note: this type is marked as 'beforefieldinit'.
	static UIC_ScreenResolutionList()
	{
		Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIC_ScreenResolutionList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr);
		UIC_ScreenResolutionList.NativeFieldInfoPtr_m_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, "m_buttonPrefab");
		UIC_ScreenResolutionList.NativeFieldInfoPtr_m_contentPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, "m_contentPanel");
		UIC_ScreenResolutionList.NativeFieldInfoPtr_m_screenResolutionListGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, "m_screenResolutionListGameObjects");
		UIC_ScreenResolutionList.NativeFieldInfoPtr_m_availableResolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, "m_availableResolutions");
		UIC_ScreenResolutionList.NativeFieldInfoPtr_m_clickCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, "m_clickCallback");
		UIC_ScreenResolutionList.NativeFieldInfoPtr_m_createdResolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, "m_createdResolutions");
		UIC_ScreenResolutionList.NativeMethodInfoPtr_PopulateScreenResolutionList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, 100665009);
		UIC_ScreenResolutionList.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, 100665010);
		UIC_ScreenResolutionList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_ScreenResolutionSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, 100665011);
		UIC_ScreenResolutionList.NativeMethodInfoPtr_DestroyScreenResolutionList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, 100665012);
		UIC_ScreenResolutionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, 100665013);
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x0005A7EC File Offset: 0x000589EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246887, XrefRangeEnd = 246950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateScreenResolutionList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.NativeMethodInfoPtr_PopulateScreenResolutionList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x0005A820 File Offset: 0x00058A20
	[CallerCount(0)]
	public unsafe void SetClickListener(UIC_ScreenResolutionList.ClickCallback cb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x0005A864 File Offset: 0x00058A64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246950, XrefRangeEnd = 246951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlot(UIP_ScreenResolutionSlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_ScreenResolutionSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0005A8A8 File Offset: 0x00058AA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246975, RefRangeEnd = 246976, XrefRangeStart = 246951, XrefRangeEnd = 246975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyScreenResolutionList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.NativeMethodInfoPtr_DestroyScreenResolutionList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x0005A8DC File Offset: 0x00058ADC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246976, XrefRangeEnd = 246983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIC_ScreenResolutionList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x0000DB44 File Offset: 0x0000BD44
	public UIC_ScreenResolutionList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x0600153A RID: 5434 RVA: 0x0005A918 File Offset: 0x00058B18
	// (set) Token: 0x0600153B RID: 5435 RVA: 0x0000DB4D File Offset: 0x0000BD4D
	public unsafe GameObject m_buttonPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_buttonPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x0600153C RID: 5436 RVA: 0x0005A948 File Offset: 0x00058B48
	// (set) Token: 0x0600153D RID: 5437 RVA: 0x0000DB6C File Offset: 0x0000BD6C
	public unsafe Transform m_contentPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_contentPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_contentPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x0600153E RID: 5438 RVA: 0x0005A978 File Offset: 0x00058B78
	// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000DB8B File Offset: 0x0000BD8B
	public unsafe List<GameObject> m_screenResolutionListGameObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_screenResolutionListGameObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_screenResolutionListGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x06001540 RID: 5440 RVA: 0x0005A9A8 File Offset: 0x00058BA8
	// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000DBAA File Offset: 0x0000BDAA
	public unsafe Il2CppStructArray<Resolution> m_availableResolutions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_availableResolutions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_availableResolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x06001542 RID: 5442 RVA: 0x0005A9D8 File Offset: 0x00058BD8
	// (set) Token: 0x06001543 RID: 5443 RVA: 0x0000DBC9 File Offset: 0x0000BDC9
	public unsafe UIC_ScreenResolutionList.ClickCallback m_clickCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_clickCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_ScreenResolutionList.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_clickCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x06001544 RID: 5444 RVA: 0x0005AA08 File Offset: 0x00058C08
	// (set) Token: 0x06001545 RID: 5445 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
	public unsafe List<string> m_createdResolutions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_createdResolutions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_ScreenResolutionList.NativeFieldInfoPtr_m_createdResolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000EBB RID: 3771
	private static readonly IntPtr NativeFieldInfoPtr_m_buttonPrefab;

	// Token: 0x04000EBC RID: 3772
	private static readonly IntPtr NativeFieldInfoPtr_m_contentPanel;

	// Token: 0x04000EBD RID: 3773
	private static readonly IntPtr NativeFieldInfoPtr_m_screenResolutionListGameObjects;

	// Token: 0x04000EBE RID: 3774
	private static readonly IntPtr NativeFieldInfoPtr_m_availableResolutions;

	// Token: 0x04000EBF RID: 3775
	private static readonly IntPtr NativeFieldInfoPtr_m_clickCallback;

	// Token: 0x04000EC0 RID: 3776
	private static readonly IntPtr NativeFieldInfoPtr_m_createdResolutions;

	// Token: 0x04000EC1 RID: 3777
	private static readonly IntPtr NativeMethodInfoPtr_PopulateScreenResolutionList_Public_Void_0;

	// Token: 0x04000EC2 RID: 3778
	private static readonly IntPtr NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0;

	// Token: 0x04000EC3 RID: 3779
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_ScreenResolutionSlot_0;

	// Token: 0x04000EC4 RID: 3780
	private static readonly IntPtr NativeMethodInfoPtr_DestroyScreenResolutionList_Private_Void_0;

	// Token: 0x04000EC5 RID: 3781
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001C8 RID: 456
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x06002678 RID: 9848 RVA: 0x0008D3C0 File Offset: 0x0008B5C0
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIC_ScreenResolutionList.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_ScreenResolutionList>.NativeClassPtr, "ClickCallback");
			UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList.ClickCallback>.NativeClassPtr, 100666346);
			UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList.ClickCallback>.NativeClassPtr, 100666347);
			UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Resolution_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList.ClickCallback>.NativeClassPtr, 100666348);
			UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_ScreenResolutionList.ClickCallback>.NativeClassPtr, 100666349);
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0008D434 File Offset: 0x0008B634
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_ScreenResolutionList.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x0008D490 File Offset: 0x0008B690
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246880, RefRangeEnd = 246883, XrefRangeStart = 246874, XrefRangeEnd = 246880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Resolution selectedResolution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectedResolution;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246883, XrefRangeEnd = 246887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Resolution selectedResolution, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectedResolution;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Resolution_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0008D540 File Offset: 0x0008B740
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_ScreenResolutionList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00017C44 File Offset: 0x00015E44
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00017C4D File Offset: 0x00015E4D
		public static implicit operator UIC_ScreenResolutionList.ClickCallback(Action<Resolution> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIC_ScreenResolutionList.ClickCallback>(A_0);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00017C55 File Offset: 0x00015E55
		public static UIC_ScreenResolutionList.ClickCallback operator +(UIC_ScreenResolutionList.ClickCallback A_0, UIC_ScreenResolutionList.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIC_ScreenResolutionList.ClickCallback>();
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00017C63 File Offset: 0x00015E63
		public static UIC_ScreenResolutionList.ClickCallback operator -(UIC_ScreenResolutionList.ClickCallback A_0, UIC_ScreenResolutionList.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIC_ScreenResolutionList.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Resolution_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Resolution_AsyncCallback_Object_0;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
