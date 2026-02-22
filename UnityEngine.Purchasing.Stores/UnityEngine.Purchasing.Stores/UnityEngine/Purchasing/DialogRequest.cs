using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000056 RID: 86
	public class DialogRequest : Object
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x0000FB58 File Offset: 0x0000DD58
		// Note: this type is marked as 'beforefieldinit'.
		static DialogRequest()
		{
			Il2CppClassPointerStore<DialogRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "DialogRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr);
			DialogRequest.NativeFieldInfoPtr_QueryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr, "QueryText");
			DialogRequest.NativeFieldInfoPtr_OkayButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr, "OkayButtonText");
			DialogRequest.NativeFieldInfoPtr_CancelButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr, "CancelButtonText");
			DialogRequest.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr, "Options");
			DialogRequest.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr, "Callback");
			DialogRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr, 100663670);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000376C File Offset: 0x0000196C
		public DialogRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003775 File Offset: 0x00001975
		public unsafe string QueryText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_QueryText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_QueryText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000FC64 File Offset: 0x0000DE64
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00003794 File Offset: 0x00001994
		public unsafe string OkayButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_OkayButtonText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_OkayButtonText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000037B3 File Offset: 0x000019B3
		public unsafe string CancelButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_CancelButtonText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_CancelButtonText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000FCB4 File Offset: 0x0000DEB4
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000037D2 File Offset: 0x000019D2
		public unsafe List<string> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000037F1 File Offset: 0x000019F1
		public unsafe Action<bool, int> Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRequest.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_QueryText;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_OkayButtonText;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_CancelButtonText;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_Callback;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
