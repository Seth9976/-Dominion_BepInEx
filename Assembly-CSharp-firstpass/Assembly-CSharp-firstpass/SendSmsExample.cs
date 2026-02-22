using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000134 RID: 308
public class SendSmsExample : MonoBehaviour
{
	// Token: 0x060016BF RID: 5823 RVA: 0x0006528C File Offset: 0x0006348C
	// Note: this type is marked as 'beforefieldinit'.
	static SendSmsExample()
	{
		Il2CppClassPointerStore<SendSmsExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SendSmsExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendSmsExample>.NativeClassPtr);
		SendSmsExample.NativeFieldInfoPtr_smsBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendSmsExample>.NativeClassPtr, "smsBody");
		SendSmsExample.NativeFieldInfoPtr_reciever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendSmsExample>.NativeClassPtr, "reciever");
		SendSmsExample.NativeMethodInfoPtr_SendSMS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendSmsExample>.NativeClassPtr, 100666036);
		SendSmsExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendSmsExample>.NativeClassPtr, 100666037);
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x0006530C File Offset: 0x0006350C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193014, XrefRangeEnd = 193018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendSMS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendSmsExample.NativeMethodInfoPtr_SendSMS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x00065340 File Offset: 0x00063540
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SendSmsExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendSmsExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendSmsExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0000B1D7 File Offset: 0x000093D7
	public SendSmsExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x060016C3 RID: 5827 RVA: 0x0006537C File Offset: 0x0006357C
	// (set) Token: 0x060016C4 RID: 5828 RVA: 0x0000B1E0 File Offset: 0x000093E0
	public unsafe Text smsBody
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendSmsExample.NativeFieldInfoPtr_smsBody);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendSmsExample.NativeFieldInfoPtr_smsBody), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x060016C5 RID: 5829 RVA: 0x000653AC File Offset: 0x000635AC
	// (set) Token: 0x060016C6 RID: 5830 RVA: 0x0000B1FF File Offset: 0x000093FF
	public unsafe Text reciever
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendSmsExample.NativeFieldInfoPtr_reciever);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendSmsExample.NativeFieldInfoPtr_reciever), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400112D RID: 4397
	private static readonly IntPtr NativeFieldInfoPtr_smsBody;

	// Token: 0x0400112E RID: 4398
	private static readonly IntPtr NativeFieldInfoPtr_reciever;

	// Token: 0x0400112F RID: 4399
	private static readonly IntPtr NativeMethodInfoPtr_SendSMS_Public_Void_0;

	// Token: 0x04001130 RID: 4400
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
