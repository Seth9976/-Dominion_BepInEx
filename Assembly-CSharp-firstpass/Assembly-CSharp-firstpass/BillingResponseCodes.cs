using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000017 RID: 23
public class BillingResponseCodes : Object
{
	// Token: 0x060001F5 RID: 501 RVA: 0x0001EAAC File Offset: 0x0001CCAC
	// Note: this type is marked as 'beforefieldinit'.
	static BillingResponseCodes()
	{
		Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "BillingResponseCodes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr);
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_OK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_OK");
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_USER_CANCELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_USER_CANCELED");
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE");
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE");
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_DEVELOPER_ERROR");
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_ERROR");
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED");
		BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_ERROR_BASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_ERROR_BASE");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_REMOTE_EXCEPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_REMOTE_EXCEPTION");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_BAD_RESPONSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_BAD_RESPONSE");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_VERIFICATION_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_VERIFICATION_FAILED");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_SEND_INTENT_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_SEND_INTENT_FAILED");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPERR_USER_CANCELLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPERR_USER_CANCELLED");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_PURCHASE_RESPONSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_UNKNOWN_PURCHASE_RESPONSE");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_MISSING_TOKEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_MISSING_TOKEN");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_UNKNOWN_ERROR");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_SUBSCRIPTIONS_NOT_AVAILABLE");
		BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_INVALID_CONSUMPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, "BILLINGHELPER_INVALID_CONSUMPTION");
		BillingResponseCodes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr, 100663616);
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0001EC6C File Offset: 0x0001CE6C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BillingResponseCodes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillingResponseCodes>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResponseCodes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x0000290B File Offset: 0x00000B0B
	public BillingResponseCodes(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
	// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002914 File Offset: 0x00000B14
	public unsafe static int BILLING_RESPONSE_RESULT_OK
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_OK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_OK, (void*)(&value));
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x060001FA RID: 506 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
	// (set) Token: 0x060001FB RID: 507 RVA: 0x00002922 File Offset: 0x00000B22
	public unsafe static int BILLING_RESPONSE_RESULT_USER_CANCELED
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_USER_CANCELED, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_USER_CANCELED, (void*)(&value));
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060001FC RID: 508 RVA: 0x0001ECE0 File Offset: 0x0001CEE0
	// (set) Token: 0x060001FD RID: 509 RVA: 0x00002930 File Offset: 0x00000B30
	public unsafe static int BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE, (void*)(&value));
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060001FE RID: 510 RVA: 0x0001ECFC File Offset: 0x0001CEFC
	// (set) Token: 0x060001FF RID: 511 RVA: 0x0000293E File Offset: 0x00000B3E
	public unsafe static int BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE, (void*)(&value));
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000200 RID: 512 RVA: 0x0001ED18 File Offset: 0x0001CF18
	// (set) Token: 0x06000201 RID: 513 RVA: 0x0000294C File Offset: 0x00000B4C
	public unsafe static int BILLING_RESPONSE_RESULT_DEVELOPER_ERROR
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_DEVELOPER_ERROR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_DEVELOPER_ERROR, (void*)(&value));
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000202 RID: 514 RVA: 0x0001ED34 File Offset: 0x0001CF34
	// (set) Token: 0x06000203 RID: 515 RVA: 0x0000295A File Offset: 0x00000B5A
	public unsafe static int BILLING_RESPONSE_RESULT_ERROR
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ERROR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ERROR, (void*)(&value));
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000204 RID: 516 RVA: 0x0001ED50 File Offset: 0x0001CF50
	// (set) Token: 0x06000205 RID: 517 RVA: 0x00002968 File Offset: 0x00000B68
	public unsafe static int BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED, (void*)(&value));
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x06000206 RID: 518 RVA: 0x0001ED6C File Offset: 0x0001CF6C
	// (set) Token: 0x06000207 RID: 519 RVA: 0x00002976 File Offset: 0x00000B76
	public unsafe static int BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED, (void*)(&value));
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000208 RID: 520 RVA: 0x0001ED88 File Offset: 0x0001CF88
	// (set) Token: 0x06000209 RID: 521 RVA: 0x00002984 File Offset: 0x00000B84
	public unsafe static int BILLINGHELPER_ERROR_BASE
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_ERROR_BASE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_ERROR_BASE, (void*)(&value));
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x0600020A RID: 522 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
	// (set) Token: 0x0600020B RID: 523 RVA: 0x00002992 File Offset: 0x00000B92
	public unsafe static int BILLINGHELPER_REMOTE_EXCEPTION
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_REMOTE_EXCEPTION, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_REMOTE_EXCEPTION, (void*)(&value));
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x0600020C RID: 524 RVA: 0x0001EDC0 File Offset: 0x0001CFC0
	// (set) Token: 0x0600020D RID: 525 RVA: 0x000029A0 File Offset: 0x00000BA0
	public unsafe static int BILLINGHELPER_BAD_RESPONSE
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_BAD_RESPONSE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_BAD_RESPONSE, (void*)(&value));
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x0600020E RID: 526 RVA: 0x0001EDDC File Offset: 0x0001CFDC
	// (set) Token: 0x0600020F RID: 527 RVA: 0x000029AE File Offset: 0x00000BAE
	public unsafe static int BILLINGHELPER_VERIFICATION_FAILED
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_VERIFICATION_FAILED, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_VERIFICATION_FAILED, (void*)(&value));
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000210 RID: 528 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
	// (set) Token: 0x06000211 RID: 529 RVA: 0x000029BC File Offset: 0x00000BBC
	public unsafe static int BILLINGHELPER_SEND_INTENT_FAILED
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_SEND_INTENT_FAILED, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_SEND_INTENT_FAILED, (void*)(&value));
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000212 RID: 530 RVA: 0x0001EE14 File Offset: 0x0001D014
	// (set) Token: 0x06000213 RID: 531 RVA: 0x000029CA File Offset: 0x00000BCA
	public unsafe static int BILLINGHELPERR_USER_CANCELLED
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPERR_USER_CANCELLED, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPERR_USER_CANCELLED, (void*)(&value));
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000214 RID: 532 RVA: 0x0001EE30 File Offset: 0x0001D030
	// (set) Token: 0x06000215 RID: 533 RVA: 0x000029D8 File Offset: 0x00000BD8
	public unsafe static int BILLINGHELPER_UNKNOWN_PURCHASE_RESPONSE
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_PURCHASE_RESPONSE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_PURCHASE_RESPONSE, (void*)(&value));
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000216 RID: 534 RVA: 0x0001EE4C File Offset: 0x0001D04C
	// (set) Token: 0x06000217 RID: 535 RVA: 0x000029E6 File Offset: 0x00000BE6
	public unsafe static int BILLINGHELPER_MISSING_TOKEN
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_MISSING_TOKEN, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_MISSING_TOKEN, (void*)(&value));
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000218 RID: 536 RVA: 0x0001EE68 File Offset: 0x0001D068
	// (set) Token: 0x06000219 RID: 537 RVA: 0x000029F4 File Offset: 0x00000BF4
	public unsafe static int BILLINGHELPER_UNKNOWN_ERROR
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_ERROR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_ERROR, (void*)(&value));
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600021A RID: 538 RVA: 0x0001EE84 File Offset: 0x0001D084
	// (set) Token: 0x0600021B RID: 539 RVA: 0x00002A02 File Offset: 0x00000C02
	public unsafe static int BILLINGHELPER_SUBSCRIPTIONS_NOT_AVAILABLE
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_SUBSCRIPTIONS_NOT_AVAILABLE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_SUBSCRIPTIONS_NOT_AVAILABLE, (void*)(&value));
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600021C RID: 540 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
	// (set) Token: 0x0600021D RID: 541 RVA: 0x00002A10 File Offset: 0x00000C10
	public unsafe static int BILLINGHELPER_INVALID_CONSUMPTION
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_INVALID_CONSUMPTION, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BillingResponseCodes.NativeFieldInfoPtr_BILLINGHELPER_INVALID_CONSUMPTION, (void*)(&value));
		}
	}

	// Token: 0x040001C0 RID: 448
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_OK;

	// Token: 0x040001C1 RID: 449
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_USER_CANCELED;

	// Token: 0x040001C2 RID: 450
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE;

	// Token: 0x040001C3 RID: 451
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE;

	// Token: 0x040001C4 RID: 452
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_DEVELOPER_ERROR;

	// Token: 0x040001C5 RID: 453
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ERROR;

	// Token: 0x040001C6 RID: 454
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED;

	// Token: 0x040001C7 RID: 455
	private static readonly IntPtr NativeFieldInfoPtr_BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED;

	// Token: 0x040001C8 RID: 456
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_ERROR_BASE;

	// Token: 0x040001C9 RID: 457
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_REMOTE_EXCEPTION;

	// Token: 0x040001CA RID: 458
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_BAD_RESPONSE;

	// Token: 0x040001CB RID: 459
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_VERIFICATION_FAILED;

	// Token: 0x040001CC RID: 460
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_SEND_INTENT_FAILED;

	// Token: 0x040001CD RID: 461
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPERR_USER_CANCELLED;

	// Token: 0x040001CE RID: 462
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_PURCHASE_RESPONSE;

	// Token: 0x040001CF RID: 463
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_MISSING_TOKEN;

	// Token: 0x040001D0 RID: 464
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_UNKNOWN_ERROR;

	// Token: 0x040001D1 RID: 465
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_SUBSCRIPTIONS_NOT_AVAILABLE;

	// Token: 0x040001D2 RID: 466
	private static readonly IntPtr NativeFieldInfoPtr_BILLINGHELPER_INVALID_CONSUMPTION;

	// Token: 0x040001D3 RID: 467
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
