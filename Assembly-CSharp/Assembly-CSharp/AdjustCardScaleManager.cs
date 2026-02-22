using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200000B RID: 11
public class AdjustCardScaleManager : MonoBehaviour
{
	// Token: 0x0600011A RID: 282 RVA: 0x0001DFD4 File Offset: 0x0001C1D4
	// Note: this type is marked as 'beforefieldinit'.
	static AdjustCardScaleManager()
	{
		Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AdjustCardScaleManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr);
		AdjustCardScaleManager.NativeFieldInfoPtr_m_OnResolutionChangeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr, "m_OnResolutionChangeCallback");
		AdjustCardScaleManager.NativeMethodInfoPtr_AddOnResolutionChangeCallback_Public_Void_AdjustCardScaleCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr, 100663386);
		AdjustCardScaleManager.NativeMethodInfoPtr_RemoveOnResolutionChangeCallback_Public_Void_AdjustCardScaleCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr, 100663387);
		AdjustCardScaleManager.NativeMethodInfoPtr_OnResolutionChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr, 100663388);
		AdjustCardScaleManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr, 100663389);
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0001E068 File Offset: 0x0001C268
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224732, XrefRangeEnd = 224735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnResolutionChangeCallback(AdjustCardScaleManager.AdjustCardScaleCallback callbackFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.NativeMethodInfoPtr_AddOnResolutionChangeCallback_Public_Void_AdjustCardScaleCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0001E0AC File Offset: 0x0001C2AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224735, XrefRangeEnd = 224738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnResolutionChangeCallback(AdjustCardScaleManager.AdjustCardScaleCallback callbackFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.NativeMethodInfoPtr_RemoveOnResolutionChangeCallback_Public_Void_AdjustCardScaleCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224751, RefRangeEnd = 224752, XrefRangeStart = 224738, XrefRangeEnd = 224751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnResolutionChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.NativeMethodInfoPtr_OnResolutionChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0001E124 File Offset: 0x0001C324
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdjustCardScaleManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002A7F File Offset: 0x00000C7F
	public AdjustCardScaleManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000120 RID: 288 RVA: 0x0001E160 File Offset: 0x0001C360
	// (set) Token: 0x06000121 RID: 289 RVA: 0x00002A88 File Offset: 0x00000C88
	public unsafe AdjustCardScaleManager.AdjustCardScaleCallback m_OnResolutionChangeCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleManager.NativeFieldInfoPtr_m_OnResolutionChangeCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdjustCardScaleManager.AdjustCardScaleCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleManager.NativeFieldInfoPtr_m_OnResolutionChangeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000B0 RID: 176
	private static readonly IntPtr NativeFieldInfoPtr_m_OnResolutionChangeCallback;

	// Token: 0x040000B1 RID: 177
	private static readonly IntPtr NativeMethodInfoPtr_AddOnResolutionChangeCallback_Public_Void_AdjustCardScaleCallback_0;

	// Token: 0x040000B2 RID: 178
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnResolutionChangeCallback_Public_Void_AdjustCardScaleCallback_0;

	// Token: 0x040000B3 RID: 179
	private static readonly IntPtr NativeMethodInfoPtr_OnResolutionChange_Public_Void_0;

	// Token: 0x040000B4 RID: 180
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000165 RID: 357
	public sealed class AdjustCardScaleCallback : MulticastDelegate
	{
		// Token: 0x0600229A RID: 8858 RVA: 0x00081EB0 File Offset: 0x000800B0
		// Note: this type is marked as 'beforefieldinit'.
		static AdjustCardScaleCallback()
		{
			Il2CppClassPointerStore<AdjustCardScaleManager.AdjustCardScaleCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdjustCardScaleManager>.NativeClassPtr, "AdjustCardScaleCallback");
			AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager.AdjustCardScaleCallback>.NativeClassPtr, 100666021);
			AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager.AdjustCardScaleCallback>.NativeClassPtr, 100666022);
			AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager.AdjustCardScaleCallback>.NativeClassPtr, 100666023);
			AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleManager.AdjustCardScaleCallback>.NativeClassPtr, 100666024);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00081F24 File Offset: 0x00080124
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdjustCardScaleCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdjustCardScaleManager.AdjustCardScaleCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00081F80 File Offset: 0x00080180
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00081FB4 File Offset: 0x000801B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00082018 File Offset: 0x00080218
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleManager.AdjustCardScaleCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00015CCD File Offset: 0x00013ECD
		public AdjustCardScaleCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00015CD6 File Offset: 0x00013ED6
		public static implicit operator AdjustCardScaleManager.AdjustCardScaleCallback(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<AdjustCardScaleManager.AdjustCardScaleCallback>(A_0);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00015CDE File Offset: 0x00013EDE
		public static AdjustCardScaleManager.AdjustCardScaleCallback operator +(AdjustCardScaleManager.AdjustCardScaleCallback A_0, AdjustCardScaleManager.AdjustCardScaleCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AdjustCardScaleManager.AdjustCardScaleCallback>();
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00015CEC File Offset: 0x00013EEC
		public static AdjustCardScaleManager.AdjustCardScaleCallback operator -(AdjustCardScaleManager.AdjustCardScaleCallback A_0, AdjustCardScaleManager.AdjustCardScaleCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AdjustCardScaleManager.AdjustCardScaleCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
