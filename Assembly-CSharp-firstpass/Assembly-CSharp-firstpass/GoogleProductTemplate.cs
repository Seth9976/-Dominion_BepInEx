using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Serializable]
public class GoogleProductTemplate : global::Il2CppSystem.Object
{
	// Token: 0x06000283 RID: 643 RVA: 0x00020A18 File Offset: 0x0001EC18
	// Note: this type is marked as 'beforefieldinit'.
	static GoogleProductTemplate()
	{
		Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GoogleProductTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr);
		GoogleProductTemplate.NativeFieldInfoPtr_DEFAULT_PRICE_AMOUNT_MICROS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "DEFAULT_PRICE_AMOUNT_MICROS");
		GoogleProductTemplate.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "IsOpen");
		GoogleProductTemplate.NativeFieldInfoPtr_SKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "SKU");
		GoogleProductTemplate.NativeFieldInfoPtr__OriginalJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_OriginalJson");
		GoogleProductTemplate.NativeFieldInfoPtr__LocalizedPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_LocalizedPrice");
		GoogleProductTemplate.NativeFieldInfoPtr__PriceAmountMicros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_PriceAmountMicros");
		GoogleProductTemplate.NativeFieldInfoPtr__PriceCurrencyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_PriceCurrencyCode");
		GoogleProductTemplate.NativeFieldInfoPtr__Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_Description");
		GoogleProductTemplate.NativeFieldInfoPtr__Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_Title");
		GoogleProductTemplate.NativeFieldInfoPtr__Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_Texture");
		GoogleProductTemplate.NativeFieldInfoPtr__ProductType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, "_ProductType");
		GoogleProductTemplate.NativeMethodInfoPtr_get_OriginalJson_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663687);
		GoogleProductTemplate.NativeMethodInfoPtr_set_OriginalJson_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663688);
		GoogleProductTemplate.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663689);
		GoogleProductTemplate.NativeMethodInfoPtr_set_Price_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663690);
		GoogleProductTemplate.NativeMethodInfoPtr_get_PriceAmountMicros_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663691);
		GoogleProductTemplate.NativeMethodInfoPtr_set_PriceAmountMicros_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663692);
		GoogleProductTemplate.NativeMethodInfoPtr_get_PriceCurrencyCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663693);
		GoogleProductTemplate.NativeMethodInfoPtr_set_PriceCurrencyCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663694);
		GoogleProductTemplate.NativeMethodInfoPtr_get_LocalizedPrice_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663695);
		GoogleProductTemplate.NativeMethodInfoPtr_set_LocalizedPrice_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663696);
		GoogleProductTemplate.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663697);
		GoogleProductTemplate.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663698);
		GoogleProductTemplate.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663699);
		GoogleProductTemplate.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663700);
		GoogleProductTemplate.NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663701);
		GoogleProductTemplate.NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663702);
		GoogleProductTemplate.NativeMethodInfoPtr_get_ProductType_Public_get_AN_InAppType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663703);
		GoogleProductTemplate.NativeMethodInfoPtr_set_ProductType_Public_set_Void_AN_InAppType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663704);
		GoogleProductTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr, 100663705);
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000284 RID: 644 RVA: 0x00020CA0 File Offset: 0x0001EEA0
	// (set) Token: 0x06000285 RID: 645 RVA: 0x00020CD8 File Offset: 0x0001EED8
	public unsafe string OriginalJson
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_OriginalJson_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_OriginalJson_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000286 RID: 646 RVA: 0x00020D1C File Offset: 0x0001EF1C
	// (set) Token: 0x06000287 RID: 647 RVA: 0x00020D58 File Offset: 0x0001EF58
	public unsafe float Price
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_Price_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000288 RID: 648 RVA: 0x00020D98 File Offset: 0x0001EF98
	// (set) Token: 0x06000289 RID: 649 RVA: 0x00020DD4 File Offset: 0x0001EFD4
	public unsafe long PriceAmountMicros
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_PriceAmountMicros_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_PriceAmountMicros_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x0600028A RID: 650 RVA: 0x00020E14 File Offset: 0x0001F014
	// (set) Token: 0x0600028B RID: 651 RVA: 0x00020E4C File Offset: 0x0001F04C
	public unsafe string PriceCurrencyCode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_PriceCurrencyCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_PriceCurrencyCode_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x0600028C RID: 652 RVA: 0x00020E90 File Offset: 0x0001F090
	// (set) Token: 0x0600028D RID: 653 RVA: 0x00020EC8 File Offset: 0x0001F0C8
	public unsafe string LocalizedPrice
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_LocalizedPrice_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_LocalizedPrice_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x0600028E RID: 654 RVA: 0x00020F0C File Offset: 0x0001F10C
	// (set) Token: 0x0600028F RID: 655 RVA: 0x00020F44 File Offset: 0x0001F144
	public unsafe string Description
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000290 RID: 656 RVA: 0x00020F88 File Offset: 0x0001F188
	// (set) Token: 0x06000291 RID: 657 RVA: 0x00020FC0 File Offset: 0x0001F1C0
	public unsafe string Title
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000292 RID: 658 RVA: 0x00021004 File Offset: 0x0001F204
	// (set) Token: 0x06000293 RID: 659 RVA: 0x00021044 File Offset: 0x0001F244
	public unsafe Texture2D Texture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000294 RID: 660 RVA: 0x00021088 File Offset: 0x0001F288
	// (set) Token: 0x06000295 RID: 661 RVA: 0x000210C4 File Offset: 0x0001F2C4
	public unsafe AN_InAppType ProductType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24292, RefRangeEnd = 24293, XrefRangeStart = 24292, XrefRangeEnd = 24293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_get_ProductType_Public_get_AN_InAppType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr_set_ProductType_Public_set_Void_AN_InAppType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00021104 File Offset: 0x0001F304
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 162453, RefRangeEnd = 162458, XrefRangeStart = 162442, XrefRangeEnd = 162453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GoogleProductTemplate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleProductTemplate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002B5B File Offset: 0x00000D5B
	public GoogleProductTemplate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000298 RID: 664 RVA: 0x00021140 File Offset: 0x0001F340
	// (set) Token: 0x06000299 RID: 665 RVA: 0x00002B64 File Offset: 0x00000D64
	public unsafe static long DEFAULT_PRICE_AMOUNT_MICROS
	{
		get
		{
			long num;
			IL2CPP.il2cpp_field_static_get_value(GoogleProductTemplate.NativeFieldInfoPtr_DEFAULT_PRICE_AMOUNT_MICROS, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleProductTemplate.NativeFieldInfoPtr_DEFAULT_PRICE_AMOUNT_MICROS, (void*)(&value));
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600029A RID: 666 RVA: 0x0002115C File Offset: 0x0001F35C
	// (set) Token: 0x0600029B RID: 667 RVA: 0x00002B72 File Offset: 0x00000D72
	public unsafe bool IsOpen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr_IsOpen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr_IsOpen)) = value;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600029C RID: 668 RVA: 0x00021184 File Offset: 0x0001F384
	// (set) Token: 0x0600029D RID: 669 RVA: 0x00002B8D File Offset: 0x00000D8D
	public unsafe string SKU
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr_SKU);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr_SKU), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600029E RID: 670 RVA: 0x000211AC File Offset: 0x0001F3AC
	// (set) Token: 0x0600029F RID: 671 RVA: 0x00002BAC File Offset: 0x00000DAC
	public unsafe string _OriginalJson
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__OriginalJson);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__OriginalJson), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060002A0 RID: 672 RVA: 0x000211D4 File Offset: 0x0001F3D4
	// (set) Token: 0x060002A1 RID: 673 RVA: 0x00002BCB File Offset: 0x00000DCB
	public unsafe string _LocalizedPrice
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__LocalizedPrice);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__LocalizedPrice), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060002A2 RID: 674 RVA: 0x000211FC File Offset: 0x0001F3FC
	// (set) Token: 0x060002A3 RID: 675 RVA: 0x00002BEA File Offset: 0x00000DEA
	public unsafe long _PriceAmountMicros
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__PriceAmountMicros);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__PriceAmountMicros)) = value;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060002A4 RID: 676 RVA: 0x00021224 File Offset: 0x0001F424
	// (set) Token: 0x060002A5 RID: 677 RVA: 0x00002C05 File Offset: 0x00000E05
	public unsafe string _PriceCurrencyCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__PriceCurrencyCode);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__PriceCurrencyCode), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060002A6 RID: 678 RVA: 0x0002124C File Offset: 0x0001F44C
	// (set) Token: 0x060002A7 RID: 679 RVA: 0x00002C24 File Offset: 0x00000E24
	public unsafe string _Description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__Description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__Description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060002A8 RID: 680 RVA: 0x00021274 File Offset: 0x0001F474
	// (set) Token: 0x060002A9 RID: 681 RVA: 0x00002C43 File Offset: 0x00000E43
	public unsafe string _Title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__Title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__Title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060002AA RID: 682 RVA: 0x0002129C File Offset: 0x0001F49C
	// (set) Token: 0x060002AB RID: 683 RVA: 0x00002C62 File Offset: 0x00000E62
	public unsafe Texture2D _Texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__Texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060002AC RID: 684 RVA: 0x000212CC File Offset: 0x0001F4CC
	// (set) Token: 0x060002AD RID: 685 RVA: 0x00002C81 File Offset: 0x00000E81
	public unsafe AN_InAppType _ProductType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__ProductType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductTemplate.NativeFieldInfoPtr__ProductType)) = value;
		}
	}

	// Token: 0x04000228 RID: 552
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PRICE_AMOUNT_MICROS;

	// Token: 0x04000229 RID: 553
	private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

	// Token: 0x0400022A RID: 554
	private static readonly IntPtr NativeFieldInfoPtr_SKU;

	// Token: 0x0400022B RID: 555
	private static readonly IntPtr NativeFieldInfoPtr__OriginalJson;

	// Token: 0x0400022C RID: 556
	private static readonly IntPtr NativeFieldInfoPtr__LocalizedPrice;

	// Token: 0x0400022D RID: 557
	private static readonly IntPtr NativeFieldInfoPtr__PriceAmountMicros;

	// Token: 0x0400022E RID: 558
	private static readonly IntPtr NativeFieldInfoPtr__PriceCurrencyCode;

	// Token: 0x0400022F RID: 559
	private static readonly IntPtr NativeFieldInfoPtr__Description;

	// Token: 0x04000230 RID: 560
	private static readonly IntPtr NativeFieldInfoPtr__Title;

	// Token: 0x04000231 RID: 561
	private static readonly IntPtr NativeFieldInfoPtr__Texture;

	// Token: 0x04000232 RID: 562
	private static readonly IntPtr NativeFieldInfoPtr__ProductType;

	// Token: 0x04000233 RID: 563
	private static readonly IntPtr NativeMethodInfoPtr_get_OriginalJson_Public_get_String_0;

	// Token: 0x04000234 RID: 564
	private static readonly IntPtr NativeMethodInfoPtr_set_OriginalJson_Public_set_Void_String_0;

	// Token: 0x04000235 RID: 565
	private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

	// Token: 0x04000236 RID: 566
	private static readonly IntPtr NativeMethodInfoPtr_set_Price_Public_set_Void_Single_0;

	// Token: 0x04000237 RID: 567
	private static readonly IntPtr NativeMethodInfoPtr_get_PriceAmountMicros_Public_get_Int64_0;

	// Token: 0x04000238 RID: 568
	private static readonly IntPtr NativeMethodInfoPtr_set_PriceAmountMicros_Public_set_Void_Int64_0;

	// Token: 0x04000239 RID: 569
	private static readonly IntPtr NativeMethodInfoPtr_get_PriceCurrencyCode_Public_get_String_0;

	// Token: 0x0400023A RID: 570
	private static readonly IntPtr NativeMethodInfoPtr_set_PriceCurrencyCode_Public_set_Void_String_0;

	// Token: 0x0400023B RID: 571
	private static readonly IntPtr NativeMethodInfoPtr_get_LocalizedPrice_Public_get_String_0;

	// Token: 0x0400023C RID: 572
	private static readonly IntPtr NativeMethodInfoPtr_set_LocalizedPrice_Public_set_Void_String_0;

	// Token: 0x0400023D RID: 573
	private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

	// Token: 0x0400023E RID: 574
	private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

	// Token: 0x0400023F RID: 575
	private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

	// Token: 0x04000240 RID: 576
	private static readonly IntPtr NativeMethodInfoPtr_set_Title_Public_set_Void_String_0;

	// Token: 0x04000241 RID: 577
	private static readonly IntPtr NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0;

	// Token: 0x04000242 RID: 578
	private static readonly IntPtr NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0;

	// Token: 0x04000243 RID: 579
	private static readonly IntPtr NativeMethodInfoPtr_get_ProductType_Public_get_AN_InAppType_0;

	// Token: 0x04000244 RID: 580
	private static readonly IntPtr NativeMethodInfoPtr_set_ProductType_Public_set_Void_AN_InAppType_0;

	// Token: 0x04000245 RID: 581
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
